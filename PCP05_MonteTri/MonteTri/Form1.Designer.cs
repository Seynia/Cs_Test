namespace MonteTri
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cnt = new System.Windows.Forms.Label();
            this.btn_abort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).BeginInit();
            this.SuspendLayout();
            // 
            // picArea
            // 
            this.picArea.BackColor = System.Drawing.Color.White;
            this.picArea.Location = new System.Drawing.Point(12, 12);
            this.picArea.Name = "picArea";
            this.picArea.Size = new System.Drawing.Size(500, 500);
            this.picArea.TabIndex = 0;
            this.picArea.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(533, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(94, 47);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_ratio
            // 
            this.lbl_ratio.AutoSize = true;
            this.lbl_ratio.Location = new System.Drawing.Point(531, 99);
            this.lbl_ratio.Name = "lbl_ratio";
            this.lbl_ratio.Size = new System.Drawing.Size(80, 12);
            this.lbl_ratio.TabIndex = 2;
            this.lbl_ratio.Text = "Ratio of Real:";
            // 
            // lbl_inPts
            // 
            this.lbl_inPts.AutoSize = true;
            this.lbl_inPts.Location = new System.Drawing.Point(531, 149);
            this.lbl_inPts.Name = "lbl_inPts";
            this.lbl_inPts.Size = new System.Drawing.Size(100, 12);
            this.lbl_inPts.TabIndex = 3;
            this.lbl_inPts.Text = "In Points counts:";
            // 
            // lbl_outPts
            // 
            this.lbl_outPts.AutoSize = true;
            this.lbl_outPts.Location = new System.Drawing.Point(531, 199);
            this.lbl_outPts.Name = "lbl_outPts";
            this.lbl_outPts.Size = new System.Drawing.Size(109, 12);
            this.lbl_outPts.TabIndex = 4;
            this.lbl_outPts.Text = "Out Points counts:";
            // 
            // lbl_ratioMonte
            // 
            this.lbl_ratioMonte.AutoSize = true;
            this.lbl_ratioMonte.Location = new System.Drawing.Point(531, 249);
            this.lbl_ratioMonte.Name = "lbl_ratioMonte";
            this.lbl_ratioMonte.Size = new System.Drawing.Size(90, 12);
            this.lbl_ratioMonte.TabIndex = 5;
            this.lbl_ratioMonte.Text = "Ratio of Monte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "number of Points: ";
            // 
            // lbl_cnt
            // 
            this.lbl_cnt.AutoSize = true;
            this.lbl_cnt.Location = new System.Drawing.Point(140, 539);
            this.lbl_cnt.Name = "lbl_cnt";
            this.lbl_cnt.Size = new System.Drawing.Size(11, 12);
            this.lbl_cnt.TabIndex = 8;
            this.lbl_cnt.Text = "0";
            // 
            // btn_abort
            // 
            this.btn_abort.Location = new System.Drawing.Point(673, 12);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(94, 47);
            this.btn_abort.TabIndex = 9;
            this.btn_abort.Text = "Abort && Reset";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "19110015 최호승";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.lbl_cnt);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cnt;
        private System.Windows.Forms.Button btn_abort;
        private System.Windows.Forms.Label label1;
    }
}

