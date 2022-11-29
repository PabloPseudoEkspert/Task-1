using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int a = 0;
        int b = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            
            a++;
            txtOne.Text = a.ToString();
            txtChange.Text = "Button One";
        }

        private void txtOne_Click(object sender, EventArgs e)
        {

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            
            b++;
            txtTwo.Text = b.ToString();
            txtChange.Text = "Button Two";
        }

        private void txtTwo_Click(object sender, EventArgs e)
        {

        }

        private void txtChange_Click(object sender, EventArgs e)
        {
          
        }
    }
}
