namespace 무인주문기프로젝트
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.join = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(196, 177);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(265, 25);
            this.txtid.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(196, 217);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(265, 25);
            this.txtpass.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID.Location = new System.Drawing.Point(91, 180);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(25, 15);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Password.Location = new System.Drawing.Point(91, 220);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(85, 15);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.login.Font = new System.Drawing.Font("양재블럭체", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login.Location = new System.Drawing.Point(96, 312);
            this.login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(366, 71);
            this.login.TabIndex = 4;
            this.login.Text = "로그인";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // join
            // 
            this.join.BackColor = System.Drawing.Color.Gray;
            this.join.Font = new System.Drawing.Font("양재블럭체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join.Location = new System.Drawing.Point(95, 272);
            this.join.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(180, 34);
            this.join.TabIndex = 5;
            this.join.Text = "회원가입";
            this.join.UseVisualStyleBackColor = false;
            this.join.Click += new System.EventHandler(this.join_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Gray;
            this.search.Font = new System.Drawing.Font("양재블럭체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search.Location = new System.Drawing.Point(281, 272);
            this.search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(180, 34);
            this.search.TabIndex = 6;
            this.search.Text = "비밀번호찾기";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::무인주문기프로젝트.Properties.Resources.버거킹로고;
            this.pictureBox1.Location = new System.Drawing.Point(154, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(524, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.join);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button join;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

