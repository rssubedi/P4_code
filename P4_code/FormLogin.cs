using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P3_code;

namespace P4_code
{
    public partial class Login : Form
    {
        public AppUser LoginUser = new AppUser();
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            FakeAppUserRespository test = new FakeAppUserRespository();
            string User_Name = userNameInput.Text;
            string PASSWORD = passwordInput.Text;
            bool result = test.Login(User_Name, PASSWORD);

            if (result == true)
            {
                test.SetAuthentication(User_Name, result);
                LoginUser = test.GetByUserName(User_Name);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password", "Attention");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
