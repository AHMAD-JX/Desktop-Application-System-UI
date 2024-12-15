namespace Home_GYM
{
    public partial class FormChild : Form
    {
        bool sideBarExpand;
        public FormChild()
        {
            InitializeComponent();
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    Sidebartimer.Stop();

                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    Sidebartimer.Stop();
                }
            }
        }

        private void menuBox_Click(object sender, EventArgs e)
        {
            Sidebartimer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void YourProgress_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hide_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new AddUser());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new AddResources());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Setting());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
