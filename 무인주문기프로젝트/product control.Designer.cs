namespace 무인주문기프로젝트
{
    partial class product_control
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menufix = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.fix = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.txtMcount = new System.Windows.Forms.TextBox();
            this.txtMprice = new System.Windows.Forms.TextBox();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.menufix.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 303);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1012, 337);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "메뉴";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "가격";
            this.columnHeader2.Width = 254;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "재고량";
            this.columnHeader3.Width = 379;
            // 
            // menufix
            // 
            this.menufix.Controls.Add(this.delete);
            this.menufix.Controls.Add(this.fix);
            this.menufix.Controls.Add(this.add);
            this.menufix.Controls.Add(this.txtMcount);
            this.menufix.Controls.Add(this.txtMprice);
            this.menufix.Controls.Add(this.txtMname);
            this.menufix.Controls.Add(this.label3);
            this.menufix.Controls.Add(this.label2);
            this.menufix.Controls.Add(this.label1);
            this.menufix.Location = new System.Drawing.Point(626, 17);
            this.menufix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menufix.Name = "menufix";
            this.menufix.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menufix.Size = new System.Drawing.Size(397, 277);
            this.menufix.TabIndex = 1;
            this.menufix.TabStop = false;
            this.menufix.Text = "메뉴추가/삭제/수정";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.delete.Location = new System.Drawing.Point(269, 214);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(106, 33);
            this.delete.TabIndex = 8;
            this.delete.Text = "삭제";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // fix
            // 
            this.fix.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fix.Location = new System.Drawing.Point(141, 214);
            this.fix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fix.Name = "fix";
            this.fix.Size = new System.Drawing.Size(106, 33);
            this.fix.TabIndex = 7;
            this.fix.Text = "수정";
            this.fix.UseVisualStyleBackColor = false;
            this.fix.Click += new System.EventHandler(this.fix_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.add.Location = new System.Drawing.Point(11, 214);
            this.add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(106, 33);
            this.add.TabIndex = 6;
            this.add.Text = "추가";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // txtMcount
            // 
            this.txtMcount.Location = new System.Drawing.Point(124, 139);
            this.txtMcount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMcount.Name = "txtMcount";
            this.txtMcount.Size = new System.Drawing.Size(250, 27);
            this.txtMcount.TabIndex = 5;
            // 
            // txtMprice
            // 
            this.txtMprice.Location = new System.Drawing.Point(124, 89);
            this.txtMprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMprice.Name = "txtMprice";
            this.txtMprice.Size = new System.Drawing.Size(250, 27);
            this.txtMprice.TabIndex = 4;
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(124, 41);
            this.txtMname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(250, 27);
            this.txtMname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(7, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "메뉴 재고량";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "메뉴가격";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "메뉴이름";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(19, 17);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(119, 33);
            this.back.TabIndex = 3;
            this.back.Text = "이전으로";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // product_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 649);
            this.Controls.Add(this.back);
            this.Controls.Add(this.menufix);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("함초롬돋움 확장", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "product_control";
            this.Text = "product_control";
            this.Load += new System.EventHandler(this.product_control_Load);
            this.menufix.ResumeLayout(false);
            this.menufix.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox menufix;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button fix;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox txtMcount;
        private System.Windows.Forms.TextBox txtMprice;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
    }
}