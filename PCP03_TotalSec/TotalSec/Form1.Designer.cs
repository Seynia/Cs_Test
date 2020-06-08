namespace TotalSec
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
            this.txt_totalSec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hour = new System.Windows.Forms.TextBox();
            this.txt_minute = new System.Windows.Forms.TextBox();
            this.txt_second = new System.Windows.Forms.TextBox();
            this.btn_toSec = new System.Windows.Forms.Button();
            this.btn_toHour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_totalSec
            // 
            this.txt_totalSec.Location = new System.Drawing.Point(85, 67);
            this.txt_totalSec.Name = "txt_totalSec";
            this.txt_totalSec.Size = new System.Drawing.Size(100, 21);
            this.txt_totalSec.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Sec: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Minute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Second";
            // 
            // txt_hour
            // 
            this.txt_hour.Location = new System.Drawing.Point(412, 36);
            this.txt_hour.Name = "txt_hour";
            this.txt_hour.Size = new System.Drawing.Size(100, 21);
            this.txt_hour.TabIndex = 5;
            // 
            // txt_minute
            // 
            this.txt_minute.Location = new System.Drawing.Point(412, 69);
            this.txt_minute.Name = "txt_minute";
            this.txt_minute.Size = new System.Drawing.Size(100, 21);
            this.txt_minute.TabIndex = 6;
            // 
            // txt_second
            // 
            this.txt_second.Location = new System.Drawing.Point(412, 110);
            this.txt_second.Name = "txt_second";
            this.txt_second.Size = new System.Drawing.Size(100, 21);
            this.txt_second.TabIndex = 7;
            // 
            // btn_toSec
            // 
            this.btn_toSec.Location = new System.Drawing.Point(214, 36);
            this.btn_toSec.Name = "btn_toSec";
            this.btn_toSec.Size = new System.Drawing.Size(75, 43);
            this.btn_toSec.TabIndex = 8;
            this.btn_toSec.Text = "<<";
            this.btn_toSec.UseVisualStyleBackColor = true;
            this.btn_toSec.Click += new System.EventHandler(this.btn_toSec_Click);
            // 
            // btn_toHour
            // 
            this.btn_toHour.Location = new System.Drawing.Point(214, 94);
            this.btn_toHour.Name = "btn_toHour";
            this.btn_toHour.Size = new System.Drawing.Size(75, 43);
            this.btn_toHour.TabIndex = 9;
            this.btn_toHour.Text = ">>";
            this.btn_toHour.UseVisualStyleBackColor = true;
            this.btn_toHour.Click += new System.EventHandler(this.btn_toHour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 191);
            this.Controls.Add(this.btn_toHour);
            this.Controls.Add(this.btn_toSec);
            this.Controls.Add(this.txt_second);
            this.Controls.Add(this.txt_minute);
            this.Controls.Add(this.txt_hour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_totalSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_totalSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hour;
        private System.Windows.Forms.TextBox txt_minute;
        private System.Windows.Forms.TextBox txt_second;
        private System.Windows.Forms.Button btn_toSec;
        private System.Windows.Forms.Button btn_toHour;
    }
}

