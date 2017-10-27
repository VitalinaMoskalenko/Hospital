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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsHospital.PatientSelect' table. You can move, or remove it, as needed.
            this.patientSelectTableAdapter.Fill(this.dsHospital.PatientSelect);

            lblInfo.Text = User.UserDescription();


            foreach (var item in tsMenu.Items)
            {
                if (item.GetType() == typeof(ToolStripButton))
                {
                    ToolStripButton btn = (ToolStripButton)item;
                    if (User.ServicesList.Contains(btn.AccessibleName))
                    {
                        btn.Visible = true;
                    }
                }
            }
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbDeletePatient_Click(object sender, EventArgs e)
        {
            try
            {
                int deletePatientID = Convert.ToInt32(idTextBox.Text);
                procedures.PatientDelete(deletePatientID);
                MessageBox.Show("Patient has been deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbInsertPatient_Click(object sender, EventArgs e)
        {
            try
            {
                int? ID = null;
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string idCard = idCardTextBox.Text;
                string address = addressTextBox.Text;
                DateTime date = birthdayDateTimePicker.Value;
                string number = numberTextBox.Text;
                procedures.PatientInsert(firstName, lastName, idCard, address, date, number, ref ID);
                MessageBox.Show("Patient has been created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbUpdatePatient_Click(object sender, EventArgs e)
        {
            try
            {
                int? ID = Convert.ToInt32(idTextBox.Text);
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string idCard = idCardTextBox.Text;
                string address = addressTextBox.Text;
                DateTime date = birthdayDateTimePicker.Value;
                string number = numberTextBox.Text;
                procedures.PatientUpdate(firstName, lastName, idCard, address, date, number, ID);
                MessageBox.Show("Patient has been updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
