namespace Hospital
{
    partial class SpecialityForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label discribeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialityForm));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInsertSpeciality = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateSpeciality = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteSpeciality = new System.Windows.Forms.ToolStripButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.specialitySelectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.discribeTextBox = new System.Windows.Forms.TextBox();
            this.specialitySelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHospital = new Hospital.dsHospital();
            this.specialitySelectTableAdapter = new Hospital.dsHospitalTableAdapters.SpecialitySelectTableAdapter();
            this.tableAdapterManager = new Hospital.dsHospitalTableAdapters.TableAdapterManager();
            this.procedures = new Hospital.dsHospitalTableAdapters.Procedures();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            discribeLabel = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitySelectBindingNavigator)).BeginInit();
            this.specialitySelectBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitySelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(64, 108);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 12;
            idLabel.Text = "id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(36, 140);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(53, 20);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "name:";
            // 
            // discribeLabel
            // 
            discribeLabel.AutoSize = true;
            discribeLabel.Location = new System.Drawing.Point(22, 214);
            discribeLabel.Name = "discribeLabel";
            discribeLabel.Size = new System.Drawing.Size(67, 20);
            discribeLabel.TabIndex = 14;
            discribeLabel.Text = "discribe:";
            discribeLabel.Click += new System.EventHandler(this.discribeLabel_Click);
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.toolStripSeparator1,
            this.tsbInsertSpeciality,
            this.tsbUpdateSpeciality,
            this.tsbDeleteSpeciality});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsMenu.Size = new System.Drawing.Size(463, 62);
            this.tsMenu.TabIndex = 10;
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
            // tsbInsertSpeciality
            // 
            this.tsbInsertSpeciality.AccessibleName = "InsertSpeciality";
            this.tsbInsertSpeciality.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertSpeciality.Image")));
            this.tsbInsertSpeciality.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertSpeciality.Name = "tsbInsertSpeciality";
            this.tsbInsertSpeciality.Size = new System.Drawing.Size(44, 59);
            this.tsbInsertSpeciality.Text = "Insert";
            this.tsbInsertSpeciality.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInsertSpeciality.Visible = false;
            this.tsbInsertSpeciality.Click += new System.EventHandler(this.tsbInsertSpeciality_Click);
            // 
            // tsbUpdateSpeciality
            // 
            this.tsbUpdateSpeciality.AccessibleName = "UpdateSpeciality";
            this.tsbUpdateSpeciality.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdateSpeciality.Image")));
            this.tsbUpdateSpeciality.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateSpeciality.Name = "tsbUpdateSpeciality";
            this.tsbUpdateSpeciality.Size = new System.Drawing.Size(49, 59);
            this.tsbUpdateSpeciality.Text = "Update";
            this.tsbUpdateSpeciality.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUpdateSpeciality.Visible = false;
            this.tsbUpdateSpeciality.Click += new System.EventHandler(this.tsbUpdateSpeciality_Click);
            // 
            // tsbDeleteSpeciality
            // 
            this.tsbDeleteSpeciality.AccessibleName = "DeleteSpeciality";
            this.tsbDeleteSpeciality.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteSpeciality.Image")));
            this.tsbDeleteSpeciality.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteSpeciality.Name = "tsbDeleteSpeciality";
            this.tsbDeleteSpeciality.Size = new System.Drawing.Size(44, 59);
            this.tsbDeleteSpeciality.Text = "Delete";
            this.tsbDeleteSpeciality.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDeleteSpeciality.Visible = false;
            this.tsbDeleteSpeciality.Click += new System.EventHandler(this.tsbDeleteSpeciality_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(238, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfo.Size = new System.Drawing.Size(205, 93);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Tag = "";
            // 
            // specialitySelectBindingNavigator
            // 
            this.specialitySelectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.specialitySelectBindingNavigator.BindingSource = this.specialitySelectBindingSource;
            this.specialitySelectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.specialitySelectBindingNavigator.DeleteItem = null;
            this.specialitySelectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.specialitySelectBindingNavigator.Location = new System.Drawing.Point(0, 62);
            this.specialitySelectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.specialitySelectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.specialitySelectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.specialitySelectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.specialitySelectBindingNavigator.Name = "specialitySelectBindingNavigator";
            this.specialitySelectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.specialitySelectBindingNavigator.Size = new System.Drawing.Size(463, 25);
            this.specialitySelectBindingNavigator.TabIndex = 12;
            this.specialitySelectBindingNavigator.Text = "bindingNavigator1";
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
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialitySelectBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(95, 105);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(348, 26);
            this.idTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialitySelectBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(95, 137);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(348, 26);
            this.nameTextBox.TabIndex = 14;
            // 
            // discribeTextBox
            // 
            this.discribeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialitySelectBindingSource, "discribe", true));
            this.discribeTextBox.Location = new System.Drawing.Point(95, 169);
            this.discribeTextBox.Multiline = true;
            this.discribeTextBox.Name = "discribeTextBox";
            this.discribeTextBox.Size = new System.Drawing.Size(348, 97);
            this.discribeTextBox.TabIndex = 15;
            this.discribeTextBox.TextChanged += new System.EventHandler(this.discribeTextBox_TextChanged);
            // 
            // specialitySelectBindingSource
            // 
            this.specialitySelectBindingSource.DataMember = "SpecialitySelect";
            this.specialitySelectBindingSource.DataSource = this.dsHospital;
            // 
            // dsHospital
            // 
            this.dsHospital.DataSetName = "dsHospital";
            this.dsHospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialitySelectTableAdapter
            // 
            this.specialitySelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Hospital.dsHospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SpecialityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 278);
            this.Controls.Add(discribeLabel);
            this.Controls.Add(this.discribeTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.specialitySelectBindingNavigator);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SpecialityForm";
            this.Text = "SpecialityFormcs";
            this.Load += new System.EventHandler(this.SpecialityFormcs_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitySelectBindingNavigator)).EndInit();
            this.specialitySelectBindingNavigator.ResumeLayout(false);
            this.specialitySelectBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitySelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbInsertSpeciality;
        private System.Windows.Forms.ToolStripButton tsbUpdateSpeciality;
        private System.Windows.Forms.ToolStripButton tsbDeleteSpeciality;
        private System.Windows.Forms.Label lblInfo;
        private dsHospital dsHospital;
        private System.Windows.Forms.BindingSource specialitySelectBindingSource;
        private dsHospitalTableAdapters.SpecialitySelectTableAdapter specialitySelectTableAdapter;
        private dsHospitalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator specialitySelectBindingNavigator;
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
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox discribeTextBox;
        private dsHospitalTableAdapters.Procedures procedures;
    }
}