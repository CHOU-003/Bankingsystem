using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Newbt.Views
{
    partial class EmployeeView
    {
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtRole;
        private Button btnSave;
        private DataGridView dataGridView;

        private void InitializeComponent()
        {
            txtID = new TextBox();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtRole = new TextBox();
            btnSave = new Button();
            dataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(50, 50);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID";
            txtID.Size = new Size(200, 27);
            txtID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(50, 90);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(50, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(50, 170);
            txtRole.Name = "txtRole";
            txtRole.PlaceholderText = "Role";
            txtRole.Size = new Size(200, 27);
            txtRole.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(50, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView.Location = new Point(50, 250);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(600, 200);
            dataGridView.TabIndex = 5;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Password";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Role";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(216, 210);
            button1.Name = "button1";
            button1.Size = new Size(91, 34);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 9);
            label1.Name = "label1";
            label1.Size = new Size(282, 25);
            label1.TabIndex = 7;
            label1.Text = "THÔNG TIN EMPLOYEE";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 0);
            button2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(338, 210);
            button2.Name = "button2";
            button2.Size = new Size(104, 34);
            button2.TabIndex = 8;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EmployeeView
            // 
            ClientSize = new Size(932, 500);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(txtPassword);
            Controls.Add(txtRole);
            Controls.Add(btnSave);
            Name = "EmployeeView";
            Text = "Employee View";
            Load += EmployeeView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
