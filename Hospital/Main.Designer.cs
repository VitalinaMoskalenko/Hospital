namespace Hospital
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDoctor = new System.Windows.Forms.ToolStripButton();
            this.tsbPatient = new System.Windows.Forms.ToolStripButton();
            this.tsbVisit = new System.Windows.Forms.ToolStripButton();
            this.tsbHistory = new System.Windows.Forms.ToolStripButton();
            this.tsbSpeciality = new System.Windows.Forms.ToolStripButton();
            this.tsbSick = new System.Windows.Forms.ToolStripButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.toolStripSeparator1,
            this.tsbDoctor,
            this.tsbPatient,
            this.tsbVisit,
            this.tsbHistory,
            this.tsbSpeciality,
            this.tsbSick});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(654, 62);
            this.tsMenu.TabIndex = 0;
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
            // tsbDoctor
            // 
            this.tsbDoctor.AccessibleName = "Doctor";
            this.tsbDoctor.Image = ((System.Drawing.Image)(resources.GetObject("tsbDoctor.Image")));
            this.tsbDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDoctor.Name = "tsbDoctor";
            this.tsbDoctor.Size = new System.Drawing.Size(47, 59);
            this.tsbDoctor.Text = "Doctor";
            this.tsbDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDoctor.Visible = false;
            this.tsbDoctor.Click += new System.EventHandler(this.tsbDoctor_Click);
            // 
            // tsbPatient
            // 
            this.tsbPatient.AccessibleName = "Patient";
            this.tsbPatient.Image = ((System.Drawing.Image)(resources.GetObject("tsbPatient.Image")));
            this.tsbPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPatient.Name = "tsbPatient";
            this.tsbPatient.Size = new System.Drawing.Size(48, 59);
            this.tsbPatient.Text = "Patient";
            this.tsbPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPatient.Visible = false;
            this.tsbPatient.Click += new System.EventHandler(this.tsbPatient_Click);
            // 
            // tsbVisit
            // 
            this.tsbVisit.AccessibleName = "Visit";
            this.tsbVisit.Image = ((System.Drawing.Image)(resources.GetObject("tsbVisit.Image")));
            this.tsbVisit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVisit.Name = "tsbVisit";
            this.tsbVisit.Size = new System.Drawing.Size(44, 59);
            this.tsbVisit.Text = "Visit";
            this.tsbVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbVisit.Visible = false;
            this.tsbVisit.Click += new System.EventHandler(this.tsbVisit_Click);
            // 
            // tsbHistory
            // 
            this.tsbHistory.AccessibleName = "History";
            this.tsbHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsbHistory.Image")));
            this.tsbHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHistory.Name = "tsbHistory";
            this.tsbHistory.Size = new System.Drawing.Size(49, 59);
            this.tsbHistory.Text = "History";
            this.tsbHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbHistory.Visible = false;
            this.tsbHistory.Click += new System.EventHandler(this.tsbHistory_Click);
            // 
            // tsbSpeciality
            // 
            this.tsbSpeciality.AccessibleName = "Speciality";
            this.tsbSpeciality.Image = ((System.Drawing.Image)(resources.GetObject("tsbSpeciality.Image")));
            this.tsbSpeciality.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSpeciality.Name = "tsbSpeciality";
            this.tsbSpeciality.Size = new System.Drawing.Size(61, 59);
            this.tsbSpeciality.Text = "Speciality";
            this.tsbSpeciality.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSpeciality.Visible = false;
            this.tsbSpeciality.Click += new System.EventHandler(this.tsbSpeciality_Click);
            // 
            // tsbSick
            // 
            this.tsbSick.AccessibleName = "Sick";
            this.tsbSick.Image = ((System.Drawing.Image)(resources.GetObject("tsbSick.Image")));
            this.tsbSick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSick.Name = "tsbSick";
            this.tsbSick.Size = new System.Drawing.Size(44, 59);
            this.tsbSick.Text = "Sick";
            this.tsbSick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSick.Visible = false;
            this.tsbSick.Click += new System.EventHandler(this.tsbSick_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(407, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfo.Size = new System.Drawing.Size(235, 58);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Tag = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 299);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tsMenu);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPatient;
        private System.Windows.Forms.ToolStripButton tsbVisit;
        private System.Windows.Forms.ToolStripButton tsbHistory;
        private System.Windows.Forms.ToolStripButton tsbSpeciality;
        private System.Windows.Forms.ToolStripButton tsbSick;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolStripButton tsbDoctor;



    }
}