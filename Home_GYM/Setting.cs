using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_GYM
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
