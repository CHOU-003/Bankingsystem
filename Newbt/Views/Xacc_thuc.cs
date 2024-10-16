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
    public partial class Xacc_thuc : Form
    {
        public Xacc_thuc()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Anchor = AnchorStyles.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();


            form3.Show();


            this.Hide();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
