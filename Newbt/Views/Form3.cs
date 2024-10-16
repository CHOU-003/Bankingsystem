using Newbt.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newbt
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            groupBox4.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Anchor = AnchorStyles.None;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeView  nhanvien = new EmployeeView();


            nhanvien.Show();


            this.Hide();
        }

        private void tạoTKKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTKkhach addtkkhach = new AddTKkhach();

            addtkkhach.Show();

            this.Hide();
        }

        private void tạoTKNgânHàngCủaKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themtaikhoan themtk = new Themtaikhoan();

            themtk.Show();

            this.Hide();
        }

        private void chuyềnTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chuyentien chuyentien = new Chuyentien();

            chuyentien.Show();
            this.Hide();
        }

        private void xemSốDưTKNgânHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoduTK sodu = new SoduTK();
            sodu.Show();
            this.Hide();
        }

        private void nhậtKýGiaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhatkyGD nhatky = new NhatkyGD();  
            nhatky.Show();
                this.Hide();
        }
    }
}
