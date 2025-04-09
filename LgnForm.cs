using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_APP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox1.Tag.ToString() || textBox2.Text != textBox2.Tag.ToString())
            {
                MessageBox.Show("Invaled Username / password !! \n Try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBox2.Text = "";
            }
            else
            {
                Form Frm = new MainForm();
               
                Frm.ShowDialog();
                this.Close();
            }
        }

       
    }
}
