namespace Hospital
{
    partial class VisitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label doctorLabel;
            System.Windows.Forms.Label dateTimeLabel;
            System.Windows.Forms.Label patientLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitForm));
            this.lblInfo = new System.Windows.Forms.Label();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInsertVisit = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateVisit = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteVisit = new System.Windows.Forms.ToolStripButton();
            this.visitSelectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.visitSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHospital = new Hospital.dsHospital();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.dateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientTextBox = new System.Windows.Forms.TextBox();
            this.cbxDoctor = new System.Windows.Forms.ComboBox();
            this.cbxPatient = new System.Windows.Forms.ComboBox();
            this.taVisitSelect = new Hospital.dsHospitalTableAdapters.VisitSelectTableAdapter();
            this.tableAdapterManager = new Hospital.dsHospitalTableAdapters.TableAdapterManager();
            this.taPatientSelect = new Hospital.dsHospitalTableAdapters.PatientSelectTableAdapter();
            this.taDoctorSelect = new Hospital.dsHospitalTableAdapters.DoctorSelectTableAdapter();
            this.procedures = new Hospital.dsHospitalTableAdapters.Procedures();
            idLabel = new System.Windows.Forms.Label();
            doctorLabel = new System.Windows.Forms.Label();
            dateTimeLabel = new System.Windows.Forms.Label();
            patientLabel = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitSelectBindingNavigator)).BeginInit();
            this.visitSelectBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(65, 108);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 6;
            idLabel.Text = "id:";
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Location = new System.Drawing.Point(29, 140);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new System.Drawing.Size(61, 20);
            doctorLabel.TabIndex = 7;
            doctorLabel.Text = "Doctor:";
            doctorLabel.Click += new System.EventHandler(this.doctorLabel_Click);
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Location = new System.Drawing.Point(7, 217);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new System.Drawing.Size(83, 20);
            dateTimeLabel.TabIndex = 8;
            dateTimeLabel.Text = "date Time:";
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Location = new System.Drawing.Point(27, 247);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new System.Drawing.Size(63, 20);
            patientLabel.TabIndex = 9;
            patientLabel.Text = "Patient:";
            // 
            // lblInfo
            // 
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(237, 9);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfo.Size = new System.Drawing.Size(205, 93);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Tag = "";
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.toolStripSeparator1,
            this.tsbInsertVisit,
            this.tsbUpdateVisit,
            this.tsbDeleteVisit});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsMenu.Size = new System.Drawing.Size(462, 62);
            this.tsMenu.TabIndex = 4;
            this.tsMenu.Text = "tsMenu";
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(44, 59);
            this.tsbExit.Text = "Exit";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // tsbInsertVisit
            // 
            this.tsbInsertVisit.AccessibleName = "InsertVisit";
            this.tsbInsertVisit.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertVisit.Image")));
            this.tsbInsertVisit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertVisit.Name = "tsbInsertVisit";
            this.tsbInsertVisit.Size = new System.Drawing.Size(44, 59);
            this.tsbInsertVisit.Text = "Insert";
            this.tsbInsertVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInsertVisit.Visible = false;
            this.tsbInsertVisit.Click += new System.EventHandler(this.tsbInsertVisit_Click);
            // 
            // tsbUpdateVisit
            // 
            this.tsbUpdateVisit.AccessibleName = "UpdateVisit";
            this.tsbUpdateVisit.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdateVisit.Image")));
            this.tsbUpdateVisit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateVisit.Name = "tsbUpdateVisit";
            this.tsbUpdateVisit.Size = new System.Drawing.Size(49, 59);
            this.tsbUpdateVisit.Text = "Update";
            this.tsbUpdateVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUpdateVisit.Visible = false;
            this.tsbUpdateVisit.Click += new System.EventHandler(this.tsbUpdateVisit_Click);
            // 
            // tsbDeleteVisit
            // 
            this.tsbDeleteVisit.AccessibleName = "DeleteVisit";
            this.tsbDeleteVisit.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteVisit.Image")));
            this.tsbDeleteVisit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteVisit.Name = "tsbDeleteVisit";
            this.tsbDeleteVisit.Size = new System.Drawing.Size(44, 59);
            this.tsbDeleteVisit.Text = "Delete";
            this.tsbDeleteVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDeleteVisit.Visible = false;
            this.tsbDeleteVisit.Click += new System.EventHandler(this.tsbDeleteVisit_Click);
            // 
            // visitSelectBindingNavigator
            // 
            this.visitSelectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.visitSelectBindingNavigator.BindingSource = this.visitSelectBindingSource;
            this.visitSelectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.visitSelectBindingNavigator.DeleteItem = null;
            this.visitSelectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.visitSelectBindingNavigator.Location = new System.Drawing.Point(0, 62);
            this.visitSelectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.visitSelectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.visitSelectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.visitSelectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.visitSelectBindingNavigator.Name = "visitSelectBindingNavigator";
            this.visitSelectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.visitSelectBindingNavigator.Size = new System.Drawing.Size(462, 25);
            this.visitSelectBindingNavigator.TabIndex = 6;
            this.visitSelectBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // visitSelectBindingSource
            // 
            this.visitSelectBindingSource.DataMember = "VisitSelect";
            this.visitSelectBindingSource.DataSource = this.dsHospital;
            // 
            // dsHospital
            // 
            this.dsHospital.DataSetName = "dsHospital";
            this.dsHospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitSelectBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(96, 105);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(346, 26);
            this.idTextBox.TabIndex = 7;
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitSelectBindingSource, "Doctor", true));
            this.doctorTextBox.Location = new System.Drawing.Point(96, 137);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.ReadOnly = true;
            this.doctorTextBox.Size = new System.Drawing.Size(346, 26);
            this.doctorTextBox.TabIndex = 8;
            this.doctorTextBox.TextChanged += new System.EventHandler(this.doctorTextBox_TextChanged);
            // 
            // dateTimeDateTimePicker
            // 
            this.dateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visitSelectBindingSource, "dateTime", true));
            this.dateTimeDateTimePicker.Location = new System.Drawing.Point(96, 212);
            this.dateTimeDateTimePicker.Name = "dateTimeDateTimePicker";
            this.dateTimeDateTimePicker.Size = new System.Drawing.Size(346, 26);
            this.dateTimeDateTimePicker.TabIndex = 9;
            // 
            // patientTextBox
            // 
            this.patientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitSelectBindingSource, "Patient", true));
            this.patientTextBox.Location = new System.Drawing.Point(96, 244);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.ReadOnly = true;
            this.patientTextBox.Size = new System.Drawing.Size(346, 26);
            this.patientTextBox.TabIndex = 10;
            // 
            // cbxDoctor
            // 
            this.cbxDoctor.FormattingEnabled = true;
            this.cbxDoctor.Location = new System.Drawing.Point(96, 169);
            this.cbxDoctor.Name = "cbxDoctor";
            this.cbxDoctor.Size = new System.Drawing.Size(346, 28);
            this.cbxDoctor.TabIndex = 11;
            // 
            // cbxPatient
            // 
            this.cbxPatient.FormattingEnabled = true;
            this.cbxPatient.Location = new System.Drawing.Point(96, 283);
            this.cbxPatient.Name = "cbxPatient";
            this.cbxPatient.Size = new System.Drawing.Size(346, 28);
            this.cbxPatient.TabIndex = 12;
            // 
            // taVisitSelect
            // 
            this.taVisitSelect.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Hospital.dsHospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taPatientSelect
            // 
            this.taPatientSelect.ClearBeforeFill = true;
            // 
            // taDoctorSelect
            // 
            this.taDoctorSelect.ClearBeforeFill = true;
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 323);
            this.Controls.Add(this.cbxPatient);
            this.Controls.Add(this.cbxDoctor);
            this.Controls.Add(patientLabel);
            this.Controls.Add(this.patientTextBox);
            this.Controls.Add(dateTimeLabel);
            this.Controls.Add(this.dateTimeDateTimePicker);
            this.Controls.Add(doctorLabel);
            this.Controls.Add(this.doctorTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.visitSelectBindingNavigator);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VisitForm";
            this.Text = "VisitForm";
            this.Load += new System.EventHandler(this.VisitForm_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitSelectBindingNavigator)).EndInit();
            this.visitSelectBindingNavigator.ResumeLayout(false);
            this.visitSelectBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbInsertVisit;
        private System.Windows.Forms.ToolStripButton tsbUpdateVisit;
        private System.Windows.Forms.ToolStripButton tsbDeleteVisit;
        private dsHospital dsHospital;
        private System.Windows.Forms.BindingSource visitSelectBindingSource;
        private dsHospitalTableAdapters.VisitSelectTableAdapter taVisitSelect;
        private dsHospitalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator visitSelectBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.DateTimePicker dateTimeDateTimePicker;
        private System.Windows.Forms.TextBox patientTextBox;
        private System.Windows.Forms.ComboBox cbxDoctor;
        private System.Windows.Forms.ComboBox cbxPatient;
        private dsHospitalTableAdapters.PatientSelectTableAdapter taPatientSelect;
        private dsHospitalTableAdapters.DoctorSelectTableAdapter taDoctorSelect;
        private dsHospitalTableAdapters.Procedures procedures;
    }
}