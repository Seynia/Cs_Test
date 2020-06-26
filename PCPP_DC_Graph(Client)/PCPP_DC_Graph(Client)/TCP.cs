using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using PCPP_DC_Graph_Client_;
using System.Runtime.CompilerServices;
using System.Drawing;

enum csConnStatus
{
    Closed,
    Listening,
    Connecting,
    Connected
};

static class Util
{
    // argument를 기준으로 현재 시간과의 차이를 계산한다.
    public static double Tsec(DateTime sTime)
    {
        return DateTime.Now.Subtract(sTime).Ticks / 1e7;
    }

    // CheckSum을 계산하여 데이터에 오류가 있는지 없는지 검사할 수 있는 함수이다.
    // 16바이트의 값을 string으로 반환한다.
    public static string CheckSum(string data)
    {
        string hash;
        using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
        {
            hash = BitConverter.ToString(
              md5.ComputeHash(Encoding.UTF8.GetBytes(data.ToString()))
            ).Replace("-", String.Empty);
        }
        return hash;
    }

    // 폼 이미지를 캡쳐하는 함수이다. 데이터 자동 수집을 위해 작성하였다.
    // fname은 파일이름과 확장자를 포함한 string 형식이다.
    public static void ScreenCapture(Form1 form, string fname)
    {
        Size size = new Size(form.Width - 16, form.Height - 13);
        Bitmap bmap = new Bitmap(size.Width, size.Height);
        Graphics grp = Graphics.FromImage(bmap);
        string deskAddr = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        grp.CopyFromScreen(new Point(form.Bounds.X + 8, form.Bounds.Y + 5), new Point(0, 0), size);
        bmap.Save(deskAddr + "\\" + fname);
        bmap.Dispose();
    }
}

static class TSocket // string을 반환하도록 모두 수정하였다.
{
    public static string sSTX() { return Convert.ToChar(0x02).ToString(); }
    public static string sETX() { return Convert.ToChar(0x03).ToString(); }
    public static string sEOT() { return Convert.ToChar(0x04).ToString(); }
    public static string sENQ() { return Convert.ToChar(0x05).ToString(); }
    public static string sACK() { return Convert.ToChar(0x06).ToString(); }
    public static string sNAK() { return Convert.ToChar(0x15).ToString(); }
    public static string sCR() { return Convert.ToChar(13).ToString(); }
    public static string sLF() { return Convert.ToChar(10).ToString(); }
    public static string sCRLF() { return "\r\n"; }

    public static string HostName()
    {
        return Dns.GetHostName();
    }

    public static IPAddress[] HostAddresses()
    {
        string hostname = HostName();
        IPAddress[] ips = Dns.GetHostAddresses(hostname);
        return ips;
    }
}

// 데이터 수신 이벤트핸들링 함수 delegate 원형
public delegate void ServerDataArrivalHandler();

// 데이터 수신 이벤트핸들링 함수 delegate 원형
public delegate void ClientDataArrivalHandler();

class TClient
{
    private const int buffersize = 1024;

    // Client용 Socket 객체
    private TcpClient clientForClient = null;
    private NetworkStream streamClient = null;

    // 현재의 상태
    private csConnStatus clientStatus = csConnStatus.Closed;

    // Client용 수신 thread
    private Thread threadClientRcv = null;
    private Thread threadChkPartnerDeath = null;

    // Client 수신 데이터
    private string clientRcvMessage = "";

    // 수신이벤트를 위한 델리게이트
    private ClientDataArrivalHandler DataArrivalCallback;
    //===============================================================
    //  생성자 1 : 수신데이터 이벤트핸들링 없은 경우.
    //  생성자 2 : 수신데이터 이벤트핸들링 함수를 지정하는 경우
    //===============================================================
    public TClient()
    {
        DataArrivalCallback = null;
    }
    public TClient(ClientDataArrivalHandler callback)
    {
        DataArrivalCallback = new ClientDataArrivalHandler(callback);
    }

    //===============================================================
    //  Client : Connect 시도 [Async 모드]
    //===============================================================
    public void ClientBeginConnect(string serverIP, int serverPort, string clientIP)
    {
        if (clientStatus == csConnStatus.Connected) return;
        if (clientStatus == csConnStatus.Connecting) return;

        // server측 접속 IP 객체 얻기
        IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);

        // client측 접속 IP 객체 얻기
        // port = 0은 임의의 할당포트 사용하겠다는 뜻
        int dumport = 0;
        IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(clientIP), dumport);

        // client 객체 얻기
        clientForClient = new TcpClient(clientAddress);

        // connected 시작
        IPAddress serverIpAddress = IPAddress.Parse(serverIP);
        clientForClient.BeginConnect(serverIpAddress, serverPort, new AsyncCallback(DoConnectTcpClientCallback), clientForClient);

        clientStatus = csConnStatus.Connecting;
    }

    //---------------------------------------------------------------
    //  Connect CallBack 함수
    //---------------------------------------------------------------
    private void DoConnectTcpClientCallback(IAsyncResult ar)
    {
        try
        {
            clientForClient = (TcpClient)ar.AsyncState;
            clientForClient.EndConnect(ar);
            streamClient = clientForClient.GetStream(); // stream 객체 얻기

            // 수신 thread 시작
            threadClientRcv = new Thread(ClientReceiveThreadMain);
            threadClientRcv.IsBackground = true;
            threadClientRcv.Start();

            // 상대 돌발죽음 감시 thread 시작
            threadChkPartnerDeath = new Thread(ClientCheckPartnerDeathThread);
            threadChkPartnerDeath.IsBackground = true;
            threadChkPartnerDeath.Start();

            clientStatus = csConnStatus.Connected;
        }
        catch
        {
            clientStatus = csConnStatus.Closed;
        }
    }

    //===============================================================
    //  Client : Close
    //===============================================================
    public void ClientClose()
    {
        if (clientForClient != null) clientForClient.Close();
        clientForClient = null;

        // 순서 바뀌면 안됨
        if (threadClientRcv != null && threadClientRcv.IsAlive)
        {
            threadClientRcv.Abort();
            threadClientRcv.Join();
        }

        if (threadChkPartnerDeath != null && threadChkPartnerDeath.IsAlive)
        {
            threadChkPartnerDeath.Abort();
            threadChkPartnerDeath.Join();
        }

        clientStatus = csConnStatus.Closed;
    }

    //===============================================================
    //  Client Status
    //===============================================================
    public csConnStatus ClientStatus()
    {
        return clientStatus;
    }

    //===============================================================
    //  Client Send
    //===============================================================
    public void ClientSend(string st)
    {
        try
        {
            if (streamClient == null || !streamClient.CanWrite) return;
            byte[] msg = Encoding.UTF8.GetBytes(st);
            streamClient.Write(msg, 0, msg.Length);
        }
        catch { }
    }

    //===============================================================
    //  수신 데이터 꺼내기
    //===============================================================
    public string GetRcvMsg()
    {
        lock (clientRcvMessage)  //<- thread간 동기화
        {
            string tmp = clientRcvMessage;
            clientRcvMessage = "";
            return tmp;
        }
    }

    //===============================================================
    //  Client Receive Thread Main
    //===============================================================
    private void ClientReceiveThreadMain()
    {
        try
        {
            byte[] bytebuff = new byte[buffersize];
            while (true)
            {
                Thread.Sleep(1);

                if (streamClient == null) continue;
                if (!streamClient.CanRead) continue;

                StringBuilder strbuff = new StringBuilder();
                int nbyteRead = 0;

                // 도착 message가 buffer 크기보다 큰 경우를 위해 loop
                do
                {
                    nbyteRead = streamClient.Read(bytebuff, 0, bytebuff.Length);    // blocking
                    if (nbyteRead == 0)
                    {   // 상대방이 close했음을 감지
                        clientStatus = csConnStatus.Closed;
                        ClientClose();
                    }
                    strbuff.AppendFormat("{0}", Encoding.UTF8.GetString(bytebuff, 0, nbyteRead));
                }
                while (streamClient.DataAvailable);

                // 수신버퍼에 복사
                lock (clientRcvMessage)  //<- thread간 동기화
                {
                    clientRcvMessage += strbuff;
                }

                // 데이터 수신 callback 함수 호출
                if (DataArrivalCallback != null) { DataArrivalCallback(); }
            }
        }
        catch
        { }
    }

    //===============================================================
    //  Client Check Partner Death Thread
    //===============================================================
    private void ClientCheckPartnerDeathThread()
    {
        try
        {
            while (true)
            {
                Thread.Sleep(5);

                // 상대방이 connected에서 갑자기 꺼져 버리면
                // Closed로 바꾸는 방법이 정기적인 검사밖에 없음. 
                // 상황보다 약간 늦게 알게되지만 상관없음.
                if (clientStatus == csConnStatus.Connected)
                {
                    if (clientForClient != null && clientForClient.Client != null)
                    {
                        if (clientForClient.Client.Connected == false)
                            clientStatus = csConnStatus.Closed;
                    }
                }
                if (clientStatus != csConnStatus.Connected) break;
            }
        }
        catch { }
    }
}