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

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button button1;
    }
}
