using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 19110015 최호승입니다. 위에서 아래로 순서대로 훑어보시면 됩니다.

namespace PCPP_DC_Graph_Client_
{
    public partial class Form1 : Form
    {
        /* 파일을 저장하기 위한 flag : true이면 사용자의 바탕화면에 자동으로 저장이 된다.
         * 중간에 모종의 오류나 실수로 값이 바뀌어 에러가 발생하는 것을 방지하기 위해 const로 선언한다.*/
        const bool save = true;

        // 스크린 캡쳐를 할 때 번호가 하나씩 올라가며 저장되게 하기 위한 카운트이다.
        int scr = 0;

        // 바탕화면의 환경변수를 자동으로 추출하여 string에 저장한다.
        string deskAddr = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // 파일을 저장하기 위한 file stream 객체이다.
        StreamWriter sw;

        // 연한색의 빨강, 노랑, 초록의 R,G,B 값을 저장한다.
        private Color
            red = Color.FromArgb(255, 128, 128),
            yellow = Color.FromArgb(255, 255, 128),
            green = Color.FromArgb(128, 255, 128);

        /* Client 객체의 Status에 따라 라벨 색을 일일이 바꾸기 위해서는 status마다 색을 다르게 지정하는 코드를 작성하여야하고, 코드가 길어진다.
           csConnStatus는 enum 객체이므로 Status의 인덱스를 int형의 인덱스로 바꿀 수 있기 때문에
           위의 Color 객체를 배열에 저장하고 이에 따라서 자동으로 label의 색을 바꾸기 위한 객체 배열이다.*/
        Color[] col;

        // 그래프를 그리기 위한 논리적인 x와 y의 최소, 최대값을 저장하기 위한 객체이다. 안정성을 위해 const로 선언하였다.
        const double
            xmin = -500000, xmax = 30000000,
            ymin = -100000, ymax = 2000000;

        // 그래프를 그리기 위한 Graphics 객체가 포함되어 있는 TCanvas 객체를 전역으로 선언하였다.
        TCanvas canvas;

        /* 클라이언트의 작업이 끝났을 때 타이머에 의해 무한히 다시 작업을 시작하지 않게 하기 위한 power 플래그와
           두 서버 중 하나가 완료되지 않았는데, 자료를 병합하려하는 시도를 하지 않게 하기 위한 각 서버의 작업 완료 플래그 calculate이다.*/
        private bool
            power = true,
            calculate1 = false,
            calculate2 = false;

        /* 각 수신된 정보를 임시로 담을 수 있는 버퍼이다. 함수를 오가며 작동하여야하기 때문에 전역변수로 설정하였다.
           string 객체의 경우 보통 + 연산자 오버로딩을 이용하여 객체의 크기를 늘려가는데, 이 때마다 새로운 객체를 만들어 할당하는 방식이기 때문에
           매우 비효율적인 코드가 되고, 통신 특성상 잦은 사이즈 변경과 고정된 횟수만큼 작업하는 것이 아니기 때문에 미리 큰 공간을 확보하고 바로
           집어넣는 StringBuilder 객체를 사용하였다. 쓰레드 안정성을 위해 StringBuffer 객체를 사용하면 더 좋지만 C#에는 존재하지 않는다.*/
        private StringBuilder
            Recv1_Buff = new StringBuilder(),
            Recv2_Buff = new StringBuilder();

        // 수신된 데이터를 parsing할 때 차원을 늘려가며 데이터를 분류하기 위해 2차원 문자열 객체를 미리 할당하였다.
        private string[][] pi1, pi2;

        // 각 IP 주소를 저장하기 위한 객체이다.
        private string
            myIP = TSocket.HostAddresses()[1].ToString(), // 내 컴퓨터의 IP, XP는 [0]
            sIP1 = TSocket.HostAddresses()[1].ToString(), // 서버1의 IP
            sIP2 = TSocket.HostAddresses()[1].ToString(); // 서버2의 IP

        private TClient client1, client2; // 두 서버와 TCP 통신을 하기 위한 객체이다.

        // 클라이언트의 각종 시간을 측정하기 위한 객체이다. 여러번 쓰이기 때문에 효율성을 위해 전역변수로 선언하였다.
        private DateTime startT = DateTime.MinValue;

        /* 받은 데이터를 압축해서 표현, 저장하기 위한 step을 저장하기 위한 변수이다.
         * 픽쳐박스의 가로가 800pixel이므로 30000000/800 = 37500으로 계산하여 스텝 값을 지정하였다. */
        const int step = 37500;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            col = new Color[4] { red, yellow, yellow, green };
            txt_IP1.Text = sIP1;
            txt_IP2.Text = sIP2;
            canvas = new TCanvas(pic_Graph, xmin, xmax, ymin, ymax);
            char x = Convert.ToChar(2);
            Console.WriteLine(x);
        }

        //
        private void btn_Capture_Click(object sender, EventArgs e)
        {
            Util.ScreenCapture(this, "Data" + scr++.ToString() + ".Png");
        }

        // 서버1의 IP 텍스트를 내 컴퓨터의 IP로 설정한다. (클라이언트에 반영은 안함)
        private void btn_me1_Click(object sender, EventArgs e)
        {
            txt_IP1.Text = myIP;
        }

        // 서버2의 IP 텍스트를 내 컴퓨터의 IP로 설정한다. (클라이언트에 반영은 안함)
        private void btn_me2_Click(object sender, EventArgs e)
        {
            txt_IP2.Text = myIP;
        }

        // 서버의 IP를 재설정한다. (연결을 끊으면 타이머에서 자동으로 재할당하기 때문에 연결만 끊으면 자동으로 작동함.)
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            sIP1 = txt_IP1.Text;
            sIP2 = txt_IP2.Text;
            client1.ClientClose();
            client2.ClientClose();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            // 클라이언트 객체가 아직 할당되지 않았다면 return 한다.
            if (client1 == null || client2 == null) return;

            // 두 서버가 모두 연결상태가 아니면 오류 메세지를 출력하고 return 한다.
            else if (client1.ClientStatus() != csConnStatus.Connected || client1.ClientStatus() != csConnStatus.Connected)
            {
                MessageBox.Show("Server is not connected!");
                return;
            }

            int // range를 혹시 모를 공백을 제거하고 int형으로 받아온다.
                Range1 = Convert.ToInt32(txt_Range1.Text.Trim()),
                Range2 = Convert.ToInt32(txt_Range2.Text.Trim()),
                Range3 = Convert.ToInt32(txt_Range3.Text.Trim());

            // Range의 범위가 유효하지 않다면 오류를 출력하고 return 한다.
            if (Range1 > Range2 || Range2 > Range3)
            {
                txt_Range1.Text = txt_Range2.Text = txt_Range3.Text = "Wrong Range";
                return;
            }

            // power 플래그를 트루로 만들어 계산이 끝났더라도 사용자가 임의로 재시작하는 경우 다시 작업을 수행한다.
            power = true;
            startT = DateTime.Now; // Total Elapsed Time을 측정하기 위해 여기서부터 측정 시작이다.

            string // 프로토콜에 맞춰 송신값을 작성한다.
                Send1 = TSocket.sSTX() + txt_Range1.Text.Trim() + ',' + txt_Range2.Text.Trim() + TSocket.sETX(),
                Send2 = TSocket.sSTX() + (Range2 + 1).ToString() + ',' + txt_Range3.Text.Trim() + TSocket.sETX();

            // 서버로 계산 범위를 송신하여 계산을 시작한다.
            client1.ClientSend(Send1);
            client2.ClientSend(Send2);

            // 사용자가 입력한 세 값을 두 개의 범위로 나누어 숫자 서식으로 표시한다.
            lbl_SRange1.Text = Range1.ToString("N0") + " ~ " + Range2.ToString("N0");
            lbl_SRange2.Text = (Range2 + 1).ToString("N0") + " ~ " + Range3.ToString("N0");

            // 서버 상태 라벨을 계산중으로 바꾸고 배경색을 노란색으로 바꾼다.
            lbl_Server1T.Text = lbl_Server2T.Text = "Calculating...";
            lbl_Server1T.BackColor = lbl_Server2T.BackColor = yellow;

            // 정보를 폼에 업데이트 한 뒤에 제타 계산을 시작한다.
            Application.DoEvents();
            ZETA(Range1, Range3);
        }

        // 그래프를 그리기를 시작하기 이전에 픽쳐박스에 사전작업을 한다.
        private void pic_init()
        {
            canvas.ClearDrawing(Color.White);
            Brush brs = Brushes.Black;

            // Axis의 화살표를 표시하기 위한 x, y 좌표값을 담은 double 객체
            double[]
                xtriangle1 = new double[] { xmax, xmax * 0.97, xmax * 0.97 },
                ytriangle1 = new double[] { 0, 30000, -30000 },
                xtriangle2 = new double[] { 0, 200000, -200000 },
                ytriangle2 = new double[] { ymax, ymax * 0.95, ymax * 0.95 };

            // y축과 평행한 grid를 만든다.
            for (int i = 0; i < ymax; i += (int)((ymax - ymin) * 0.1))
                canvas.DrawLine(Color.LightGray, xmin, i, xmax, i);

            // x축과 평행한 grid를 만든다.
            for (int i = 0; i < xmax; i += (int)((xmax - xmin) * 0.05))
                canvas.DrawLine(Color.LightGray, i, ymin, i, ymax);

            // x, y축을 만든다.
            canvas.DrawLine(Color.Black, xmin, 0, xmax, 0);
            canvas.DrawLine(Color.Black, 0, ymin, 0, ymax);

            // x, y축의 시작과 보이는 그래프상의 마지막 값을 적는다.
            canvas.DrawString("0", brs, 12, xmin, -ymin);
            canvas.DrawString("2", brs, 12, -xmin * 0.5, ymin * 0.1);
            canvas.DrawString(" y\n2e6", brs, 12, xmax * 0.01, ymax * 0.98);
            canvas.DrawString(" x\n3e7", brs, 12, xmax * 0.93, ymax * 0.05);

            // x 축과 y축의 끝에 화살표를 그린다.
            canvas.DrawFilledPolygon(Color.Black, 3, xtriangle1, ytriangle1);
            canvas.DrawFilledPolygon(Color.Black, 3, xtriangle2, ytriangle2);
        }

        //Calculate Riemann zeta function
        private void ZETA(int start, int end)
        {
            pic_init(); // 바로 위의 함수를 호출하여 그래프를 초기화한다.

            if (save) // 저장을 위한 블록이다.
            {
                sw = new StreamWriter(deskAddr + "\\19110015_최호승_ZETA.txt");
                sw.WriteLine("       x       :     ζ(x)");
                // 첫 번째 데이터는 저장되지 않기 때문에 따로 저장한다.
                sw.WriteLine("{0, 10:D}  :  {1, -12:F2}", start, start / Math.Log(start));
            }

            int i;
            double x1, x2, y1, y2;
            for (i = start; i + step <= end; i += step) // 스텝만큼 뛰어 넘으며 그래프에 그린다.
            {
                // [i, i+1] 두 점을 선으로 이어 그래프를 그린다.
                x1 = i;
                y1 = x1 / Math.Log(x1);
                x2 = i + step;
                y2 = x2 / Math.Log(x2);
                canvas.DrawLine(Color.Red, x1, y1, x2, y2);
                if (save) sw.WriteLine("{0, 10:F0}  :  {1, -12:F2}", x2, y2); // 저장을 위한 코드이다.
            }
            // 마지막 end값은 그려지지 않지만 전체 크기에 비해 미미한 점이기 때문에 일부러 생략한다.

            // 그려진 제타 곡선 옆에 라벨을 적어준다.
            canvas.DrawString("ζ(x)", Brushes.Red, 12, xmax * 0.8, ymax * 0.7);

            // 마지막 end값이 그려지지 않았다면 파일에도 end값이 들어가지 않았기 때문에 따로 저장해주고, stream을 닫는다.
            if (save)
            {
                if (i - step != end) sw.WriteLine("{0, 10:D}  :  {1, -12:F2}", end, end / Math.Log(end));
                sw.Close();
            }
        }

        // 서버1의 수신 타이머이다.
        private void tim_GetRecMsg1_Tick(object sender, EventArgs e)
        {
            // 클라이언트 객체가 할당되지 않았거나 이미 수신완료 플래그가 true라면 실행하지 않는다.
            if (client1 == null || calculate1) return;

            // 서버에서 데이터를 받아와 임시변수 st에 저장한다.
            string st = client1.GetRcvMsg();

            // 서버에서 유효한 값을 받아왔다면 데이터 가공을 시작한다.
            if (st.Length > 0)
            {
                // 버퍼값에 임시 데이터를 추가한다.
                Recv1_Buff.Append(st);

                // 처음 받아온 데이터가 STX로 시작하는 유효한 데이터인지 검증한다.
                bool isSTX = Recv1_Buff.ToString().StartsWith(TSocket.sSTX());

                // 받아온 데이터가 마지막 데이터라는 의미로 끝이 ETX로 끝나는지 검증한다.
                bool isETX = st.EndsWith(TSocket.sETX());

                // 만약 power가 false거나 유효한 데이터가 아니라고 판단되면 버퍼를 비워버린다.
                if (!isSTX || !power) Recv1_Buff.Clear();

                // 처음과 끝이 프로토콜에 맞는 데이터가 도착하면
                else if (isSTX && isETX)
                {
                    // 해쉬 테이블을 사용한 암호화 알고리즘으로 CheckSum을 구현하여 16바이트의 오류 검증 데이터로 만든다.
                    string CS = lbl_CS1.Text = Util.CheckSum(Recv1_Buff.ToString().Substring(0, Recv1_Buff.Length - 33));

                    // 받은 데이터로 계산한 체크섬이 서버에서 보내온 체크섬과 다르다면 버퍼를 지워버리고 리턴한다.
                    if (CS != Recv1_Buff.ToString().Substring(Recv1_Buff.Length - 33, 32))
                    {
                        Recv1_Buff.Clear();
                        return;
                    }
                    // 서버1의 상태 라벨을 수신중으로 바꾸고 폼에 업데이트한다.
                    lbl_Server1T.Text = "Recieving...";
                    lbl_Server1T.BackColor = yellow;
                    Application.DoEvents();

                    // 시작과 종결 값을 제거하여 유의미한 데이터만 남긴다.
                    st = Recv1_Buff.ToString().Substring(1, Recv1_Buff.Length - 2);

                    /* 스트링을 콤마 단위로 (x : π(x))를 분리하여 스트링 배열로 만든다.
                     * string[] {"1:33,2:44"} => {"1:33", "2:44"} */
                    string[] temp = st.Split(',');

                    /* 프로토콜상 마지막의 ETX 바로 앞 데이터는 시간과 CheckSum 정보이기 때문에 따로 추출한다.
                     * 시간과 checksum이 섞여있기 때문에 프로토콜 상 소수점 두 자리까지 시간 데이터를 전송하므로
                     * 소수점을 기준으로 소수점 두 자리 뒤의 위치까지만 추출하여 시간을 출력한다 */
                    string time = temp[temp.Length - 1];
                    lbl_Etime1.Text = time.Substring(0, time.IndexOf('.') + 3) + " sec";

                    /* (x: π(x))로 분리되어 있는 스트링 배열을 x와 π(x)로 한번 더 분리하여 2차원 배열로 만든다.
                     * string[][] {{"1", "33"}, {"2", "44"}} */
                    pi1 = Array.ConvertAll<string, string[]>(temp, s => s.Split(':'));

                    // 라벨을 완료로 업데이트 한다.
                    lbl_Server1T.Text = "Complete";
                    lbl_Server1T.BackColor = green;

                    // 서버1의 데이터 수신 및 가공이 끝났음을 알리는 플래그를 true로 만든다
                    calculate1 = true;
                    Recv1_Buff.Clear();
                }
            }
        }

        // 바로 위의tim_GetRecMsg1_Tick 함수와 내용이 동일하기 때문에 설명을 생략한다.
        private void tim_GetRecMsg2_Tick(object sender, EventArgs e)
        {
            if (client2 == null || calculate2) return;
            string st = client2.GetRcvMsg();
            if (st.Length > 0)
            {
                Recv2_Buff.Append(st);
                bool isSTX = Recv2_Buff.ToString().StartsWith(TSocket.sSTX());
                bool isETX = st.EndsWith(TSocket.sETX());
                if (!isSTX || !power) Recv2_Buff.Clear();
                else if (isSTX && isETX)
                {
                    string CS = lbl_CS2.Text = Util.CheckSum(Recv2_Buff.ToString().Substring(0, Recv2_Buff.Length - 33));
                    if (CS != Recv2_Buff.ToString().Substring(Recv2_Buff.Length - 33, 32))
                    {
                        Recv2_Buff.Clear();
                        return;
                    }
                    lbl_Server2T.Text = "Recieving...";
                    lbl_Server2T.BackColor = yellow;
                    Application.DoEvents();

                    st = Recv2_Buff.ToString().Substring(1, Recv2_Buff.Length - 2);

                    string[] temp = st.Split(',');

                    string time = temp[temp.Length - 1];
                    lbl_Etime2.Text = time.Substring(0, time.IndexOf('.') + 3) + " sec";

                    pi2 = Array.ConvertAll(temp, s => s.Split(':'));
                    lbl_Server2T.Text = "Complete";
                    lbl_Server2T.BackColor = green;

                    calculate2 = true;
                    Recv2_Buff.Clear();
                }
            }
        }

        // 주기적으로 통신 상태를 업데이트하는 타이머이다.
        private void tim_ComStatus_Tick(object sender, EventArgs e)
        {
            /* startT 함수가 Start버튼을 누르지 않아 MinValue 값으로 초기화되어 있다면 시간을 업데이트하지 않는다.
             * Start 하였다면, 소수점 2번째 자리까지 경과 시간을 업데이트한다. */
            if (startT != DateTime.MinValue) lbl_Etime4.Text = Util.Tsec(startT).ToString("F2") + " sec";

            // 클라이언트 객체가 할당되지 않았다면 객체를 할당하고 그래프를 초기화한다.
            if (client1 == null)
            {
                client1 = new TClient();
                pic_init();
            }

            // 클라이언트 객체가 null이 아니라면 Status 라벨의 내용과 바탕색을 업데이트 한다.
            else if (client1 != null)
            {
                // CsConnStatus 반환 인덱스 값을 int로 바꾸어 Color 객체 배열의 인덱스로 사용하여 색 변경.
                lbl_Server1.BackColor = col[Convert.ToInt32(client1.ClientStatus())];
                lbl_Server1.Text = client1.ClientStatus().ToString();
            }

            // 통신이 닫혀있는 상태라면
            if (client1.ClientStatus() == csConnStatus.Closed)
            {
                /* 연결이 끊어졌다면 자동으로 재접속한다.
                 * SetIP 버튼을 눌렀을 때, 제대로 된 IP가 아니라면 경고메세지를 한 번 출력한다. */
                try
                {
                    // '.'이 세 개가 있는 string 값이 아니라면 예외를 발생시킨다.
                    if (sIP1.Length - sIP1.Replace(".", "").Length != 3)
                    {
                        throw new ArgumentException("e");
                    }
                    client1.ClientBeginConnect(sIP1, 6060, myIP);
                }
                catch
                {
                    lbl_Server1.Text = "Wrong IP Address";
                }
            }

            // 이하 위의 client1에 대한 내용과 동일하다.
            if (client2 == null) client2 = new TClient();
            else if (client2 != null)
            {
                lbl_Server2.BackColor = col[Convert.ToInt32(client2.ClientStatus())];
                lbl_Server2.Text = client2.ClientStatus().ToString();
            }

            if (client2.ClientStatus() == csConnStatus.Closed)
            {
                try
                {
                    client2.ClientBeginConnect(sIP2, 7070, myIP);
                }
                catch
                {
                    lbl_Server2.Text = "Wrong IP Address";
                }
            }

            // 서버1과 서버2의 데이터 송,수신 및 가공이 끝난 상태라면 그래프를 그린다.
            if (calculate1 && calculate2 && power)
            {
                drawPi();
            }
        }

        // Pi 데이터 값을 그래프에 그린다.
        private void drawPi()
        {
            // string 객체를 double 객체로 바꾸기 위한 사전 객체 할당이다.
            double[][] d_pi1 = new double[pi1.Length - 1][];
            double[][] d_pi2 = new double[pi2.Length - 1][];

            // Array.Converall 함수를 이용해 각 배열의 원소들을 모두 double형으로 Convert한다.
            for (int i = 0; i < pi1.Length - 1; i++)
                d_pi1[i] = Array.ConvertAll(pi1[i], double.Parse);
            for (int i = 0; i < pi2.Length - 1; i++)
                d_pi2[i] = Array.ConvertAll(pi2[i], double.Parse);


            // 저장을 위한 블록이다.
            if (save)
            {
                sw = new StreamWriter(deskAddr + "\\19110015_최호승_PI.txt");
                sw.WriteLine("      x     :      π(x)");
                // 첫번째 데이터는 for문 안에서 저장되지 않기 때문에 따로 저장한다.
                sw.WriteLine("{0, 12:F0}  :  {1, -12:F0}", d_pi1[0][0], d_pi1[0][1]);
            }


            // [i, i+1]의 데이터로 각 좌표를 만든 다음 직선을 하나씩 그린다.
            double x1, y1, x2, y2;
            for (int i = 0; i < d_pi1.Length - 1; i++)
            {
                canvas.DrawLine(Color.Blue, d_pi1[i][0], d_pi1[i][1], d_pi1[i + 1][0], d_pi1[i + 1][1]);
                if (save) sw.WriteLine("{0, 12:F0}  :  {1, -12:F0}", d_pi1[i + 1][0], d_pi1[i + 1][1]);
            }

            // 위와 마찬가지로 첫 번째 데이터는 저장되지 않기 대문에 따로 저장한다.
            if (save) sw.WriteLine("{0, 12:F0}  :  {1, -12:F0}", d_pi2[0][0], d_pi2[0][1] + d_pi1[d_pi1.Length - 1][1]);


            /*두 번째 서버 데이터는 자신의 범위 안의 소수 개수만 보내주었기 때문에 첫번째 서버의 마지막 데이터를 모두 더 해줘야
             * 제대로 된 y값이 나오게 되므로 y에 해당하는 값에는 모두 첫번째 서버의 마지막 데이터를 더해준다. */
            for (int i = 0; i < d_pi2.Length - 1; i++)
            {
                x1 = d_pi2[i][0];
                y1 = d_pi2[i][1] + d_pi1[d_pi1.Length - 1][1];
                x2 = d_pi2[i + 1][0];
                y2 = d_pi2[i + 1][1] + d_pi1[d_pi1.Length - 1][1];
                canvas.DrawLine(Color.Blue, x1, y1, x2, y2);
                if (save) sw.WriteLine("{0, 12:F0}  :  {1, -12:F0}", d_pi2[i + 1][0], d_pi2[i + 1][1] + d_pi1[d_pi1.Length - 1][1]);
            }

            // 그려진 파이 곡선 위에 식별을 위한 라벨을 적고, 파일 스트림을 닫는다.
            canvas.DrawString("π(x)", Brushes.Blue, 12, xmax * 0.75, ymax * 0.8);
            if (save) sw.Close();

            // 버튼 클릭부터 지금까지 실행된 시간을 계산하여 출력하고, power를 false로 만들어 멋대로 작동하지 않게 한다.
            lbl_Etime3.Text = Util.Tsec(startT).ToString("F2") + " sec";
            calculate1 = calculate2 = power = false;
            SystemSounds.Beep.Play();
        }

    }
}
