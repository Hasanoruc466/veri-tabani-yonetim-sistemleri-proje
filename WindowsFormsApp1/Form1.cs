using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void oUyesiButton_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }
        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
