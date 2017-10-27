namespace Hospital
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label namePatientLabel;
            System.Windows.Forms.Label idCardLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label nameDoctorLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label discriptionLabel;
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInsertHistory = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateHistory = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteHistory = new System.Windows.Forms.ToolStripButton();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.lblInfo = new System.Windows.Forms.Label();
            this.historyViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.namePatientTextBox = new System.Windows.Forms.TextBox();
            this.idCardTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.nameDoctorTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.discriptionTextBox = new System.Windows.Forms.TextBox();
            this.cbxSick = new System.Windows.Forms.ComboBox();
            this.cbxPatient = new System.Windows.Forms.ComboBox();
            this.cbxDoctor = new System.Windows.Forms.ComboBox();
            this.historyViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHospital = new Hospital.dsHospital();
            this.historyViewTableAdapter = new Hospital.dsHospitalTableAdapters.HistoryViewTableAdapter();
            this.tableAdapterManager = new Hospital.dsHospitalTableAdapters.TableAdapterManager();
            this.procedures = new Hospital.dsHospitalTableAdapters.Procedures();
            this.taPatientSelect = new Hospital.dsHospitalTableAdapters.PatientSelectTableAdapter();
            this.taDoctorSelect = new Hospital.dsHospitalTableAdapters.DoctorSelectTableAdapter();
            this.taSickSelect = new Hospital.dsHospitalTableAdapters.SickSelectTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            namePatientLabel = new System.Windows.Forms.Label();
            idCardLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            nameDoctorLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            discriptionLabel = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyViewBindingNavigator)).BeginInit();
            this.historyViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).BeginInit();
            this.SuspendLayout();
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
            // tsbInsertHistory
            // 
            this.tsbInsertHistory.AccessibleName = "InsertHistory";
            this.tsbInsertHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertHistory.Image")));
            this.tsbInsertHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertHistory.Name = "tsbInsertHistory";
            this.tsbInsertHistory.Size = new System.Drawing.Size(44, 59);
            this.tsbInsertHistory.Text = "Insert";
            this.tsbInsertHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInsertHistory.Visible = false;
            this.tsbInsertHistory.Click += new System.EventHandler(this.tsbInsertHistory_Click);
            // 
            // tsbUpdateHistory
            // 
            this.tsbUpdateHistory.AccessibleName = "UpdateHistory";
            this.tsbUpdateHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdateHistory.Image")));
            this.tsbUpdateHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateHistory.Name = "tsbUpdateHistory";
            this.tsbUpdateHistory.Size = new System.Drawing.Size(49, 59);
            this.tsbUpdateHistory.Text = "Update";
            this.tsbUpdateHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUpdateHistory.Visible = false;
            this.tsbUpdateHistory.Click += new System.EventHandler(this.tsbUpdateHistory_Click);
            // 
            // tsbDeleteHistory
            // 
            this.tsbDeleteHistory.AccessibleName = "DeleteHistory";
            this.tsbDeleteHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteHistory.Image")));
            this.tsbDeleteHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteHistory.Name = "tsbDeleteHistory";
            this.tsbDeleteHistory.Size = new System.Drawing.Size(44, 59);
            this.tsbDeleteHistory.Text = "Delete";
            this.tsbDeleteHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDeleteHistory.Visible = false;
            this.tsbDeleteHistory.Click += new System.EventHandler(this.tsbDeleteHistory_Click);
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.toolStripSeparator1,
            this.tsbInsertHistory,
            this.tsbUpdateHistory,
            this.tsbDeleteHistory});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsMenu.Size = new System.Drawing.Size(463, 62);
            this.tsMenu.TabIndex = 6;
            this.tsMenu.Text = "tsMenu";
            // 
            // lblInfo
            // 
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(238, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfo.Size = new System.Drawing.Size(205, 93);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Tag = "";
            // 
            // historyViewBindingNavigator
            // 
            this.historyViewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.historyViewBindingNavigator.BindingSource = this.historyViewBindingSource;
            this.historyViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.historyViewBindingNavigator.DeleteItem = null;
            this.historyViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.historyViewBindingNavigator.Location = new System.Drawing.Point(0, 62);
            this.historyViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.historyViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.historyViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.historyViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.historyViewBindingNavigator.Name = "historyViewBindingNavigator";
            this.historyViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.historyViewBindingNavigator.Size = new System.Drawing.Size(463, 25);
            this.historyViewBindingNavigator.TabIndex = 10;
            this.historyViewBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(120, 108);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 10;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historyViewBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(151, 105);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(292, 26);
            this.idTextBox.TabIndex = 11;
            // 
            // namePatientLabel
            // 
            namePatientLabel.AutoSize = true;
            namePatientLabel.Location = new System.Drawing.Point(36, 140);
            namePatientLabel.Name = "namePatientLabel";
            namePatientLabel.Size = new System.Drawing.Size(109, 20);
            namePatientLabel.TabIndex = 11;
            namePatientLabel.Text = "Name Patient:";
            // 
            // namePatientTextBox
            // 
            this.namePatientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historyViewBindingSource, "NamePatient", true));
            this.namePatientTextBox.Location = new System.Drawing.Point(151, 137);
            this.namePatientTextBox.Name = "namePatientTextBox";
            this.namePatientTextBox.ReadOnly = true;
            this.namePatientTextBox.Size = new System.Drawing.Size(292, 26);
            this.namePatientTextBox.TabIndex = 12;
            // 
            // idCardLabel
            // 
            idCardLabel.AutoSize = true;
            idCardLabel.Location = new System.Drawing.Point(82, 205);
            idCardLabel.Name = "idCardLabel";
            idCardLabel.Size = new System.Drawing.Size(63, 20);
            idCardLabel.TabIndex = 12;
            idCardLabel.Text = "id Card:";
            // 
            // idCardTextBox
            // 
            this.idCardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historyViewBindingSource, "idCard", true));
            this.idCardTextBox.Location = new System.Drawing.Point(151, 203);
            this.idCardTextBox.Name = "idCardTextBox";
            this.idCardTextBox.ReadOnly = true;
            this.idCardTextBox.Size = new System.Drawing.Size(292, 26);
            this.idCardTextBox.TabIndex = 13;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(75, 237);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(70, 20);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historyViewBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(151, 235);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(292, 26);
            this.addressTextBox.TabIndex = 14;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(76, 270);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(69, 20);
            birthdayLabel.TabIndex = 14;
            birthdayLabel.Text = "birthday:";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.historyViewBindingSource, "birthday", true));
            this.birthdayDateTimePicker.Enabled = false;
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(151, 267);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(292, 26);
            this.birthdayDateTimePicker.TabIndex = 15;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(78, 301);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(67, 20);
            numberLabel.TabIndex = 15;
            numberLabel.Text = "number:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historyViewBindingSource, "number", true));
            this.numberTextBox.Location = new System.Drawing.Point(151, 299);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.ReadOnly = true;
            this.numberTextBox.Size = new System.Drawing.Size(292, 26);
            this.numberTextBox.TabIndex = 16;
            // 
            // nameDoctorLabel
            // 
            nameDoctorLabel.AutoSize = true;
            nameDoctorLabel.Location = new System.Drawing.Point(38, 333);
            nameDoctorLabel.Name = "nameDoctorLabel";
            nameDoctorLabel.Size = new System.Drawing.Size(107, 20);
            nameDoctorLabel.TabIndex = 16;
            nameDoctorLabel.Text = "Name Doctor:";
            // 
            // nameDoctorTextBox
            // 
            this.nameDoctorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historyViewBindingSource, "NameDoctor", true));
            this.nameDoctorTextBox.Location = new System.Drawing.Point(151, 331);
            this.nameDoctorTextBox.Name = "nameDoctorTextBox";
            this.nameDoctorTextBox.ReadOnly = true;
            this.nameDoctorTextBox.Size = new System.Drawing.Size(292, 26);
            this.nameDoctorTextBox.TabIndex = 17;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(102, 399);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(43, 20);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Sick:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historyViewBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(151, 397);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(292, 26);
            this.nameTextBox.TabIndex = 18;
            // 
            // discriptionLabel
            // 
            discriptionLabel.AutoSize = true;
            discriptionLabel.Location = new System.Drawing.Point(61, 465);
            discriptionLabel.Name = "discriptionLabel";
            discriptionLabel.Size = new System.Drawing.Size(84, 20);
            discriptionLabel.TabIndex = 19;
            discriptionLabel.Text = "discription:";
            // 
            // discriptionTextBox
            // 
            this.discriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historyViewBindingSource, "discription", true));
            this.discriptionTextBox.Location = new System.Drawing.Point(151, 463);
            this.discriptionTextBox.Name = "discriptionTextBox";
            this.discriptionTextBox.ReadOnly = true;
            this.discriptionTextBox.Size = new System.Drawing.Size(292, 26);
            this.discriptionTextBox.TabIndex = 20;
            // 
            // cbxSick
            // 
            this.cbxSick.FormattingEnabled = true;
            this.cbxSick.Location = new System.Drawing.Point(151, 429);
            this.cbxSick.Name = "cbxSick";
            this.cbxSick.Size = new System.Drawing.Size(292, 28);
            this.cbxSick.TabIndex = 21;
            // 
            // cbxPatient
            // 
            this.cbxPatient.FormattingEnabled = true;
            this.cbxPatient.Location = new System.Drawing.Point(151, 169);
            this.cbxPatient.Name = "cbxPatient";
            this.cbxPatient.Size = new System.Drawing.Size(292, 28);
            this.cbxPatient.TabIndex = 22;
            // 
            // cbxDoctor
            // 
            this.cbxDoctor.FormattingEnabled = true;
            this.cbxDoctor.Location = new System.Drawing.Point(151, 363);
            this.cbxDoctor.Name = "cbxDoctor";
            this.cbxDoctor.Size = new System.Drawing.Size(292, 28);
            this.cbxDoctor.TabIndex = 23;
            // 
            // historyViewBindingSource
            // 
            this.historyViewBindingSource.DataMember = "HistoryView";
            this.historyViewBindingSource.DataSource = this.dsHospital;
            // 
            // dsHospital
            // 
            this.dsHospital.DataSetName = "dsHospital";
            this.dsHospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyViewTableAdapter
            // 
            this.historyViewTableAdapter.ClearBeforeFill = true;
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
            // taSickSelect
            // 
            this.taSickSelect.ClearBeforeFill = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 515);
            this.Controls.Add(this.cbxDoctor);
            this.Controls.Add(this.cbxPatient);
            this.Controls.Add(this.cbxSick);
            this.Controls.Add(discriptionLabel);
            this.Controls.Add(this.discriptionTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(nameDoctorLabel);
            this.Controls.Add(this.nameDoctorTextBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(idCardLabel);
            this.Controls.Add(this.idCardTextBox);
            this.Controls.Add(namePatientLabel);
            this.Controls.Add(this.namePatientTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.historyViewBindingNavigator);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyViewBindingNavigator)).EndInit();
            this.historyViewBindingNavigator.ResumeLayout(false);
            this.historyViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbInsertHistory;
        private System.Windows.Forms.ToolStripButton tsbUpdateHistory;
        private System.Windows.Forms.ToolStripButton tsbDeleteHistory;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.Label lblInfo;
        private dsHospital dsHospital;
        private System.Windows.Forms.BindingSource historyViewBindingSource;
        private dsHospitalTableAdapters.HistoryViewTableAdapter historyViewTableAdapter;
        private dsHospitalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator historyViewBindingNavigator;
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
        private System.Windows.Forms.TextBox namePatientTextBox;
        private System.Windows.Forms.TextBox idCardTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameDoctorTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox discriptionTextBox;
        private System.Windows.Forms.ComboBox cbxSick;
        private System.Windows.Forms.ComboBox cbxPatient;
        private System.Windows.Forms.ComboBox cbxDoctor;
        private dsHospitalTableAdapters.Procedures procedures;
        private dsHospitalTableAdapters.PatientSelectTableAdapter taPatientSelect;
        private dsHospitalTableAdapters.DoctorSelectTableAdapter taDoctorSelect;
        private dsHospitalTableAdapters.SickSelectTableAdapter taSickSelect;

    }
}