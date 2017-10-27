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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsHospital.DoctorSelect' table. You can move, or remove it, as needed.
            this.doctorSelectTableAdapter.Fill(this.dsHospital.DoctorSelect);

            Dictionary<int, string> dic = new Dictionary<int, string>();
            this.taSpeciality.Fill(this.dsHospital.SpecialitySelect);
            foreach (DataRow r in dsHospital.SpecialitySelect.Rows)
            {
                string val = (r.Field<string>("name"));
                int key = (r.Field<int>("id"));
                dic.Add(key, val);
            }
            comboBox1.DataSource = new BindingSource(dic, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            

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

        //private void btnTest_Click(object sender, EventArgs e)
        //{
        //    //string key1 = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Value;
        //    //int key2 = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
        //}

        private void tsbInsertDoctor_Click_1(object sender, EventArgs e)
        {
            try
            {
                int? ID = null;
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                int? keyID = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
                procedures.DoctorInsert(firstName, lastName, keyID, ref ID);
                MessageBox.Show("Doctor has been created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbUpdateDoctor_Click_1(object sender, EventArgs e)
        {
            try
            {
                int? updateDoctorID = Convert.ToInt32(idTextBox.Text);
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                int? keyID = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
                procedures.DoctorUpdate(firstName, lastName, keyID, updateDoctorID);
                MessageBox.Show("Doctor has been updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbDeleteDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                int deleteDoctorID = Convert.ToInt32(idTextBox.Text);
                procedures.DoctorDelete(deleteDoctorID);
                MessageBox.Show("Doctor has been deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
