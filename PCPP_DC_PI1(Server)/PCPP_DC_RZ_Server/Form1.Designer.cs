namespace PCPP_DC_RZ_Server
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
            this.tim_ComStatus = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_CommReady = new System.Windows.Forms.Label();
            this.lbl_complete = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Trans = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Cal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cnt = new System.Windows.Forms.Label();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.tim_GetRevMsg = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Range = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.btn_IP = new System.Windows.Forms.Button();
            this.btn_me = new System.Windows.Forms.Button();
            this.lbl_CS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tim_ComStatus
            // 
            this.tim_ComStatus.Enabled = true;
            this.tim_ComStatus.Tick += new System.EventHandler(this.tim_ConStatus_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculation elapsed time: ";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(181, 315);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(11, 12);
            this.lbl_Time.TabIndex = 1;
            this.lbl_Time.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calculate π(x)";
            // 
            // lbl_CommReady
            // 
            this.lbl_CommReady.AutoSize = true;
            this.lbl_CommReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_CommReady.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CommReady.Location = new System.Drawing.Point(209, 153);
            this.lbl_CommReady.Name = "lbl_CommReady";
            this.lbl_CommReady.Size = new System.Drawing.Size(47, 14);
            this.lbl_CommReady.TabIndex = 3;
            this.lbl_CommReady.Text = "Closed";
            this.lbl_CommReady.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_complete
            // 
            this.lbl_complete.AutoSize = true;
            this.lbl_complete.Location = new System.Drawing.Point(111, 247);
            this.lbl_complete.Name = "lbl_complete";
            this.lbl_complete.Size = new System.Drawing.Size(50, 12);
            this.lbl_complete.TabIndex = 4;
            this.lbl_complete.Text = "transmit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Communication";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Trans
            // 
            this.lbl_Trans.AutoSize = true;
            this.lbl_Trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_Trans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Trans.Location = new System.Drawing.Point(209, 245);
            this.lbl_Trans.Name = "lbl_Trans";
            this.lbl_Trans.Size = new System.Drawing.Size(66, 14);
            this.lbl_Trans.TabIndex = 6;
            this.lbl_Trans.Text = "Not Ready";
            this.lbl_Trans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "Calculate";
            // 
            // lbl_Cal
            // 
            this.lbl_Cal.AutoSize = true;
            this.lbl_Cal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_Cal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Cal.Location = new System.Drawing.Point(209, 199);
            this.lbl_Cal.Name = "lbl_Cal";
            this.lbl_Cal.Size = new System.Drawing.Size(66, 14);
            this.lbl_Cal.TabIndex = 9;
            this.lbl_Cal.Text = "Not Ready";
            this.lbl_Cal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Amount of prime numbers:";
            // 
            // lbl_cnt
            // 
            this.lbl_cnt.AutoSize = true;
            this.lbl_cnt.Location = new System.Drawing.Point(181, 293);
            this.lbl_cnt.Name = "lbl_cnt";
            this.lbl_cnt.Size = new System.Drawing.Size(11, 12);
            this.lbl_cnt.TabIndex = 12;
            this.lbl_cnt.Text = "-";
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Location = new System.Drawing.Point(84, 60);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(56, 12);
            this.lbl_IP.TabIndex = 13;
            this.lbl_IP.Text = "Client IP:";
            this.lbl_IP.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tim_GetRevMsg
            // 
            this.tim_GetRevMsg.Enabled = true;
            this.tim_GetRevMsg.Interval = 10;
            this.tim_GetRevMsg.Tick += new System.EventHandler(this.tim_GetRevMsg_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "Range";
            // 
            // lbl_Range
            // 
            this.lbl_Range.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Range.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Range.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_Range.Location = new System.Drawing.Point(176, 104);
            this.lbl_Range.Name = "lbl_Range";
            this.lbl_Range.Size = new System.Drawing.Size(123, 15);
            this.lbl_Range.TabIndex = 17;
            this.lbl_Range.Text = "-";
            this.lbl_Range.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "PORT: 6060";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(167, 57);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(123, 21);
            this.txt_IP.TabIndex = 19;
            this.txt_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_IP
            // 
            this.btn_IP.Location = new System.Drawing.Point(340, 55);
            this.btn_IP.Name = "btn_IP";
            this.btn_IP.Size = new System.Drawing.Size(37, 23);
            this.btn_IP.TabIndex = 20;
            this.btn_IP.Text = "OK";
            this.btn_IP.UseVisualStyleBackColor = true;
            this.btn_IP.Click += new System.EventHandler(this.btn_IP_Click);
            // 
            // btn_me
            // 
            this.btn_me.Location = new System.Drawing.Point(297, 55);
            this.btn_me.Name = "btn_me";
            this.btn_me.Size = new System.Drawing.Size(37, 23);
            this.btn_me.TabIndex = 21;
            this.btn_me.Text = "Me";
            this.btn_me.UseVisualStyleBackColor = true;
            this.btn_me.Click += new System.EventHandler(this.btn_me_Click);
            // 
            // lbl_CS
            // 
            this.lbl_CS.AutoSize = true;
            this.lbl_CS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CS.Location = new System.Drawing.Point(132, 338);
            this.lbl_CS.Name = "lbl_CS";
            this.lbl_CS.Size = new System.Drawing.Size(231, 14);
            this.lbl_CS.TabIndex = 23;
            this.lbl_CS.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "CheckSum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lbl_CS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_me);
            this.Controls.Add(this.btn_IP);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Range);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.lbl_cnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Cal);
            this.Controls.Add(this.lbl_Trans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_complete);
            this.Controls.Add(this.lbl_CommReady);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PI 1st";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tim_ComStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_CommReady;
        private System.Windows.Forms.Label lbl_complete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Trans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Cal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cnt;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Timer tim_GetRevMsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Range;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Button btn_IP;
        private System.Windows.Forms.Button btn_me;
        private System.Windows.Forms.Label lbl_CS;
        private System.Windows.Forms.Label label9;
    }
}

