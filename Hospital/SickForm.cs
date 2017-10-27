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
    public partial class SickForm : Form
    {
        public SickForm()
        {
            InitializeComponent();
        }

        private void SickForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsHospital.SickSelect' table. You can move, or remove it, as needed.
            this.sickSelectTableAdapter.Fill(this.dsHospital.SickSelect);
            // TODO: This line of code loads data into the 'dsHospital.SickSelect' table. You can move, or remove it, as needed.
            this.sickSelectTableAdapter.Fill(this.dsHospital.SickSelect);

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

        private void tsbInsertSick_Click(object sender, EventArgs e)
        {
            try
            {
                int? ID = null;
                string name = nameTextBox.Text;
                string discription = discriptionTextBox.Text;
                procedures.SickInsert(name, discription, ref ID);
                MessageBox.Show("Doctor has been created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsbUpdateSick_Click(object sender, EventArgs e)
        {
            try
            {
                int? ID = Convert.ToInt32(idTextBox.Text);
                string name = nameTextBox.Text;
                string discription = discriptionTextBox.Text;
                procedures.SickUpdate(name, discription, ID);
                MessageBox.Show("Sick has been updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbDeleteSick_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(idTextBox.Text);
                procedures.SickDelete(ID);
                MessageBox.Show("Sick has been deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
