using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm1
{
    public partial class frmMain : Form
    {
        private Form _father;
        public frmMain(Form father)
        {
            InitializeComponent();

            this._father = father;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this._father.Show();
            this.Hide();
        }
    }
}
