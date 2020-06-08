namespace HW2_BouncingBall
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
            this.rbt_Slow = new System.Windows.Forms.RadioButton();
            this.rbt_Fast = new System.Windows.Forms.RadioButton();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // rbt_Slow
            // 
            this.rbt_Slow.AutoSize = true;
            this.rbt_Slow.Checked = true;
            this.rbt_Slow.Location = new System.Drawing.Point(398, 12);
            this.rbt_Slow.Name = "rbt_Slow";
            this.rbt_Slow.Size = new System.Drawing.Size(51, 16);
            this.rbt_Slow.TabIndex = 0;
            this.rbt_Slow.TabStop = true;
            this.rbt_Slow.Text = "Slow";
            this.rbt_Slow.UseVisualStyleBackColor = true;
            // 
            // rbt_Fast
            // 
            this.rbt_Fast.AutoSize = true;
            this.rbt_Fast.Location = new System.Drawing.Point(398, 44);
            this.rbt_Fast.Name = "rbt_Fast";
            this.rbt_Fast.Size = new System.Drawing.Size(47, 16);
            this.rbt_Fast.TabIndex = 1;
            this.rbt_Fast.TabStop = true;
            this.rbt_Fast.Text = "Fast";
            this.rbt_Fast.UseVisualStyleBackColor = true;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Blue;
            this.Ball.Location = new System.Drawing.Point(0, 0);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(15, 15);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 361);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.rbt_Fast);
            this.Controls.Add(this.rbt_Slow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_Slow;
        private System.Windows.Forms.RadioButton rbt_Fast;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer timer1;
    }
}

