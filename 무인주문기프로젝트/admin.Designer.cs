namespace 무인주문기프로젝트
{
    partial class admin
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
            this.영업시작 = new System.Windows.Forms.Button();
            this.상품재고 = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PassChange = new System.Windows.Forms.Button();
            this.주문목록 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 영업시작
            // 
            this.영업시작.BackColor = System.Drawing.Color.Orange;
            this.영업시작.Font = new System.Drawing.Font("문체부 제목 돋음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.영업시작.Location = new System.Drawing.Point(339, 342);
            this.영업시작.Name = "영업시작";
            this.영업시작.Size = new System.Drawing.Size(203, 112);
            this.영업시작.TabIndex = 2;
            this.영업시작.Text = "영업시작";
            this.영업시작.UseVisualStyleBackColor = false;
            this.영업시작.Click += new System.EventHandler(this.영업시작_Click);
            // 
            // 상품재고
            // 
            this.상품재고.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.상품재고.Font = new System.Drawing.Font("문체부 제목 돋음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품재고.Location = new System.Drawing.Point(31, 52);
            this.상품재고.Name = "상품재고";
            this.상품재고.Size = new System.Drawing.Size(104, 112);
            this.상품재고.TabIndex = 3;
            this.상품재고.Text = "상품관리";
            this.상품재고.UseVisualStyleBackColor = false;
            this.상품재고.Click += new System.EventHandler(this.상품재고_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("문체부 제목 돋음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logout.Location = new System.Drawing.Point(461, 51);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(81, 39);
            this.logout.TabIndex = 5;
            this.logout.Text = "로그아웃";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("문체부 제목 돋음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(367, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "회원탈퇴";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassChange
            // 
            this.PassChange.Font = new System.Drawing.Font("문체부 제목 돋음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PassChange.Location = new System.Drawing.Point(367, 96);
            this.PassChange.Name = "PassChange";
            this.PassChange.Size = new System.Drawing.Size(175, 39);
            this.PassChange.TabIndex = 7;
            this.PassChange.Text = "비밀번호변경";
            this.PassChange.UseVisualStyleBackColor = true;
            this.PassChange.Click += new System.EventHandler(this.PassChange_Click);
            // 
            // 주문목록
            // 
            this.주문목록.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.주문목록.Font = new System.Drawing.Font("문체부 제목 돋음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.주문목록.Location = new System.Drawing.Point(129, 52);
            this.주문목록.Name = "주문목록";
            this.주문목록.Size = new System.Drawing.Size(104, 112);
            this.주문목록.TabIndex = 8;
            this.주문목록.Text = "주문목록";
            this.주문목록.UseVisualStyleBackColor = false;
            this.주문목록.Click += new System.EventHandler(this.주문목록_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(591, 485);
            this.Controls.Add(this.주문목록);
            this.Controls.Add(this.PassChange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.상품재고);
            this.Controls.Add(this.영업시작);
            this.Font = new System.Drawing.Font("문체부 제목 돋음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button 영업시작;
        private System.Windows.Forms.Button 상품재고;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PassChange;
        private System.Windows.Forms.Button 주문목록;
    }
}