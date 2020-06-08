namespace Day_of_Week
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
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_dow = new System.Windows.Forms.Button();
            this.btn_cly = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_leapYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(109, 44);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(100, 21);
            this.txt_year.TabIndex = 0;
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(109, 89);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(100, 21);
            this.txt_month.TabIndex = 1;
            // 
            // txt_day
            // 
            this.txt_day.Location = new System.Drawing.Point(109, 138);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(100, 21);
            this.txt_day.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Day";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(30, 214);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(110, 12);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "Date:        -    -    ";
            // 
            // btn_dow
            // 
            this.btn_dow.Location = new System.Drawing.Point(250, 44);
            this.btn_dow.Name = "btn_dow";
            this.btn_dow.Size = new System.Drawing.Size(113, 39);
            this.btn_dow.TabIndex = 7;
            this.btn_dow.Text = "Day of Week";
            this.btn_dow.UseVisualStyleBackColor = true;
            this.btn_dow.Click += new System.EventHandler(this.btn_dow_Click);
            // 
            // btn_cly
            // 
            this.btn_cly.Location = new System.Drawing.Point(250, 119);
            this.btn_cly.Name = "btn_cly";
            this.btn_cly.Size = new System.Drawing.Size(113, 40);
            this.btn_cly.TabIndex = 8;
            this.btn_cly.Text = "Check LeapYear";
            this.btn_cly.UseVisualStyleBackColor = true;
            this.btn_cly.Click += new System.EventHandler(this.btn_cly_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "결과:";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("굴림", 24F);
            this.lbl_result.Location = new System.Drawing.Point(442, 78);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(96, 32);
            this.lbl_result.TabIndex = 10;
            this.lbl_result.Text = "?요일";
            // 
            // lbl_leapYear
            // 
            this.lbl_leapYear.AutoSize = true;
            this.lbl_leapYear.Font = new System.Drawing.Font("굴림", 24F);
            this.lbl_leapYear.Location = new System.Drawing.Point(264, 194);
            this.lbl_leapYear.Name = "lbl_leapYear";
            this.lbl_leapYear.Size = new System.Drawing.Size(0, 32);
            this.lbl_leapYear.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 250);
            this.Controls.Add(this.lbl_leapYear);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cly);
            this.Controls.Add(this.btn_dow);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_day);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.txt_year);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_dow;
        private System.Windows.Forms.Button btn_cly;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_leapYear;
    }
}

