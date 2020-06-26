namespace PCPP_DC_Graph_Client_
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pic_Graph = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Server1 = new System.Windows.Forms.Label();
            this.lbl_Server2 = new System.Windows.Forms.Label();
            this.lbl_Server2T = new System.Windows.Forms.Label();
            this.lbl_Server1T = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tim_ComStatus = new System.Windows.Forms.Timer(this.components);
            this.tim_GetRecMsg1 = new System.Windows.Forms.Timer(this.components);
            this.tim_GetRecMsg2 = new System.Windows.Forms.Timer(this.components);
            this.btn_Start = new System.Windows.Forms.Button();
            this.txt_Range1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Range2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Etime2 = new System.Windows.Forms.Label();
            this.lbl_Etime1 = new System.Windows.Forms.Label();
            this.txt_Range3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Etime3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_Etime4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_SRange1 = new System.Windows.Forms.Label();
            this.lbl_SRange2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_IP2 = new System.Windows.Forms.TextBox();
            this.txt_IP1 = new System.Windows.Forms.TextBox();
            this.btn_me1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_me2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_CS1 = new System.Windows.Forms.Label();
            this.lbl_CS2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_Capture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Graph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Graph
            // 
            this.pic_Graph.BackColor = System.Drawing.Color.White;
            this.pic_Graph.Location = new System.Drawing.Point(12, 12);
            this.pic_Graph.Name = "pic_Graph";
            this.pic_Graph.Size = new System.Drawing.Size(800, 400);
            this.pic_Graph.TabIndex = 0;
            this.pic_Graph.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server2";
            // 
            // lbl_Server1
            // 
            this.lbl_Server1.AutoSize = true;
            this.lbl_Server1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_Server1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Server1.Location = new System.Drawing.Point(68, 16);
            this.lbl_Server1.Name = "lbl_Server1";
            this.lbl_Server1.Size = new System.Drawing.Size(47, 14);
            this.lbl_Server1.TabIndex = 3;
            this.lbl_Server1.Text = "Closed";
            // 
            // lbl_Server2
            // 
            this.lbl_Server2.AutoSize = true;
            this.lbl_Server2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_Server2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Server2.Location = new System.Drawing.Point(68, 45);
            this.lbl_Server2.Name = "lbl_Server2";
            this.lbl_Server2.Size = new System.Drawing.Size(47, 14);
            this.lbl_Server2.TabIndex = 4;
            this.lbl_Server2.Text = "Closed";
            // 
            // lbl_Server2T
            // 
            this.lbl_Server2T.AutoSize = true;
            this.lbl_Server2T.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_Server2T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Server2T.Location = new System.Drawing.Point(69, 46);
            this.lbl_Server2T.Name = "lbl_Server2T";
            this.lbl_Server2T.Size = new System.Drawing.Size(66, 14);
            this.lbl_Server2T.TabIndex = 8;
            this.lbl_Server2T.Text = "Not Ready";
            // 
            // lbl_Server1T
            // 
            this.lbl_Server1T.AutoSize = true;
            this.lbl_Server1T.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_Server1T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Server1T.Location = new System.Drawing.Point(69, 17);
            this.lbl_Server1T.Name = "lbl_Server1T";
            this.lbl_Server1T.Size = new System.Drawing.Size(66, 14);
            this.lbl_Server1T.TabIndex = 7;
            this.lbl_Server1T.Text = "Not Ready";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Server2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server1";
            // 
            // tim_ComStatus
            // 
            this.tim_ComStatus.Enabled = true;
            this.tim_ComStatus.Tick += new System.EventHandler(this.tim_ComStatus_Tick);
            // 
            // tim_GetRecMsg1
            // 
            this.tim_GetRecMsg1.Enabled = true;
            this.tim_GetRecMsg1.Interval = 10;
            this.tim_GetRecMsg1.Tick += new System.EventHandler(this.tim_GetRecMsg1_Tick);
            // 
            // tim_GetRecMsg2
            // 
            this.tim_GetRecMsg2.Enabled = true;
            this.tim_GetRecMsg2.Interval = 10;
            this.tim_GetRecMsg2.Tick += new System.EventHandler(this.tim_GetRecMsg2_Tick);
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("함초롬돋움", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Start.Location = new System.Drawing.Point(711, 517);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(103, 59);
            this.btn_Start.TabIndex = 11;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // txt_Range1
            // 
            this.txt_Range1.Location = new System.Drawing.Point(78, 14);
            this.txt_Range1.Name = "txt_Range1";
            this.txt_Range1.Size = new System.Drawing.Size(80, 21);
            this.txt_Range1.TabIndex = 12;
            this.txt_Range1.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Start Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mid Value";
            // 
            // txt_Range2
            // 
            this.txt_Range2.Location = new System.Drawing.Point(78, 41);
            this.txt_Range2.Name = "txt_Range2";
            this.txt_Range2.Size = new System.Drawing.Size(80, 21);
            this.txt_Range2.TabIndex = 14;
            this.txt_Range2.Text = "19200000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "Server2 elapsed time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "Server1 elapsed time:";
            // 
            // lbl_Etime2
            // 
            this.lbl_Etime2.AutoSize = true;
            this.lbl_Etime2.Location = new System.Drawing.Point(141, 44);
            this.lbl_Etime2.Name = "lbl_Etime2";
            this.lbl_Etime2.Size = new System.Drawing.Size(11, 12);
            this.lbl_Etime2.TabIndex = 19;
            this.lbl_Etime2.Text = "-";
            // 
            // lbl_Etime1
            // 
            this.lbl_Etime1.AutoSize = true;
            this.lbl_Etime1.Location = new System.Drawing.Point(141, 17);
            this.lbl_Etime1.Name = "lbl_Etime1";
            this.lbl_Etime1.Size = new System.Drawing.Size(11, 12);
            this.lbl_Etime1.TabIndex = 18;
            this.lbl_Etime1.Text = "-";
            // 
            // txt_Range3
            // 
            this.txt_Range3.Location = new System.Drawing.Point(78, 68);
            this.txt_Range3.Name = "txt_Range3";
            this.txt_Range3.Size = new System.Drawing.Size(80, 21);
            this.txt_Range3.TabIndex = 20;
            this.txt_Range3.Text = "30000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "Final Value";
            // 
            // lbl_Etime3
            // 
            this.lbl_Etime3.AutoSize = true;
            this.lbl_Etime3.Location = new System.Drawing.Point(141, 69);
            this.lbl_Etime3.Name = "lbl_Etime3";
            this.lbl_Etime3.Size = new System.Drawing.Size(11, 12);
            this.lbl_Etime3.TabIndex = 24;
            this.lbl_Etime3.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "Total elapsed time:";
            // 
            // lbl_Etime4
            // 
            this.lbl_Etime4.AutoSize = true;
            this.lbl_Etime4.Location = new System.Drawing.Point(756, 584);
            this.lbl_Etime4.Name = "lbl_Etime4";
            this.lbl_Etime4.Size = new System.Drawing.Size(11, 12);
            this.lbl_Etime4.TabIndex = 26;
            this.lbl_Etime4.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(631, 584);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "Client elapsed time:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "Server1 Range";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "Server2 Range";
            // 
            // lbl_SRange1
            // 
            this.lbl_SRange1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SRange1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SRange1.Location = new System.Drawing.Point(97, 28);
            this.lbl_SRange1.Name = "lbl_SRange1";
            this.lbl_SRange1.Size = new System.Drawing.Size(136, 14);
            this.lbl_SRange1.TabIndex = 29;
            this.lbl_SRange1.Text = "2~18000000";
            // 
            // lbl_SRange2
            // 
            this.lbl_SRange2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SRange2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SRange2.Location = new System.Drawing.Point(97, 64);
            this.lbl_SRange2.Name = "lbl_SRange2";
            this.lbl_SRange2.Size = new System.Drawing.Size(136, 14);
            this.lbl_SRange2.TabIndex = 30;
            this.lbl_SRange2.Text = "18000000~30000000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 12);
            this.label17.TabIndex = 34;
            this.label17.Text = "Server2 IP";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 12);
            this.label18.TabIndex = 33;
            this.label18.Text = "Server1 IP";
            // 
            // txt_IP2
            // 
            this.txt_IP2.Location = new System.Drawing.Point(74, 58);
            this.txt_IP2.Name = "txt_IP2";
            this.txt_IP2.Size = new System.Drawing.Size(123, 21);
            this.txt_IP2.TabIndex = 32;
            // 
            // txt_IP1
            // 
            this.txt_IP1.Location = new System.Drawing.Point(74, 27);
            this.txt_IP1.Name = "txt_IP1";
            this.txt_IP1.Size = new System.Drawing.Size(123, 21);
            this.txt_IP1.TabIndex = 31;
            // 
            // btn_me1
            // 
            this.btn_me1.Location = new System.Drawing.Point(200, 26);
            this.btn_me1.Name = "btn_me1";
            this.btn_me1.Size = new System.Drawing.Size(39, 23);
            this.btn_me1.TabIndex = 35;
            this.btn_me1.Text = "me";
            this.btn_me1.UseVisualStyleBackColor = true;
            this.btn_me1.Click += new System.EventHandler(this.btn_me1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Range1);
            this.groupBox1.Controls.Add(this.txt_Range2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Range3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 95);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Value Setting";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lbl_SRange1);
            this.groupBox2.Controls.Add(this.lbl_SRange2);
            this.groupBox2.Location = new System.Drawing.Point(187, 418);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 93);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculation Range Box";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_me2);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txt_IP1);
            this.groupBox3.Controls.Add(this.txt_IP2);
            this.groupBox3.Controls.Add(this.btn_me1);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(433, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 93);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server IP Setting";
            // 
            // btn_me2
            // 
            this.btn_me2.Location = new System.Drawing.Point(200, 57);
            this.btn_me2.Name = "btn_me2";
            this.btn_me2.Size = new System.Drawing.Size(39, 23);
            this.btn_me2.TabIndex = 36;
            this.btn_me2.Text = "me";
            this.btn_me2.UseVisualStyleBackColor = true;
            this.btn_me2.Click += new System.EventHandler(this.btn_me2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lbl_Server1);
            this.groupBox4.Controls.Add(this.lbl_Server2);
            this.groupBox4.Location = new System.Drawing.Point(20, 531);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 72);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Server Comm Status";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.lbl_Server1T);
            this.groupBox5.Controls.Add(this.lbl_Server2T);
            this.groupBox5.Location = new System.Drawing.Point(215, 531);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(158, 73);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Server Cal Status";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.lbl_Etime1);
            this.groupBox7.Controls.Add(this.lbl_Etime2);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.lbl_Etime3);
            this.groupBox7.Location = new System.Drawing.Point(381, 516);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(213, 87);
            this.groupBox7.TabIndex = 42;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Server Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 12);
            this.label15.TabIndex = 43;
            this.label15.Text = "Server1: 6060";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 12);
            this.label16.TabIndex = 44;
            this.label16.Text = "Server2: 7070";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(600, 517);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(105, 56);
            this.groupBox6.TabIndex = 41;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Port Number";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("함초롬돋움", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Connect.Location = new System.Drawing.Point(689, 420);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(123, 42);
            this.btn_Connect.TabIndex = 43;
            this.btn_Connect.Text = "Set IP";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lbl_CS1
            // 
            this.lbl_CS1.AutoSize = true;
            this.lbl_CS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CS1.Location = new System.Drawing.Point(159, 613);
            this.lbl_CS1.Name = "lbl_CS1";
            this.lbl_CS1.Size = new System.Drawing.Size(231, 14);
            this.lbl_CS1.TabIndex = 44;
            this.lbl_CS1.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            // 
            // lbl_CS2
            // 
            this.lbl_CS2.AutoSize = true;
            this.lbl_CS2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CS2.Location = new System.Drawing.Point(576, 613);
            this.lbl_CS2.Name = "lbl_CS2";
            this.lbl_CS2.Size = new System.Drawing.Size(231, 14);
            this.lbl_CS2.TabIndex = 45;
            this.lbl_CS2.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 614);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 12);
            this.label10.TabIndex = 46;
            this.label10.Text = "CheckSum of Server1: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(435, 614);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 12);
            this.label19.TabIndex = 47;
            this.label19.Text = "CheckSum of Server2: ";
            // 
            // btn_Capture
            // 
            this.btn_Capture.Font = new System.Drawing.Font("함초롬돋움", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Capture.Location = new System.Drawing.Point(689, 466);
            this.btn_Capture.Name = "btn_Capture";
            this.btn_Capture.Size = new System.Drawing.Size(123, 42);
            this.btn_Capture.TabIndex = 48;
            this.btn_Capture.Text = "Capture";
            this.btn_Capture.UseVisualStyleBackColor = true;
            this.btn_Capture.Click += new System.EventHandler(this.btn_Capture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(826, 635);
            this.Controls.Add(this.btn_Capture);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_CS2);
            this.Controls.Add(this.lbl_CS1);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Etime4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.pic_Graph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Graph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Server1;
        private System.Windows.Forms.Label lbl_Server2;
        private System.Windows.Forms.Label lbl_Server2T;
        private System.Windows.Forms.Label lbl_Server1T;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tim_ComStatus;
        private System.Windows.Forms.Timer tim_GetRecMsg1;
        private System.Windows.Forms.Timer tim_GetRecMsg2;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox txt_Range1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Range2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Etime2;
        private System.Windows.Forms.Label lbl_Etime1;
        private System.Windows.Forms.TextBox txt_Range3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Etime3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Etime4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_SRange1;
        private System.Windows.Forms.Label lbl_SRange2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_IP2;
        private System.Windows.Forms.TextBox txt_IP1;
        private System.Windows.Forms.Button btn_me1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_me2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_CS1;
        private System.Windows.Forms.Label lbl_CS2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_Capture;
    }
}

