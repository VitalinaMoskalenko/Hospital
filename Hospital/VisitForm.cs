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
    public partial class VisitForm : Form
    {
        public VisitForm()
        {
            InitializeComponent();
        }

        private void VisitForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsHospital.VisitSelect' table. You can move, or remove it, as needed.
            this.taVisitSelect.Fill(this.dsHospital.VisitSelect);

            Dictionary<int, string> dic = new Dictionary<int, string>();
            this.taPatientSelect.Fill(this.dsHospital.PatientSelect);
            foreach (DataRow r in dsHospital.PatientSelect.Rows)
            {
                string val = (r.Field<string>("PatientName"));
                int key = (r.Field<int>("id"));
                dic.Add(key, val);
            }
            cbxPatient.DataSource = new BindingSource(dic, null);
            cbxPatient.DisplayMember = "Value";
            cbxPatient.ValueMember = "Key";

            Dictionary<int, string> dicD = new Dictionary<int, string>();
            this.taDoctorSelect.Fill(this.dsHospital.DoctorSelect);
            foreach (DataRow r in dsHospital.DoctorSelect.Rows)
            {
                string val = (r.Field<string>("DoctorName"));
                int key = (r.Field<int>("id"));
                dicD.Add(key, val);
            }
            cbxDoctor.DataSource = new BindingSource(dicD, null);
            cbxDoctor.DisplayMember = "Value";
            cbxDoctor.ValueMember = "Key";

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

        private void lastNamePatientLabel_Click(object sender, EventArgs e)
        {

        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void doctorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorLabel_Click(object sender, EventArgs e)
        {

        }

        private void tsbInsertVisit_Click(object sender, EventArgs e)
        {
            try
            {
                int? ID = null;
                int? namePatID = ((KeyValuePair<int, string>)cbxPatient.SelectedItem).Key;
                int? nameDocID = ((KeyValuePair<int, string>)cbxDoctor.SelectedItem).Key;
                DateTime data = dateTimeDateTimePicker.Value;
                procedures.VisitInsert(nameDocID, data, namePatID, ref ID);
                MessageBox.Show("Visit has been created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbUpdateVisit_Click(object sender, EventArgs e)
        {
            try
            {
                int? ID = Convert.ToInt32(idTextBox.Text);
                int? namePatID = ((KeyValuePair<int, string>)cbxPatient.SelectedItem).Key;
                int? nameDocID = ((KeyValuePair<int, string>)cbxDoctor.SelectedItem).Key;
                DateTime data = dateTimeDateTimePicker.Value;
                procedures.VisitUpdate(nameDocID, data, namePatID, ID);
                MessageBox.Show("Visit has been updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbDeleteVisit_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(idTextBox.Text);
                procedures.VisitDelete(ID);
                MessageBox.Show("Visit has been deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
