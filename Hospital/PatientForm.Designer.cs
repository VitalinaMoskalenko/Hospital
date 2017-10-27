namespace Hospital
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label idCardLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label numberLabel;
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInsertPatient = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdatePatient = new System.Windows.Forms.ToolStripButton();
            this.tsbDeletePatient = new System.Windows.Forms.ToolStripButton();
            this.patientSelectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patientSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHospital = new Hospital.dsHospital();
            this.patientSelectTableAdapter = new Hospital.dsHospitalTableAdapters.PatientSelectTableAdapter();
            this.tableAdapterManager = new Hospital.dsHospitalTableAdapters.TableAdapterManager();
            this.procedures = new Hospital.dsHospitalTableAdapters.Procedures();
            this.lblInfo = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.idCardTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            idCardLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientSelectBindingNavigator)).BeginInit();
            this.patientSelectBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.toolStripSeparator1,
            this.tsbInsertPatient,
            this.tsbUpdatePatient,
            this.tsbDeletePatient});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsMenu.Size = new System.Drawing.Size(473, 62);
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
            // tsbInsertPatient
            // 
            this.tsbInsertPatient.AccessibleName = "InsertPatient";
            this.tsbInsertPatient.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertPatient.Image")));
            this.tsbInsertPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertPatient.Name = "tsbInsertPatient";
            this.tsbInsertPatient.Size = new System.Drawing.Size(44, 59);
            this.tsbInsertPatient.Text = "Insert";
            this.tsbInsertPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInsertPatient.Visible = false;
            this.tsbInsertPatient.Click += new System.EventHandler(this.tsbInsertPatient_Click);
            // 
            // tsbUpdatePatient
            // 
            this.tsbUpdatePatient.AccessibleName = "UpdatePatient";
            this.tsbUpdatePatient.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdatePatient.Image")));
            this.tsbUpdatePatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdatePatient.Name = "tsbUpdatePatient";
            this.tsbUpdatePatient.Size = new System.Drawing.Size(49, 59);
            this.tsbUpdatePatient.Text = "Update";
            this.tsbUpdatePatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUpdatePatient.Visible = false;
            this.tsbUpdatePatient.Click += new System.EventHandler(this.tsbUpdatePatient_Click);
            // 
            // tsbDeletePatient
            // 
            this.tsbDeletePatient.AccessibleName = "DeletePatient";
            this.tsbDeletePatient.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeletePatient.Image")));
            this.tsbDeletePatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeletePatient.Name = "tsbDeletePatient";
            this.tsbDeletePatient.Size = new System.Drawing.Size(44, 59);
            this.tsbDeletePatient.Text = "Delete";
            this.tsbDeletePatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDeletePatient.Visible = false;
            this.tsbDeletePatient.Click += new System.EventHandler(this.tsbDeletePatient_Click);
            // 
            // patientSelectBindingNavigator
            // 
            this.patientSelectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientSelectBindingNavigator.BindingSource = this.patientSelectBindingSource;
            this.patientSelectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientSelectBindingNavigator.DeleteItem = null;
            this.patientSelectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientSelectBindingNavigator.Location = new System.Drawing.Point(0, 62);
            this.patientSelectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientSelectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientSelectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientSelectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientSelectBindingNavigator.Name = "patientSelectBindingNavigator";
            this.patientSelectBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.patientSelectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientSelectBindingNavigator.Size = new System.Drawing.Size(473, 25);
            this.patientSelectBindingNavigator.TabIndex = 15;
            this.patientSelectBindingNavigator.Text = "bindingNavigator1";
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
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idLabel.Location = new System.Drawing.Point(63, 112);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 15;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientSelectBindingSource, "id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(110, 107);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(343, 26);
            this.idTextBox.TabIndex = 16;
            // 
            // patientSelectBindingSource
            // 
            this.patientSelectBindingSource.DataMember = "PatientSelect";
            this.patientSelectBindingSource.DataSource = this.dsHospital;
            // 
            // dsHospital
            // 
            this.dsHospital.DataSetName = "dsHospital";
            this.dsHospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientSelectTableAdapter
            // 
            this.patientSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Hospital.dsHospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblInfo
            // 
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(255, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfo.Size = new System.Drawing.Size(198, 93);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.Tag = "";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(19, 144);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(85, 20);
            firstNameLabel.TabIndex = 17;
            firstNameLabel.Text = "first Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientSelectBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(110, 141);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(343, 26);
            this.firstNameTextBox.TabIndex = 18;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(20, 176);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(84, 20);
            lastNameLabel.TabIndex = 18;
            lastNameLabel.Text = "last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientSelectBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(110, 173);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(343, 26);
            this.lastNameTextBox.TabIndex = 19;
            // 
            // idCardLabel
            // 
            idCardLabel.AutoSize = true;
            idCardLabel.Location = new System.Drawing.Point(41, 208);
            idCardLabel.Name = "idCardLabel";
            idCardLabel.Size = new System.Drawing.Size(63, 20);
            idCardLabel.TabIndex = 19;
            idCardLabel.Text = "id Card:";
            // 
            // idCardTextBox
            // 
            this.idCardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientSelectBindingSource, "idCard", true));
            this.idCardTextBox.Location = new System.Drawing.Point(110, 205);
            this.idCardTextBox.Name = "idCardTextBox";
            this.idCardTextBox.Size = new System.Drawing.Size(343, 26);
            this.idCardTextBox.TabIndex = 20;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(34, 240);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(70, 20);
            addressLabel.TabIndex = 20;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientSelectBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(110, 237);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(343, 26);
            this.addressTextBox.TabIndex = 21;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(35, 273);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(69, 20);
            birthdayLabel.TabIndex = 21;
            birthdayLabel.Text = "birthday:";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientSelectBindingSource, "birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(110, 269);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(343, 26);
            this.birthdayDateTimePicker.TabIndex = 22;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(37, 304);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(67, 20);
            numberLabel.TabIndex = 22;
            numberLabel.Text = "number:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientSelectBindingSource, "number", true));
            this.numberTextBox.Location = new System.Drawing.Point(110, 301);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(343, 26);
            this.numberTextBox.TabIndex = 23;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 352);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(idCardLabel);
            this.Controls.Add(this.idCardTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.patientSelectBindingNavigator);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientSelectBindingNavigator)).EndInit();
            this.patientSelectBindingNavigator.ResumeLayout(false);
            this.patientSelectBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbInsertPatient;
        private System.Windows.Forms.ToolStripButton tsbUpdatePatient;
        private System.Windows.Forms.ToolStripButton tsbDeletePatient;
        private dsHospital dsHospital;
        private System.Windows.Forms.BindingSource patientSelectBindingSource;
        private dsHospitalTableAdapters.PatientSelectTableAdapter patientSelectTableAdapter;
        private dsHospitalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientSelectBindingNavigator;
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
        private dsHospitalTableAdapters.Procedures procedures;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox idCardTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox numberTextBox;
    }
}