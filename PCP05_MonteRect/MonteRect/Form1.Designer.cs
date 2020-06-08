namespace MonteRect
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
            this.picArea = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_ratio = new System.Windows.Forms.Label();
            this.lbl_inPts = new System.Windows.Forms.Label();
            this.lbl_outPts = new System.Windows.Forms.Label();
            this.lbl_ratioMonte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).BeginInit();
            this.SuspendLayout();
            // 
            // picArea
            // 
            this.picArea.BackColor = System.Drawing.Color.White;
            this.picArea.Location = new System.Drawing.Point(12, 12);
            this.picArea.Name = "picArea";
            this.picArea.Size = new System.Drawing.Size(400, 350);
            this.picArea.TabIndex = 0;
            this.picArea.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(418, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(116, 50);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_ratio
            // 
            this.lbl_ratio.AutoSize = true;
            this.lbl_ratio.Location = new System.Drawing.Point(416, 92);
            this.lbl_ratio.Name = "lbl_ratio";
            this.lbl_ratio.Size = new System.Drawing.Size(38, 12);
            this.lbl_ratio.TabIndex = 2;
            this.lbl_ratio.Text = "label1";
            // 
            // lbl_inPts
            // 
            this.lbl_inPts.AutoSize = true;
            this.lbl_inPts.Location = new System.Drawing.Point(416, 116);
            this.lbl_inPts.Name = "lbl_inPts";
            this.lbl_inPts.Size = new System.Drawing.Size(38, 12);
            this.lbl_inPts.TabIndex = 3;
            this.lbl_inPts.Text = "label2";
            // 
            // lbl_outPts
            // 
            this.lbl_outPts.AutoSize = true;
            this.lbl_outPts.Location = new System.Drawing.Point(416, 140);
            this.lbl_outPts.Name = "lbl_outPts";
            this.lbl_outPts.Size = new System.Drawing.Size(38, 12);
            this.lbl_outPts.TabIndex = 4;
            this.lbl_outPts.Text = "label3";
            // 
            // lbl_ratioMonte
            // 
            this.lbl_ratioMonte.AutoSize = true;
            this.lbl_ratioMonte.Location = new System.Drawing.Point(416, 164);
            this.lbl_ratioMonte.Name = "lbl_ratioMonte";
            this.lbl_ratioMonte.Size = new System.Drawing.Size(38, 12);
            this.lbl_ratioMonte.TabIndex = 5;
            this.lbl_ratioMonte.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 385);
            this.Controls.Add(this.lbl_ratioMonte);
            this.Controls.Add(this.lbl_outPts);
            this.Controls.Add(this.lbl_inPts);
            this.Controls.Add(this.lbl_ratio);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.picArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picArea;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_ratio;
        private System.Windows.Forms.Label lbl_inPts;
        private System.Windows.Forms.Label lbl_outPts;
        private System.Windows.Forms.Label lbl_ratioMonte;
    }
}

