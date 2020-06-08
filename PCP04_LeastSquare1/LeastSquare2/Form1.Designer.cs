namespace LeastSquare2
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
            this.pic_draw = new System.Windows.Forms.PictureBox();
            this.btn_draw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_draw)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_draw
            // 
            this.pic_draw.BackColor = System.Drawing.Color.White;
            this.pic_draw.Location = new System.Drawing.Point(12, 12);
            this.pic_draw.Name = "pic_draw";
            this.pic_draw.Size = new System.Drawing.Size(500, 500);
            this.pic_draw.TabIndex = 0;
            this.pic_draw.TabStop = false;
            // 
            // btn_draw
            // 
            this.btn_draw.Location = new System.Drawing.Point(518, 12);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(97, 56);
            this.btn_draw.TabIndex = 1;
            this.btn_draw.Text = "Draw";
            this.btn_draw.UseVisualStyleBackColor = true;
            this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 528);
            this.Controls.Add(this.btn_draw);
            this.Controls.Add(this.pic_draw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_draw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_draw;
        private System.Windows.Forms.Button btn_draw;
    }
}

