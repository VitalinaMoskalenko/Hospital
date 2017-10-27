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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsHospital.HistoryView' table. You can move, or remove it, as needed.
            this.historyViewTableAdapter.Fill(this.dsHospital.HistoryView);

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

            Dictionary<int, string> dicS = new Dictionary<int, string>();
            this.taSickSelect.Fill(this.dsHospital.SickSelect);
            foreach (DataRow r in dsHospital.SickSelect.Rows)
            {
                string val = (r.Field<string>("name"));
                int key = (r.Field<int>("id"));
                dicS.Add(key, val);
            }
            cbxSick.DataSource = new BindingSource(dicS, null);
            cbxSick.DisplayMember = "Value";
            cbxSick.ValueMember = "Key";

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

        private void tsbInsertHistory_Click(object sender, EventArgs e)
        {
            try
            {
                int? ID = null;
                int? namePatID = ((KeyValuePair<int, string>)cbxPatient.SelectedItem).Key;
                int? nameDocID = ((KeyValuePair<int, string>)cbxDoctor.SelectedItem).Key;
                int? nameSickID = ((KeyValuePair<int, string>)cbxSick.SelectedItem).Key;
                procedures.HistoryPatientAndDoctorInsert(namePatID, nameDocID, nameSickID, ref ID);
                MessageBox.Show("History has been created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbUpdateHistory_Click(object sender, EventArgs e)
        {
            try
            {
                int? ID = Convert.ToInt32(idTextBox.Text);
                int? namePatID = ((KeyValuePair<int, string>)cbxPatient.SelectedItem).Key;
                int? nameDocID = ((KeyValuePair<int, string>)cbxDoctor.SelectedItem).Key;
                int? nameSickID = ((KeyValuePair<int, string>)cbxSick.SelectedItem).Key;
                procedures.HistoryPatientAndDoctorUpdate(namePatID, nameDocID, nameSickID, ID);
                MessageBox.Show("History has been updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbDeleteHistory_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(idTextBox.Text);
                procedures.HistoryPatientAndDoctorDelete(ID);
                MessageBox.Show("Visit has been deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
