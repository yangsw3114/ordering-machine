namespace 무인주문기프로젝트
{
    partial class PASSsearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.PW찾기 = new System.Windows.Forms.Button();
            this.passShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(73, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(56, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(26, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "전화번호 :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(135, 79);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(252, 25);
            this.txtid.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(135, 116);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(252, 25);
            this.txtname.TabIndex = 4;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(135, 153);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(252, 25);
            this.txtnum.TabIndex = 5;
            // 
            // PW찾기
            // 
            this.PW찾기.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PW찾기.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PW찾기.Location = new System.Drawing.Point(61, 227);
            this.PW찾기.Name = "PW찾기";
            this.PW찾기.Size = new System.Drawing.Size(328, 59);
            this.PW찾기.TabIndex = 6;
            this.PW찾기.Text = "비밀번호 확인";
            this.PW찾기.UseVisualStyleBackColor = true;
            this.PW찾기.Click += new System.EventHandler(this.PW찾기_Click);
            // 
            // passShow
            // 
            this.passShow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.passShow.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passShow.Location = new System.Drawing.Point(58, 326);
            this.passShow.Name = "passShow";
            this.passShow.Size = new System.Drawing.Size(329, 23);
            this.passShow.TabIndex = 7;
            this.passShow.Text = "입력이 맞을시 확인가능";
            // 
            // PASSsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 406);
            this.Controls.Add(this.passShow);
            this.Controls.Add(this.PW찾기);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PASSsearch";
            this.Text = "PASSsearch";
            this.Load += new System.EventHandler(this.PASSsearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button PW찾기;
        private System.Windows.Forms.Label passShow;
    }
}