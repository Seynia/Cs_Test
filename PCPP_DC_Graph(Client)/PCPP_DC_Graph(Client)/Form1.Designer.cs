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
            this.lbl_IP2 = new System.Windows.Forms.Label();
            this.lbl_IP1 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Graph)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(227, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 460);
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
            this.lbl_Server1.Location = new System.Drawing.Point(297, 431);
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
            this.lbl_Server2.Location = new System.Drawing.Point(297, 460);
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
            this.lbl_Server2T.Location = new System.Drawing.Point(543, 460);
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
            this.lbl_Server1T.Location = new System.Drawing.Point(543, 429);
            this.lbl_Server1T.Name = "lbl_Server1T";
            this.lbl_Server1T.Size = new System.Drawing.Size(66, 14);
            this.lbl_Server1T.TabIndex = 7;
            this.lbl_Server1T.Text = "Not Ready";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Server2 transmit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server1 transmit";
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
            // lbl_IP2
            // 
            this.lbl_IP2.AutoSize = true;
            this.lbl_IP2.Location = new System.Drawing.Point(10, 460);
            this.lbl_IP2.Name = "lbl_IP2";
            this.lbl_IP2.Size = new System.Drawing.Size(86, 12);
            this.lbl_IP2.TabIndex = 9;
            this.lbl_IP2.Text = "Server2 :: IPv4";
            // 
            // lbl_IP1
            // 
            this.lbl_IP1.AutoSize = true;
            this.lbl_IP1.Location = new System.Drawing.Point(10, 431);
            this.lbl_IP1.Name = "lbl_IP1";
            this.lbl_IP1.Size = new System.Drawing.Size(86, 12);
            this.lbl_IP1.TabIndex = 10;
            this.lbl_IP1.Text = "Server1 :: IPv4";
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("함초롬돋움", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Start.Location = new System.Drawing.Point(639, 431);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(173, 41);
            this.btn_Start.TabIndex = 11;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(826, 683);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_IP1);
            this.Controls.Add(this.lbl_IP2);
            this.Controls.Add(this.lbl_Server2T);
            this.Controls.Add(this.lbl_Server1T);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Server2);
            this.Controls.Add(this.lbl_Server1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_Graph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Graph)).EndInit();
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
        private System.Windows.Forms.Label lbl_IP2;
        private System.Windows.Forms.Label lbl_IP1;
        private System.Windows.Forms.Button btn_Start;
    }
}

