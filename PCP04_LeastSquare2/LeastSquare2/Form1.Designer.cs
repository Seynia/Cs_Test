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
            this.lbl_a0 = new System.Windows.Forms.Label();
            this.lbl_a1 = new System.Windows.Forms.Label();
            this.lbl_a2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_fx = new System.Windows.Forms.Label();
            this.lbl_St = new System.Windows.Forms.Label();
            this.lbl_Sr = new System.Windows.Forms.Label();
            this.lbl_R = new System.Windows.Forms.Label();
            this.lbl_R2 = new System.Windows.Forms.Label();
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
            this.btn_draw.Size = new System.Drawing.Size(159, 56);
            this.btn_draw.TabIndex = 1;
            this.btn_draw.Text = "Draw";
            this.btn_draw.UseVisualStyleBackColor = true;
            this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
            // 
            // lbl_a0
            // 
            this.lbl_a0.AutoSize = true;
            this.lbl_a0.Location = new System.Drawing.Point(547, 109);
            this.lbl_a0.Name = "lbl_a0";
            this.lbl_a0.Size = new System.Drawing.Size(11, 12);
            this.lbl_a0.TabIndex = 2;
            this.lbl_a0.Text = "0";
            // 
            // lbl_a1
            // 
            this.lbl_a1.AutoSize = true;
            this.lbl_a1.Location = new System.Drawing.Point(547, 143);
            this.lbl_a1.Name = "lbl_a1";
            this.lbl_a1.Size = new System.Drawing.Size(11, 12);
            this.lbl_a1.TabIndex = 3;
            this.lbl_a1.Text = "0";
            // 
            // lbl_a2
            // 
            this.lbl_a2.AutoSize = true;
            this.lbl_a2.Location = new System.Drawing.Point(547, 177);
            this.lbl_a2.Name = "lbl_a2";
            this.lbl_a2.Size = new System.Drawing.Size(11, 12);
            this.lbl_a2.TabIndex = 4;
            this.lbl_a2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "a0 = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "a1 = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "a2 = ";
            // 
            // lbl_fx
            // 
            this.lbl_fx.AutoSize = true;
            this.lbl_fx.Location = new System.Drawing.Point(246, 442);
            this.lbl_fx.Name = "lbl_fx";
            this.lbl_fx.Size = new System.Drawing.Size(0, 12);
            this.lbl_fx.TabIndex = 8;
            // 
            // lbl_St
            // 
            this.lbl_St.AutoSize = true;
            this.lbl_St.Location = new System.Drawing.Point(520, 249);
            this.lbl_St.Name = "lbl_St";
            this.lbl_St.Size = new System.Drawing.Size(36, 12);
            this.lbl_St.TabIndex = 9;
            this.lbl_St.Text = "St = 0";
            // 
            // lbl_Sr
            // 
            this.lbl_Sr.AutoSize = true;
            this.lbl_Sr.Location = new System.Drawing.Point(520, 282);
            this.lbl_Sr.Name = "lbl_Sr";
            this.lbl_Sr.Size = new System.Drawing.Size(37, 12);
            this.lbl_Sr.TabIndex = 10;
            this.lbl_Sr.Text = "Sr = 0";
            // 
            // lbl_R
            // 
            this.lbl_R.AutoSize = true;
            this.lbl_R.Location = new System.Drawing.Point(520, 315);
            this.lbl_R.Name = "lbl_R";
            this.lbl_R.Size = new System.Drawing.Size(37, 12);
            this.lbl_R.TabIndex = 11;
            this.lbl_R.Text = "R  = 0";
            // 
            // lbl_R2
            // 
            this.lbl_R2.AutoSize = true;
            this.lbl_R2.Location = new System.Drawing.Point(518, 348);
            this.lbl_R2.Name = "lbl_R2";
            this.lbl_R2.Size = new System.Drawing.Size(39, 12);
            this.lbl_R2.TabIndex = 12;
            this.lbl_R2.Text = "R2 = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 528);
            this.Controls.Add(this.lbl_R2);
            this.Controls.Add(this.lbl_R);
            this.Controls.Add(this.lbl_Sr);
            this.Controls.Add(this.lbl_St);
            this.Controls.Add(this.lbl_fx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_a2);
            this.Controls.Add(this.lbl_a1);
            this.Controls.Add(this.lbl_a0);
            this.Controls.Add(this.btn_draw);
            this.Controls.Add(this.pic_draw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_draw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_draw;
        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.Label lbl_a0;
        private System.Windows.Forms.Label lbl_a1;
        private System.Windows.Forms.Label lbl_a2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_fx;
        private System.Windows.Forms.Label lbl_St;
        private System.Windows.Forms.Label lbl_Sr;
        private System.Windows.Forms.Label lbl_R;
        private System.Windows.Forms.Label lbl_R2;
    }
}

