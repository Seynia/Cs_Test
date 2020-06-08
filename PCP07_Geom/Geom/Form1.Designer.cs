namespace Geom
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
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.btnDraw3 = new System.Windows.Forms.Button();
            this.btnDraw100 = new System.Windows.Forms.Button();
            this.lblNCir = new System.Windows.Forms.Label();
            this.lblNDia = new System.Windows.Forms.Label();
            this.lblNTotal = new System.Windows.Forms.Label();
            this.btnErase = new System.Windows.Forms.Button();
            this.lblNRect = new System.Windows.Forms.Label();
            this.lblNTri = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // picDraw
            // 
            this.picDraw.BackColor = System.Drawing.Color.White;
            this.picDraw.Location = new System.Drawing.Point(12, 12);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(400, 400);
            this.picDraw.TabIndex = 0;
            this.picDraw.TabStop = false;
            // 
            // btnDraw3
            // 
            this.btnDraw3.Location = new System.Drawing.Point(443, 12);
            this.btnDraw3.Name = "btnDraw3";
            this.btnDraw3.Size = new System.Drawing.Size(115, 43);
            this.btnDraw3.TabIndex = 1;
            this.btnDraw3.Text = "3개 그리기";
            this.btnDraw3.UseVisualStyleBackColor = true;
            this.btnDraw3.Click += new System.EventHandler(this.btnDraw3_Click);
            // 
            // btnDraw100
            // 
            this.btnDraw100.Location = new System.Drawing.Point(443, 61);
            this.btnDraw100.Name = "btnDraw100";
            this.btnDraw100.Size = new System.Drawing.Size(115, 43);
            this.btnDraw100.TabIndex = 2;
            this.btnDraw100.Text = "100개 그리기";
            this.btnDraw100.UseVisualStyleBackColor = true;
            this.btnDraw100.Click += new System.EventHandler(this.btnDraw100_Click);
            // 
            // lblNCir
            // 
            this.lblNCir.AutoSize = true;
            this.lblNCir.Location = new System.Drawing.Point(491, 123);
            this.lblNCir.Name = "lblNCir";
            this.lblNCir.Size = new System.Drawing.Size(11, 12);
            this.lblNCir.TabIndex = 3;
            this.lblNCir.Text = "0";
            // 
            // lblNDia
            // 
            this.lblNDia.AutoSize = true;
            this.lblNDia.Location = new System.Drawing.Point(491, 161);
            this.lblNDia.Name = "lblNDia";
            this.lblNDia.Size = new System.Drawing.Size(11, 12);
            this.lblNDia.TabIndex = 4;
            this.lblNDia.Text = "0";
            // 
            // lblNTotal
            // 
            this.lblNTotal.AutoSize = true;
            this.lblNTotal.Location = new System.Drawing.Point(491, 275);
            this.lblNTotal.Name = "lblNTotal";
            this.lblNTotal.Size = new System.Drawing.Size(11, 12);
            this.lblNTotal.TabIndex = 5;
            this.lblNTotal.Text = "0";
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(443, 317);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(115, 43);
            this.btnErase.TabIndex = 6;
            this.btnErase.Text = "지우기";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // lblNRect
            // 
            this.lblNRect.AutoSize = true;
            this.lblNRect.Location = new System.Drawing.Point(491, 237);
            this.lblNRect.Name = "lblNRect";
            this.lblNRect.Size = new System.Drawing.Size(11, 12);
            this.lblNRect.TabIndex = 7;
            this.lblNRect.Text = "0";
            // 
            // lblNTri
            // 
            this.lblNTri.AutoSize = true;
            this.lblNTri.Location = new System.Drawing.Point(491, 199);
            this.lblNTri.Name = "lblNTri";
            this.lblNTri.Size = new System.Drawing.Size(11, 12);
            this.lblNTri.TabIndex = 8;
            this.lblNTri.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Triangle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rectangle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Diamond";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Circle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNTri);
            this.Controls.Add(this.lblNRect);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.lblNTotal);
            this.Controls.Add(this.lblNDia);
            this.Controls.Add(this.lblNCir);
            this.Controls.Add(this.btnDraw100);
            this.Controls.Add(this.btnDraw3);
            this.Controls.Add(this.picDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.Button btnDraw3;
        private System.Windows.Forms.Button btnDraw100;
        private System.Windows.Forms.Label lblNCir;
        private System.Windows.Forms.Label lblNDia;
        private System.Windows.Forms.Label lblNTotal;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Label lblNRect;
        private System.Windows.Forms.Label lblNTri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

