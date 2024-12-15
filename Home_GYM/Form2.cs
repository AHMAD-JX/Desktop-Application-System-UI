using Home_GYM.models;
using System.Security.Cryptography;
using System.Text;

namespace Home_GYM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label5.Hide();
            label6.Hide();
            label4.Hide();
            textPassword.UseSystemPasswordChar = true;
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            bool ck = true;
            if (textUsername.Text == "")
            {
                ck = false;
                label5.Text = "reqired";
                label5.Show();

            }

            if (textPassword.Text == "")
            {
                ck = false;
                label4.Text = "reqired";
                label4.Show();

            }

            if (ck == true)
            {
                string pass = HashPass(textPassword.Text);
                var us = db.UserGyms.SingleOrDefault(u => u.Email == textUsername.Text && u.Password == pass);
                if (us != null)
                    -
                else
                    MessageBox.Show("Error in Email or Password");
            }
        }
        public string HashPass(string password)
        {

            byte[] encodedPassword = new UTF8Encoding().GetBytes(password);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();

            return encoded;//returns hashed version of password
        }
        private models.GymContext db = new models.GymContext();
        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (textPassword.UseSystemPasswordChar == false)
            {
                textPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
