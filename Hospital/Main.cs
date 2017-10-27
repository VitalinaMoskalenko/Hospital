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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
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

        private void hospital_PatientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbDoctor_Click(object sender, EventArgs e)
        {
            DoctorForm DocF = new DoctorForm();
            DocF.ShowDialog();
        }

        private void tsbPatient_Click(object sender, EventArgs e)
        {
            PatientForm PatF = new PatientForm();
            PatF.ShowDialog();
        }

        private void tsbVisit_Click(object sender, EventArgs e)
        {
            VisitForm VisF = new VisitForm();
            VisF.ShowDialog();
        }

        private void tsbHistory_Click(object sender, EventArgs e)
        {
            HistoryForm HistF = new HistoryForm();
            HistF.ShowDialog();
        }

        private void tsbSpeciality_Click(object sender, EventArgs e)
        {
            SpecialityForm SpecF = new SpecialityForm();
            SpecF.ShowDialog();
        }

        private void tsbSick_Click(object sender, EventArgs e)
        {
            SickForm SickF = new SickForm();
            SickF.ShowDialog();
        }
    }
}
