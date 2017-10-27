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
    public partial class SpecialityForm : Form
    {
        public SpecialityForm()
        {
            InitializeComponent();
        }

        private void SpecialityFormcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsHospital.SpecialitySelect' table. You can move, or remove it, as needed.
            this.specialitySelectTableAdapter.Fill(this.dsHospital.SpecialitySelect);
            // TODO: This line of code loads data into the 'dsHospital.SpecialitySelect' table. You can move, or remove it, as needed.
            this.specialitySelectTableAdapter.Fill(this.dsHospital.SpecialitySelect);
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

        private void tsbInsertSpeciality_Click(object sender, EventArgs e)
        {
            try
            {
                int? ID = null;
                string name = nameTextBox.Text;
                string discribe = discribeTextBox.Text;
                procedures.SpecialityInsert(name, discribe, ref ID);
                MessageBox.Show("Speciality has been created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsbUpdateSpeciality_Click(object sender, EventArgs e)
        {
            try
            {
                int? ID = Convert.ToInt32(idTextBox.Text);
                string name = nameTextBox.Text;
                string discribe = discribeTextBox.Text;
                procedures.SpecialityUpdate(name, discribe, ID);
                MessageBox.Show("Speciality has been updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbDeleteSpeciality_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(idTextBox.Text);
                procedures.SpecialityDelete(ID);
                MessageBox.Show("Speciality has been deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void discribeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discribeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
