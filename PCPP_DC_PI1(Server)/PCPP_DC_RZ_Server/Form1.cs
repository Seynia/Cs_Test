using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Distributed Computing Pi1 (Server)
namespace PCPP_DC_RZ_Server
{
    public partial class Form1 : Form
    {
        // 연한색의 빨강, 노랑, 초록의 R,G,B 값을 저장한다.
        private Color
            red = Color.FromArgb(255, 128, 128),
            yellow = Color.FromArgb(255, 255, 128),
            green = Color.FromArgb(128, 255, 128);

        /* Server객체의 Status에 따라 색을 일일이 바꾸기 위해서는 status마다 색을 다르게 지정하는 코드를 작성하여야하고, 코드가 길어진다.
           csConnStatus는 enum 객체이므로 Status의 인덱스를 int형의 인덱스로 바꿀 수 있기 때문에
           위의 Color 객체를 배열에 저장하고 이에 따라서 자동으로 label의 색을 바꾸기 위한 객체 배열이다.*/
        Color[] col;

        /* 각 수신된 정보를 임시로 담을 수 있는 버퍼이다. 함수를 오가며 작동하여야하기 때문에 전역변수로 설정하였다.
           string 객체의 경우 보통 + 연산자 오버로딩을 이용하여 객체의 크기를 늘려가는데, 이 때마다 새로운 객체를 만들어 할당하는 방식이기 때문에
           매우 비효율적인 코드가 되고, 통신 특성상 잦은 사이즈 변경과 고정된 횟수만큼 작업하는 것이 아니기 때문에 미리 큰 공간을 확보하고 바로
           집어넣는 StringBuilder 객체를 사용하였다. 쓰레드 안정성을 위해 StringBuffer 객체를 사용하면 더 좋지만 C#에는 존재하지 않는다. */
        private StringBuilder
            Send_Buff = new StringBuilder(),
            Recv_Buff = new StringBuilder();

        // 각 IP 주소를 저장하기 위한 객체이다.
        string
            myIP = TSocket.HostAddresses()[1].ToString(), //XP는 [0]
            cIP = TSocket.HostAddresses()[1].ToString();

        // 클라이언트와 TCP 통신을 하기 위한 객체이다.
        private TServer server;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 라벨색을 설정할 Color 배열이다. R = 준비안됨, Y = 준비중, G = 완료
            col = new Color[4] { red, yellow, yellow, green };

            // 호스트의 IP를 기본값으로 넣는다.
            txt_IP.Text = cIP;
        }

        // IP를 호스트의 주소로 설정한다.
        private void btn_me_Click(object sender, EventArgs e)
        {
            cIP = myIP;
            server.ServerClose();
        }

        // IP를 설정하기 위한 버튼이다.
        private void btn_IP_Click(object sender, EventArgs e)
        {
            cIP = txt_IP.Text;
            server.ServerClose();
        }

        // 수신 타이머이다.
        private void tim_GetRevMsg_Tick(object sender, EventArgs e)
        {
            // server 객체가 할당되지 않으면 return 한다.
            if (server == null) return;

            // 클라이언트에서 수신한 데이터를 임시 변수에 저장한다.
            string st = server.GetRcvMsg();

            // 유효한 데이터를 받아왔다면 데이터 가공을 시작한다.
            if (st.Length > 0)
            {
                // 버퍼값에 임시 데이터를 추가한다.
                Recv_Buff.Append(st);

                // 처음 받아온 데이터가 STX로 시작하는 유효한 데이터인지 검증한다.
                bool isSTX = Recv_Buff.ToString().StartsWith(TSocket.sSTX());

                // 받아온 데이터가 마지막 데이터라는 의미로 끝이 ETX로 끝나는지 검증한다.
                bool isETX = st.EndsWith(TSocket.sETX());

                // 만약 유효한 데이터가 아니라고 판단되면 버퍼를 비워버린다.
                if (!isSTX) Recv_Buff.Clear();

                // 처음과 끝이 프로토콜에 맞는 데이터가 도착하면
                else if (isSTX && isETX)
                {
                    // 시작과 종결 값을 제거하여 유의미한 데이터만 남긴다.
                    st = Recv_Buff.ToString().Substring(1, Recv_Buff.Length - 2);

                    // 받아온 문자열 데이터(범위 값)를 프로토콜에 따라 ','로 구분하여 분리하여 문자열 배열에 저장한다.
                    string[] Range = st.Split(',');

                    // 만약 데이터(범위값)가 두 개가 아니라면 return
                    if (Range.Length != 2)
                    {
                        Recv_Buff.Clear();
                        Send_Buff.Clear();
                        return;
                    }

                    // Range 라벨에 두 개의 범위를 적절한 형식으로 출력한다.
                    lbl_Range.Text = Range[0] + " ~ " + Range[1];

                    // 두 범위를 int형으로 형변환을 한다.
                    int start = Convert.ToInt32(Range[0]);
                    int end = Convert.ToInt32(Range[1]);

                    // π(x) 값들을 계산한다.
                    calculate_PI(start, end);

                    // 버퍼값들을 모두 비워 언제든 재시작할 수 있도록 한다.
                    Recv_Buff.Clear();
                    Send_Buff.Clear();
                }
            }
        }

        // Calculate π(x)
        private void calculate_PI(int start, int end)
        {
            // 시간 측정을 시작하고 Calculation 라벨을 업데이트한다.
            DateTime ss = DateTime.Now;
            lbl_Cal.Text = "Calculating...";
            lbl_Cal.BackColor = yellow;

            // 라벨 업데이트를 기다린다.
            Application.DoEvents();
            
            // 최종 결과가 들어갈 int[]와 에라토스테네스의 체 알고리즘에 사용할 bool[] 객체를 선언한다.
            int[] result = new int[end + 1];
            int step = 37500, i;

            // TCP.cs 내에 있는 Prime 객체의 Cal 멤버를 통해 계산한다.
            Util.Cal_PI(start, end, ref result);

            // 유효한 결과가 나왔는지 테스트하기 위해 최종 π(x) 값을 출력하고 Cal 라벨을 업데이트한다..
            lbl_cnt.Text = result[result.Length - 1].ToString();
            lbl_Cal.Text = "Complete";
            lbl_Cal.BackColor = green;

            // 여기까지 걸린 시간을 측정하여 계산 시간을 소수점 두자리까지 출력한다.
            string EndTime = Util.Tsec(ss).ToString("F2");
            lbl_Time.Text = EndTime + " sec";

            // Trans 라벨을 업데이트 한다.
            lbl_Trans.Text = "Sending...";
            lbl_Trans.BackColor = yellow;
            Application.DoEvents();

            // 송신 버퍼에 최초값으로 시작값을 넣는다.
            Send_Buff.Append(TSocket.sSTX());

            // 프로토콜에 맞게 데이터를 가공한다. {2:1,3:1,4:2, ...}
            for (i = start; i <= end; i += step)
            {
                Send_Buff.Append(i).Append(':').Append(result[i]).Append(',');
            }
            // 스텝에 따라 건너띄면 최종값이 제대로 들어가지 않는 경우가 많기 때문에 최종값을 따로 추가한다.
            if( i - step != end) Send_Buff.Append(end).Append(':').Append(result[end]).Append(',');

            /* 계산 시간을 소수점 두 자리까지 계산된 계산 시간을 뒤에 붙이고,
             * CheckSum 값을 덧붙이고 마지막으로 종결값을 더해 전송한다. */
            Send_Buff.Append(EndTime);
            string CS = lbl_CS.Text = Util.CheckSum(Send_Buff.ToString());
            string st = Send_Buff.Append(CS).Append(TSocket.sETX()).ToString();
            server.ServerSend(st);

            // 송신라벨을 완료로 업데이트한다.
            lbl_Trans.Text = "Complete";
            lbl_Trans.BackColor = green;
        }

        // 주기적으로 통신 상태를 업데이트 하는 타이머이다.
        private void tim_ConStatus_Tick(object sender, EventArgs e)
        {
            // 서버 객체가 할당이 되어 있지 않다면 할당한다.
            if (server == null) server = new TServer();

            // 서버 객체가 할당이 된 상태라면 라벨을 업데이트한다.
            else if (server != null)
            {
                lbl_CommReady.Text = server.ServerStatus().ToString();

                // CsConnStatus 반환 인덱스 값을 int로 바꾸어 Color 객체 배열의 인덱스로 사용하여 색 변경.
                lbl_CommReady.BackColor = col[Convert.ToInt32(server.ServerStatus())];
            }
            
            // server가 closed 상태라면
            if (server.ServerStatus() == csConnStatus.Closed)
            {
                try
                {
                    // '.'이 세 개가 있는 string 값이 아니라면 예외를 발생시킨다.
                    if (cIP.Length - cIP.Replace(".", "").Length != 3)
                    {
                        throw new ArgumentException("e");
                    }
                    server.ServerStartListen(cIP, 6060);
                }
                catch
                {
                    // 예외가 발생하면 통신 상태 라벨을 바꾼다.
                    lbl_CommReady.Text = "Wrong IP Adress";
                }
            }
        }
    }
}