using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopping
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            Form1 ref_Form1 = new Form1();
            ref_Form1.MdiParent = this;
            ref_Form1.Show();
        }
    }
}
