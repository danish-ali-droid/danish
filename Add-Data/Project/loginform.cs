using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfaqProject
{
    public partial class loginform : Form
    {
         

        public loginform()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string userid =useridtxtbox.Text;
            string pass=passwordtxtbox.Text;
            if (userid=="Admin"&& pass == "Admin")
            {
                departmentcobobox data = new departmentcobobox();
                data.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invilid UserId or Password", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                loginform login = new loginform();
                login.Show();
            }
        }
    }
}
