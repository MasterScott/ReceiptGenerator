using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5task1
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
        int total = 0;
        public void showBill(string[,] arr)
        {
            this.Show();
           
            for (int i=0; i<5; i++)
            {
                if (arr[i, 1] !=null)
                total += int.Parse(arr[i, 1]);
            }
            label20.Text = "$"+total.ToString();

            if (arr[0, 0] != null)
            {
                label13.Text = arr[0, 0];
                label3.Text = arr[0, 2];
                label18.Text = "$" + arr[0, 1];
            }
            else
            {
                label13.Text = null;
                label3.Text = null;
                label18.Text = null;
            }
            if (arr[1, 0] != null)
            {
                label12.Text = arr[1, 0];
                label4.Text = arr[1, 2];
                label17.Text = "$" + arr[1, 1];
            }
            else
            {
                label12.Text = null;
                label4.Text = null;
                label17.Text = null;
            }
            if (arr[2, 0] != null)
            {
                label11.Text = arr[2, 0];
                label5.Text = arr[2, 2];
                label16.Text = "$" + arr[2, 1];
            }
            else
            {
                label11.Text = null;
                label5.Text = null;
                label16.Text = null;
            }
            if (arr[3, 0] != null)
            {
                label10.Text = arr[3, 0];
                label6.Text = arr[3, 2];
                label15.Text = "$" + arr[3, 1];
            }
            else
            {
                label10.Text = null;
                label6.Text = null;
                label15.Text = null;
            }
            if (arr[4, 0] != null)
            {
                label1.Text = arr[4, 0];
                label7.Text = arr[4, 2];
                label14.Text = "$" + arr[4, 1];
            }
            else
            {
                label1.Text = null;
                label7.Text = null;
                label14.Text = null;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
