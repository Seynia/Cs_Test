namespace Circles
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
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnAdd100 = new System.Windows.Forms.Button();
            this.chkMove = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDel = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.lblNCir = new System.Windows.Forms.Label();
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkEmbCircle = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(691, 542);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(106, 50);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "끝내기";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(691, 444);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(106, 50);
            this.btnDelAll.TabIndex = 10;
            this.btnDelAll.Text = "모두 삭제";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnAdd100
            // 
            this.btnAdd100.Location = new System.Drawing.Point(691, 378);
            this.btnAdd100.Name = "btnAdd100";
            this.btnAdd100.Size = new System.Drawing.Size(106, 50);
            this.btnAdd100.TabIndex = 11;
            this.btnAdd100.Text = "100개 넣기";
            this.btnAdd100.UseVisualStyleBackColor = true;
            this.btnAdd100.Click += new System.EventHandler(this.btnAdd100_Click);
            // 
            // chkMove
            // 
            this.chkMove.AutoSize = true;
            this.chkMove.Location = new System.Drawing.Point(629, 216);
            this.chkMove.Name = "chkMove";
            this.chkMove.Size = new System.Drawing.Size(48, 16);
            this.chkMove.TabIndex = 8;
            this.chkMove.Text = "이동";
            this.chkMove.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDel);
            this.groupBox1.Controls.Add(this.radAdd);
            this.groupBox1.Location = new System.Drawing.Point(629, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "픽쳐박스 클릭 동작";
            // 
            // radDel
            // 
            this.radDel.AutoSize = true;
            this.radDel.Location = new System.Drawing.Point(21, 69);
            this.radDel.Name = "radDel";
            this.radDel.Size = new System.Drawing.Size(71, 16);
            this.radDel.TabIndex = 0;
            this.radDel.Text = "삭제하기";
            this.radDel.UseVisualStyleBackColor = true;
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Checked = true;
            this.radAdd.Location = new System.Drawing.Point(21, 36);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(59, 16);
            this.radAdd.TabIndex = 0;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "더하기";
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // lblNCir
            // 
            this.lblNCir.AutoSize = true;
            this.lblNCir.Location = new System.Drawing.Point(627, 12);
            this.lblNCir.Name = "lblNCir";
            this.lblNCir.Size = new System.Drawing.Size(43, 12);
            this.lblNCir.TabIndex = 6;
            this.lblNCir.Text = "lblNCir";
            // 
            // picDraw
            // 
            this.picDraw.BackColor = System.Drawing.Color.White;
            this.picDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDraw.Location = new System.Drawing.Point(12, 12);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(600, 600);
            this.picDraw.TabIndex = 5;
            this.picDraw.TabStop = false;
            this.picDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDraw_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkEmbCircle
            // 
            this.chkEmbCircle.AutoSize = true;
            this.chkEmbCircle.Location = new System.Drawing.Point(629, 255);
            this.chkEmbCircle.Name = "chkEmbCircle";
            this.chkEmbCircle.Size = new System.Drawing.Size(128, 16);
            this.chkEmbCircle.TabIndex = 12;
            this.chkEmbCircle.Text = "포함되는 원 지우기";
            this.chkEmbCircle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 622);
            this.Controls.Add(this.chkEmbCircle);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnAdd100);
            this.Controls.Add(this.chkMove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNCir);
            this.Controls.Add(this.picDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnAdd100;
        private System.Windows.Forms.CheckBox chkMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDel;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.Label lblNCir;
        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkEmbCircle;
    }
}

