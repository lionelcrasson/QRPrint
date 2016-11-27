using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QRPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//mainButtonCreate
        {

        }

        private void mainButtonPrint_Click(object sender, EventArgs e)
        {

        }

        private void mainButtonMAJ_Click(object sender, EventArgs e)
        {

        }

        private void mainButtonManage_Click(object sender, EventArgs e)
        {
            viewManageType windowType = new viewManageType();
            windowType.Show();
        }
    }
}
