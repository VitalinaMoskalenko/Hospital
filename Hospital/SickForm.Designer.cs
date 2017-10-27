namespace Hospital
{
    partial class SickForm
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
            System.Windows.Forms.Label discriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SickForm));
            this.lblInfo = new System.Windows.Forms.Label();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInsertSick = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateSick = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteSick = new System.Windows.Forms.ToolStripButton();
            this.dsHospital = new Hospital.dsHospital();
            this.sickSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sickSelectTableAdapter = new Hospital.dsHospitalTableAdapters.SickSelectTableAdapter();
            this.tableAdapterManager = new Hospital.dsHospitalTableAdapters.TableAdapterManager();
            this.sickSelectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.discriptionTextBox = new System.Windows.Forms.TextBox();
            this.procedures = new Hospital.dsHospitalTableAdapters.Procedures();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            discriptionLabel = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sickSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sickSelectBindingNavigator)).BeginInit();
            this.sickSelectBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(68, 108);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 14;
            idLabel.Text = "id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(40, 140);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(53, 20);
            nameLabel.TabIndex = 15;
            nameLabel.Text = "name:";
            // 
            // discriptionLabel
            // 
            discriptionLabel.AutoSize = true;
            discriptionLabel.Location = new System.Drawing.Point(9, 212);
            discriptionLabel.Name = "discriptionLabel";
            discriptionLabel.Size = new System.Drawing.Size(84, 20);
            discriptionLabel.TabIndex = 16;
            discriptionLabel.Text = "discription:";
            // 
            // lblInfo
            // 
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(238, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfo.Size = new System.Drawing.Size(205, 93);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Tag = "";
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.toolStripSeparator1,
            this.tsbInsertSick,
            this.tsbUpdateSick,
            this.tsbDeleteSick});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsMenu.Size = new System.Drawing.Size(463, 62);
            this.tsMenu.TabIndex = 12;
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
            // tsbInsertSick
            // 
            this.tsbInsertSick.AccessibleName = "InsertSick";
            this.tsbInsertSick.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertSick.Image")));
            this.tsbInsertSick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertSick.Name = "tsbInsertSick";
            this.tsbInsertSick.Size = new System.Drawing.Size(44, 59);
            this.tsbInsertSick.Text = "Insert";
            this.tsbInsertSick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInsertSick.Visible = false;
            this.tsbInsertSick.Click += new System.EventHandler(this.tsbInsertSick_Click);
            // 
            // tsbUpdateSick
            // 
            this.tsbUpdateSick.AccessibleName = "UpdateSick";
            this.tsbUpdateSick.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdateSick.Image")));
            this.tsbUpdateSick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateSick.Name = "tsbUpdateSick";
            this.tsbUpdateSick.Size = new System.Drawing.Size(49, 59);
            this.tsbUpdateSick.Text = "Update";
            this.tsbUpdateSick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUpdateSick.Visible = false;
            this.tsbUpdateSick.Click += new System.EventHandler(this.tsbUpdateSick_Click);
            // 
            // tsbDeleteSick
            // 
            this.tsbDeleteSick.AccessibleName = "DeleteSick";
            this.tsbDeleteSick.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteSick.Image")));
            this.tsbDeleteSick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteSick.Name = "tsbDeleteSick";
            this.tsbDeleteSick.Size = new System.Drawing.Size(44, 59);
            this.tsbDeleteSick.Text = "Delete";
            this.tsbDeleteSick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDeleteSick.Visible = false;
            this.tsbDeleteSick.Click += new System.EventHandler(this.tsbDeleteSick_Click);
            // 
            // dsHospital
            // 
            this.dsHospital.DataSetName = "dsHospital";
            this.dsHospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sickSelectBindingSource
            // 
            this.sickSelectBindingSource.DataMember = "SickSelect";
            this.sickSelectBindingSource.DataSource = this.dsHospital;
            // 
            // sickSelectTableAdapter
            // 
            this.sickSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Hospital.dsHospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sickSelectBindingNavigator
            // 
            this.sickSelectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sickSelectBindingNavigator.BindingSource = this.sickSelectBindingSource;
            this.sickSelectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sickSelectBindingNavigator.DeleteItem = null;
            this.sickSelectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sickSelectBindingNavigator.Location = new System.Drawing.Point(0, 62);
            this.sickSelectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sickSelectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sickSelectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sickSelectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sickSelectBindingNavigator.Name = "sickSelectBindingNavigator";
            this.sickSelectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sickSelectBindingNavigator.Size = new System.Drawing.Size(463, 25);
            this.sickSelectBindingNavigator.TabIndex = 14;
            this.sickSelectBindingNavigator.Text = "bindingNavigator1";
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
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sickSelectBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(99, 105);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(344, 26);
            this.idTextBox.TabIndex = 15;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sickSelectBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(99, 137);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(344, 26);
            this.nameTextBox.TabIndex = 16;
            // 
            // discriptionTextBox
            // 
            this.discriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sickSelectBindingSource, "discription", true));
            this.discriptionTextBox.Location = new System.Drawing.Point(99, 169);
            this.discriptionTextBox.Multiline = true;
            this.discriptionTextBox.Name = "discriptionTextBox";
            this.discriptionTextBox.Size = new System.Drawing.Size(344, 97);
            this.discriptionTextBox.TabIndex = 17;
            // 
            // SickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 278);
            this.Controls.Add(discriptionLabel);
            this.Controls.Add(this.discriptionTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.sickSelectBindingNavigator);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SickForm";
            this.Text = "SickForm";
            this.Load += new System.EventHandler(this.SickForm_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sickSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sickSelectBindingNavigator)).EndInit();
            this.sickSelectBindingNavigator.ResumeLayout(false);
            this.sickSelectBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbInsertSick;
        private System.Windows.Forms.ToolStripButton tsbUpdateSick;
        private System.Windows.Forms.ToolStripButton tsbDeleteSick;
        private dsHospital dsHospital;
        private System.Windows.Forms.BindingSource sickSelectBindingSource;
        private dsHospitalTableAdapters.SickSelectTableAdapter sickSelectTableAdapter;
        private dsHospitalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sickSelectBindingNavigator;
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
        private System.Windows.Forms.TextBox discriptionTextBox;
        private dsHospitalTableAdapters.Procedures procedures;
    }
}