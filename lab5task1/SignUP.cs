using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab5;

namespace lab5task1
{
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checking if both passwords are same
            if (textBox2.Text == textBox3.Text && textBox1.Text!=null &&textBox2!=null && textBox3!=null)
            {
                //creating account using lab5.dll
                bool isAccCrt = lab5.menu.CrtAcct(textBox1.Text, textBox2.Text);
                if (isAccCrt)
                {
                    MessageBox.Show("Account has been created");
                    this.Close();
                }
                else
                    MessageBox.Show("Your account already exist");
            }
            else
            {
                MessageBox.Show("Please recheck your password");
            }
            }
    }
}
