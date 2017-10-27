namespace Hospital
{
    partial class DoctorForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label specialityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.procedures = new Hospital.dsHospitalTableAdapters.Procedures();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.taSpeciality = new Hospital.dsHospitalTableAdapters.SpecialitySelectTableAdapter();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInsertDoctor = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateDoctor = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteDoctor = new System.Windows.Forms.ToolStripButton();
            this.dsHospital = new Hospital.dsHospital();
            this.doctorSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorSelectTableAdapter = new Hospital.dsHospitalTableAdapters.DoctorSelectTableAdapter();
            this.tableAdapterManager = new Hospital.dsHospitalTableAdapters.TableAdapterManager();
            this.doctorSelectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.specialityTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            specialityLabel = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorSelectBindingNavigator)).BeginInit();
            this.doctorSelectBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 221);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 20);
            label1.TabIndex = 19;
            label1.Text = "Speciality:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(78, 93);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 20;
            idLabel.Text = "id:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(18, 125);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(85, 20);
            firstNameLabel.TabIndex = 21;
            firstNameLabel.Text = "first Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(19, 157);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(84, 20);
            lastNameLabel.TabIndex = 22;
            lastNameLabel.Text = "last Name:";
            // 
            // specialityLabel
            // 
            specialityLabel.AutoSize = true;
            specialityLabel.Location = new System.Drawing.Point(23, 189);
            specialityLabel.Name = "specialityLabel";
            specialityLabel.Size = new System.Drawing.Size(80, 20);
            specialityLabel.TabIndex = 23;
            specialityLabel.Text = "Speciality:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(347, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // taSpeciality
            // 
            this.taSpeciality.ClearBeforeFill = true;
            // 
            // lblInfo
            // 
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(272, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfo.Size = new System.Drawing.Size(205, 93);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Tag = "";
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.toolStripSeparator1,
            this.tsbInsertDoctor,
            this.tsbUpdateDoctor,
            this.tsbDeleteDoctor});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(489, 62);
            this.tsMenu.TabIndex = 13;
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
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // tsbInsertDoctor
            // 
            this.tsbInsertDoctor.AccessibleName = "InsertDoctor";
            this.tsbInsertDoctor.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertDoctor.Image")));
            this.tsbInsertDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertDoctor.Name = "tsbInsertDoctor";
            this.tsbInsertDoctor.Size = new System.Drawing.Size(44, 59);
            this.tsbInsertDoctor.Text = "Insert";
            this.tsbInsertDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInsertDoctor.Visible = false;
            this.tsbInsertDoctor.Click += new System.EventHandler(this.tsbInsertDoctor_Click_1);
            // 
            // tsbUpdateDoctor
            // 
            this.tsbUpdateDoctor.AccessibleName = "UpdateDoctor";
            this.tsbUpdateDoctor.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdateDoctor.Image")));
            this.tsbUpdateDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateDoctor.Name = "tsbUpdateDoctor";
            this.tsbUpdateDoctor.Size = new System.Drawing.Size(49, 59);
            this.tsbUpdateDoctor.Text = "Update";
            this.tsbUpdateDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUpdateDoctor.Visible = false;
            this.tsbUpdateDoctor.Click += new System.EventHandler(this.tsbUpdateDoctor_Click_1);
            // 
            // tsbDeleteDoctor
            // 
            this.tsbDeleteDoctor.AccessibleName = "DeleteDoctor";
            this.tsbDeleteDoctor.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteDoctor.Image")));
            this.tsbDeleteDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteDoctor.Name = "tsbDeleteDoctor";
            this.tsbDeleteDoctor.Size = new System.Drawing.Size(44, 59);
            this.tsbDeleteDoctor.Text = "Delete";
            this.tsbDeleteDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDeleteDoctor.Visible = false;
            this.tsbDeleteDoctor.Click += new System.EventHandler(this.tsbDeleteDoctor_Click);
            // 
            // dsHospital
            // 
            this.dsHospital.DataSetName = "dsHospital";
            this.dsHospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorSelectBindingSource
            // 
            this.doctorSelectBindingSource.DataMember = "DoctorSelect";
            this.doctorSelectBindingSource.DataSource = this.dsHospital;
            // 
            // doctorSelectTableAdapter
            // 
            this.doctorSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Hospital.dsHospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctorSelectBindingNavigator
            // 
            this.doctorSelectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doctorSelectBindingNavigator.BindingSource = this.doctorSelectBindingSource;
            this.doctorSelectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doctorSelectBindingNavigator.DeleteItem = null;
            this.doctorSelectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.doctorSelectBindingNavigator.Location = new System.Drawing.Point(0, 62);
            this.doctorSelectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doctorSelectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doctorSelectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doctorSelectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doctorSelectBindingNavigator.Name = "doctorSelectBindingNavigator";
            this.doctorSelectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doctorSelectBindingNavigator.Size = new System.Drawing.Size(489, 25);
            this.doctorSelectBindingNavigator.TabIndex = 20;
            this.doctorSelectBindingNavigator.Text = "bindingNavigator1";
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
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorSelectBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(109, 90);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(347, 26);
            this.idTextBox.TabIndex = 21;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorSelectBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(109, 122);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(347, 26);
            this.firstNameTextBox.TabIndex = 22;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorSelectBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(109, 154);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(347, 26);
            this.lastNameTextBox.TabIndex = 23;
            // 
            // specialityTextBox
            // 
            this.specialityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorSelectBindingSource, "Speciality", true));
            this.specialityTextBox.Location = new System.Drawing.Point(109, 186);
            this.specialityTextBox.Name = "specialityTextBox";
            this.specialityTextBox.ReadOnly = true;
            this.specialityTextBox.Size = new System.Drawing.Size(347, 26);
            this.specialityTextBox.TabIndex = 24;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 298);
            this.Controls.Add(specialityLabel);
            this.Controls.Add(this.specialityTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.doctorSelectBindingNavigator);
            this.Controls.Add(label1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorSelectBindingNavigator)).EndInit();
            this.doctorSelectBindingNavigator.ResumeLayout(false);
            this.doctorSelectBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsHospitalTableAdapters.Procedures procedures;
        private System.Windows.Forms.ComboBox comboBox1;
        private dsHospitalTableAdapters.SpecialitySelectTableAdapter taSpeciality;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbInsertDoctor;
        private System.Windows.Forms.ToolStripButton tsbUpdateDoctor;
        private System.Windows.Forms.ToolStripButton tsbDeleteDoctor;
        private dsHospital dsHospital;
        private System.Windows.Forms.BindingSource doctorSelectBindingSource;
        private dsHospitalTableAdapters.DoctorSelectTableAdapter doctorSelectTableAdapter;
        private dsHospitalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator doctorSelectBindingNavigator;
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
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox specialityTextBox;

    }
}