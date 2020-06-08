namespace MoleGame
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
            this.pic_card00 = new System.Windows.Forms.PictureBox();
            this.pic_card01 = new System.Windows.Forms.PictureBox();
            this.pic_card02 = new System.Windows.Forms.PictureBox();
            this.pic_card03 = new System.Windows.Forms.PictureBox();
            this.pic_card04 = new System.Windows.Forms.PictureBox();
            this.lbl_point = new System.Windows.Forms.Label();
            this.tim_open = new System.Windows.Forms.Timer(this.components);
            this.tim_closed = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_card00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_card01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_card02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_card03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_card04)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_card00
            // 
            this.pic_card00.Image = global::MoleGame.Properties.Resources.pae48;
            this.pic_card00.Location = new System.Drawing.Point(55, 126);
            this.pic_card00.Name = "pic_card00";
            this.pic_card00.Size = new System.Drawing.Size(68, 105);
            this.pic_card00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_card00.TabIndex = 0;
            this.pic_card00.TabStop = false;
            this.pic_card00.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_card00_MouseDown);
            // 
            // pic_card01
            // 
            this.pic_card01.Image = global::MoleGame.Properties.Resources.pae48;
            this.pic_card01.Location = new System.Drawing.Point(171, 126);
            this.pic_card01.Name = "pic_card01";
            this.pic_card01.Size = new System.Drawing.Size(68, 105);
            this.pic_card01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_card01.TabIndex = 1;
            this.pic_card01.TabStop = false;
            this.pic_card01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_card00_MouseDown);
            // 
            // pic_card02
            // 
            this.pic_card02.Image = global::MoleGame.Properties.Resources.pae48;
            this.pic_card02.Location = new System.Drawing.Point(287, 126);
            this.pic_card02.Name = "pic_card02";
            this.pic_card02.Size = new System.Drawing.Size(68, 105);
            this.pic_card02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_card02.TabIndex = 2;
            this.pic_card02.TabStop = false;
            this.pic_card02.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_card00_MouseDown);
            // 
            // pic_card03
            // 
            this.pic_card03.Image = global::MoleGame.Properties.Resources.pae48;
            this.pic_card03.Location = new System.Drawing.Point(403, 126);
            this.pic_card03.Name = "pic_card03";
            this.pic_card03.Size = new System.Drawing.Size(68, 105);
            this.pic_card03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_card03.TabIndex = 3;
            this.pic_card03.TabStop = false;
            this.pic_card03.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_card00_MouseDown);
            // 
            // pic_card04
            // 
            this.pic_card04.Image = global::MoleGame.Properties.Resources.pae48;
            this.pic_card04.Location = new System.Drawing.Point(519, 126);
            this.pic_card04.Name = "pic_card04";
            this.pic_card04.Size = new System.Drawing.Size(68, 105);
            this.pic_card04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_card04.TabIndex = 4;
            this.pic_card04.TabStop = false;
            this.pic_card04.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_card00_MouseDown);
            // 
            // lbl_point
            // 
            this.lbl_point.AutoSize = true;
            this.lbl_point.Font = new System.Drawing.Font("Verdana", 48F);
            this.lbl_point.Location = new System.Drawing.Point(12, 9);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(74, 78);
            this.lbl_point.TabIndex = 5;
            this.lbl_point.Text = "0";
            // 
            // tim_open
            // 
            this.tim_open.Enabled = true;
            this.tim_open.Interval = 1000;
            this.tim_open.Tick += new System.EventHandler(this.tim_open_Tick);
            // 
            // tim_closed
            // 
            this.tim_closed.Interval = 1000;
            this.tim_closed.Tick += new System.EventHandler(this.tim_closed_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 48F);
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = "Point";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_point);
            this.Controls.Add(this.pic_card04);
            this.Controls.Add(this.pic_card03);
            this.Controls.Add(this.pic_card02);
            this.Controls.Add(this.pic_card01);
            this.Controls.Add(this.pic_card00);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_card00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_card01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_card02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_card03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_card04)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_card00;
        private System.Windows.Forms.PictureBox pic_card01;
        private System.Windows.Forms.PictureBox pic_card02;
        private System.Windows.Forms.PictureBox pic_card03;
        private System.Windows.Forms.PictureBox pic_card04;
        private System.Windows.Forms.Label lbl_point;
        private System.Windows.Forms.Timer tim_open;
        private System.Windows.Forms.Timer tim_closed;
        private System.Windows.Forms.Label label1;
    }
}

