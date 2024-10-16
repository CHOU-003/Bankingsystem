namespace Newbt
{
    partial class Form3
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
            TreeNode treeNode1 = new TreeNode("xUân THới Sơn");
            TreeNode treeNode2 = new TreeNode("bÀ ĐIỂM");
            TreeNode treeNode3 = new TreeNode("hIệp THành");
            TreeNode treeNode4 = new TreeNode("HÓC MÔN", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("QUAN 7");
            TreeNode treeNode6 = new TreeNode("QUAN 2");
            TreeNode treeNode7 = new TreeNode("QUAN 12");
            TreeNode treeNode8 = new TreeNode("ben nghe");
            TreeNode treeNode9 = new TreeNode("da kao");
            TreeNode treeNode10 = new TreeNode("pham ngu lao");
            TreeNode treeNode11 = new TreeNode("QUAN 1", new TreeNode[] { treeNode8, treeNode9, treeNode10 });
            TreeNode treeNode12 = new TreeNode("CHI NHánh", new TreeNode[] { treeNode4, treeNode5, treeNode6, treeNode7, treeNode11 });
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            treeView1 = new TreeView();
            groupBox5 = new GroupBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            branchToolStripMenuItem = new ToolStripMenuItem();
            bankingToolStripMenuItem = new ToolStripMenuItem();
            tạoTKKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            tạoTKNgânHàngCủaKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            nạpTiềnVàoTKNgânHàngToolStripMenuItem = new ToolStripMenuItem();
            rútTiềnTừTKNgânHàngToolStripMenuItem = new ToolStripMenuItem();
            chuyềnTiềnToolStripMenuItem = new ToolStripMenuItem();
            xemSốDưTKNgânHàngToolStripMenuItem = new ToolStripMenuItem();
            nhậtKýGiaoDịchToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            userGuideToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Green;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(0, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1392, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Green;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.iconlobank;
            pictureBox1.Location = new Point(23, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Green;
            label4.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(83, 32);
            label4.Name = "label4";
            label4.Size = new Size(181, 34);
            label4.TabIndex = 2;
            label4.Text = "NDC BANK";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Location = new Point(0, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1145, 201);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.Green;
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(0, 406);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1392, 97);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.ForestGreen;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(469, 35);
            label3.Name = "label3";
            label3.Size = new Size(516, 25);
            label3.TabIndex = 2;
            label3.Text = "LIÊN HỆ ĐẾN HOTLINE: 03569885 ĐỂ NHẬN ĐƯỢC SỰ HỖ TRỢ";
            label3.Click += label3_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox4.Controls.Add(treeView1);
            groupBox4.Location = new Point(1146, 202);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(246, 198);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Enter += groupBox4_Enter;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(224, 224, 224);
            treeView1.BorderStyle = BorderStyle.FixedSingle;
            treeView1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            treeView1.ForeColor = Color.Teal;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "xUân THới Sơn";
            treeNode2.Name = "Node5";
            treeNode2.Text = "bÀ ĐIỂM";
            treeNode3.Name = "Node6";
            treeNode3.Text = "hIệp THành";
            treeNode4.Name = "Node1";
            treeNode4.Text = "HÓC MÔN";
            treeNode5.Name = "Node3";
            treeNode5.Text = "QUAN 7";
            treeNode6.Name = "Node7";
            treeNode6.Text = "QUAN 2";
            treeNode7.Name = "Node8";
            treeNode7.Text = "QUAN 12";
            treeNode8.Name = "Node10";
            treeNode8.Text = "ben nghe";
            treeNode9.Name = "Node11";
            treeNode9.Text = "da kao";
            treeNode10.Name = "Node12";
            treeNode10.Text = "pham ngu lao";
            treeNode11.Name = "Node9";
            treeNode11.Text = "QUAN 1";
            treeNode12.Name = "Node0";
            treeNode12.Text = "CHI NHánh";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode12 });
            treeView1.Size = new Size(234, 198);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(255, 224, 192);
            groupBox5.Controls.Add(menuStrip1);
            groupBox5.Location = new Point(0, 81);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1429, 63);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 224, 192);
            menuStrip1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, systemToolStripMenuItem, bankingToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(3, 23);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1423, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_2;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem, đăngXuấtToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(61, 33);
            fileToolStripMenuItem.Text = "File";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(201, 34);
            đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(201, 34);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(201, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeeToolStripMenuItem, branchToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(94, 33);
            systemToolStripMenuItem.Text = "System";
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(224, 34);
            employeeToolStripMenuItem.Text = "Employee";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // branchToolStripMenuItem
            // 
            branchToolStripMenuItem.Name = "branchToolStripMenuItem";
            branchToolStripMenuItem.Size = new Size(224, 34);
            branchToolStripMenuItem.Text = "Branch";
            // 
            // bankingToolStripMenuItem
            // 
            bankingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoTKKháchHàngToolStripMenuItem, tạoTKNgânHàngCủaKháchHàngToolStripMenuItem, nạpTiềnVàoTKNgânHàngToolStripMenuItem, rútTiềnTừTKNgânHàngToolStripMenuItem, chuyềnTiềnToolStripMenuItem, xemSốDưTKNgânHàngToolStripMenuItem, nhậtKýGiaoDịchToolStripMenuItem });
            bankingToolStripMenuItem.Name = "bankingToolStripMenuItem";
            bankingToolStripMenuItem.Size = new Size(103, 33);
            bankingToolStripMenuItem.Text = "Banking";
            // 
            // tạoTKKháchHàngToolStripMenuItem
            // 
            tạoTKKháchHàngToolStripMenuItem.Name = "tạoTKKháchHàngToolStripMenuItem";
            tạoTKKháchHàngToolStripMenuItem.Size = new Size(423, 34);
            tạoTKKháchHàngToolStripMenuItem.Text = "Tạo TK khách hàng";
            tạoTKKháchHàngToolStripMenuItem.Click += tạoTKKháchHàngToolStripMenuItem_Click;
            // 
            // tạoTKNgânHàngCủaKháchHàngToolStripMenuItem
            // 
            tạoTKNgânHàngCủaKháchHàngToolStripMenuItem.Name = "tạoTKNgânHàngCủaKháchHàngToolStripMenuItem";
            tạoTKNgânHàngCủaKháchHàngToolStripMenuItem.Size = new Size(423, 34);
            tạoTKNgânHàngCủaKháchHàngToolStripMenuItem.Text = "Tạo TK ngân hàng của khách hàng";
            tạoTKNgânHàngCủaKháchHàngToolStripMenuItem.Click += tạoTKNgânHàngCủaKháchHàngToolStripMenuItem_Click;
            // 
            // nạpTiềnVàoTKNgânHàngToolStripMenuItem
            // 
            nạpTiềnVàoTKNgânHàngToolStripMenuItem.Name = "nạpTiềnVàoTKNgânHàngToolStripMenuItem";
            nạpTiềnVàoTKNgânHàngToolStripMenuItem.Size = new Size(423, 34);
            nạpTiềnVàoTKNgânHàngToolStripMenuItem.Text = "Nạp tiền vào TK ngân hàng";
            // 
            // rútTiềnTừTKNgânHàngToolStripMenuItem
            // 
            rútTiềnTừTKNgânHàngToolStripMenuItem.Name = "rútTiềnTừTKNgânHàngToolStripMenuItem";
            rútTiềnTừTKNgânHàngToolStripMenuItem.Size = new Size(423, 34);
            rútTiềnTừTKNgânHàngToolStripMenuItem.Text = "Rút tiền từ TK ngân hàng";
            // 
            // chuyềnTiềnToolStripMenuItem
            // 
            chuyềnTiềnToolStripMenuItem.Name = "chuyềnTiềnToolStripMenuItem";
            chuyềnTiềnToolStripMenuItem.Size = new Size(423, 34);
            chuyềnTiềnToolStripMenuItem.Text = "Chuyển tiền";
            chuyềnTiềnToolStripMenuItem.Click += chuyềnTiềnToolStripMenuItem_Click;
            // 
            // xemSốDưTKNgânHàngToolStripMenuItem
            // 
            xemSốDưTKNgânHàngToolStripMenuItem.Name = "xemSốDưTKNgânHàngToolStripMenuItem";
            xemSốDưTKNgânHàngToolStripMenuItem.Size = new Size(423, 34);
            xemSốDưTKNgânHàngToolStripMenuItem.Text = "Xem số dư TK ngân hàng";
            xemSốDưTKNgânHàngToolStripMenuItem.Click += xemSốDưTKNgânHàngToolStripMenuItem_Click;
            // 
            // nhậtKýGiaoDịchToolStripMenuItem
            // 
            nhậtKýGiaoDịchToolStripMenuItem.Name = "nhậtKýGiaoDịchToolStripMenuItem";
            nhậtKýGiaoDịchToolStripMenuItem.Size = new Size(423, 34);
            nhậtKýGiaoDịchToolStripMenuItem.Text = "Nhật ký giao dịch";
            nhậtKýGiaoDịchToolStripMenuItem.Click += nhậtKýGiaoDịchToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userGuideToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(70, 33);
            helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            userGuideToolStripMenuItem.Size = new Size(200, 34);
            userGuideToolStripMenuItem.Text = "User guide";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(200, 34);
            aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Gainsboro;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip1.Location = new Point(0, 478);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1392, 26);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(235, 20);
            toolStripStatusLabel1.Text = "Email\t: thuongtrucweb@sbv.gov.vn";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(312, 20);
            toolStripStatusLabel2.Text = "\tThường trực Ban biên tập\t: (84 - 243) 266.9435";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(318, 20);
            toolStripStatusLabel3.Text = "Địa chỉ\t: Số 49 Lý Thái Tổ - Hoàn Kiếm - Hà Nội";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 504);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label3;
        private Label label4;
        private TreeView treeView1;
        private PictureBox pictureBox1;
        private GroupBox groupBox5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem bankingToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem branchToolStripMenuItem;
        private ToolStripMenuItem tạoTKKháchHàngToolStripMenuItem;
        private ToolStripMenuItem tạoTKNgânHàngCủaKháchHàngToolStripMenuItem;
        private ToolStripMenuItem nạpTiềnVàoTKNgânHàngToolStripMenuItem;
        private ToolStripMenuItem rútTiềnTừTKNgânHàngToolStripMenuItem;
        private ToolStripMenuItem chuyềnTiềnToolStripMenuItem;
        private ToolStripMenuItem xemSốDưTKNgânHàngToolStripMenuItem;
        private ToolStripMenuItem nhậtKýGiaoDịchToolStripMenuItem;
        private ToolStripMenuItem userGuideToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
}