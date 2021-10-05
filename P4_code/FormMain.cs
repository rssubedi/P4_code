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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Login formLogin = new Login();
            AppUser user = new AppUser();
            user.IsAuthenticated = false;

            while (user.IsAuthenticated == false && formLogin.ShowDialog(this) == DialogResult.OK)
            {
                user = formLogin.LoginUser;
            }

            if (formLogin.DialogResult != DialogResult.OK)
            {
                Close();
            }
            else
            {
                Text = "Main - No Project Selected";
            }

        }
    }
}
