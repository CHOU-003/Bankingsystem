using Newbt.Controllers;
using Newbt.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Newbt.Views
{
    public partial class EmployeeView : Form
    {
        private EmployeeController controller;
        private EmployeeModel employee;

        public EmployeeView()
        {
            InitializeComponent();
            controller = new EmployeeController();
            employee = new EmployeeModel();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }

        private void LoadEmployeeList()
        {

            dataGridView.Rows.Clear();
            if (controller.Load())
            {
                foreach (var emp in controller.Items)
                {
                    EmployeeModel employee = (EmployeeModel)emp;
                    dataGridView.Rows.Add(employee.id, employee.name, employee.password, employee.role);
                }
            }
        }

        private void GetDataFromTextBoxes()
        {
            employee.id = txtID.Text;
            employee.name = txtName.Text;
            employee.password = txtPassword.Text;
            employee.role = txtRole.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            GetDataFromTextBoxes();

            if (!employee.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(employee.id))
            {
                controller.Update(employee);

            }
            else
            {
                controller.Create(employee);
            }

            LoadEmployeeList();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtID.Text = row.Cells[0].Value?.ToString();
                txtName.Text = row.Cells[1].Value?.ToString();
                txtPassword.Text = row.Cells[2].Value?.ToString();
                txtRole.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();

            if (!employee.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(employee.id))
            {
                if (controller.Update(employee))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với ID này!");
            }

            LoadEmployeeList();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string employeeID = txtID.Text;

            if (string.IsNullOrEmpty(employeeID))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Kiểm tra xem ID có tồn tại trong cơ sở dữ liệu không
                if (controller.IsExist(employeeID))
                {
                    employee.id = employeeID; 
                    if (controller.Delete(employee))
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên với ID này!");
                }

                LoadEmployeeList();
            }
        }



        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}
