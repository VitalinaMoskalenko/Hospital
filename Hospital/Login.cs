using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Login : Form
    {
        public bool logIn = false;

        public Login()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            logIn = false;
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            logIn = true;

            int? UserId = null;
            int? ErrorId = null;
            string firstName = "";
            string lastName = "";
            int? idPosition = null;
            string namePosition = "";
            Procedures.UserLogin(tbLogin.Text, tbPassword.Text, ref UserId, ref ErrorId);

            if (ErrorId == 0)
            {
                Procedures.UserGet(UserId, ref firstName, ref lastName, ref idPosition, ref namePosition);

                User.userId = (UserId != null) ? (int)UserId : 0;
                User.fName = firstName;
                User.lName = lastName;
                User.posId = (idPosition != null) ? (int)idPosition : 0;
                User.posName = namePosition;

                this.serviceList.Fill(this.dsHospital.AutentificationList, User.posId);
                foreach (DataRow r in dsHospital.AutentificationList.Rows)
                {
                    User.ServicesList.Add(r.Field<string>("name"));
                }
                this.Close();
            }
            else
            {
                logIn = false;
                MessageBox.Show("Invalid login or password",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
