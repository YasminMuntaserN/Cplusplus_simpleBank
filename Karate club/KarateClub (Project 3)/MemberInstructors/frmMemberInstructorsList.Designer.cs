namespace KarateClub__Project_3_.MemberInstructors
{
    partial class frmMemberInstructorsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cnsShowMembers_InstructorsDetails = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editMembersInstructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvMemberInstractors = new System.Windows.Forms.DataGridView();
            this.cnsShowMembers_InstructorsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInstractors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(7, 146);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(860, 68);
            this.lblTitle.TabIndex = 269;
            this.lblTitle.Text = "Manage  Members_Instructors";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterValue.BaseColor = System.Drawing.Color.White;
            this.txtFilterValue.BorderColor = System.Drawing.Color.Silver;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFilterValue.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.txtFilterValue.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(352, 261);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.Radius = 15;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(325, 42);
            this.txtFilterValue.TabIndex = 274;
            this.txtFilterValue.Text = "Enter to Search :";
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(46, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 273;
            this.label1.Text = "Filter By :";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Members-Instructors ID",
            "Member Name",
            "Instructor Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(187, 279);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(155, 24);
            this.cbFilterBy.TabIndex = 272;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(155, 652);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(28, 24);
            this.lblRecordsCount.TabIndex = 277;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 276;
            this.label2.Text = "# Records:";
            // 
            // cnsShowMembers_InstructorsDetails
            // 
            this.cnsShowMembers_InstructorsDetails.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cnsShowMembers_InstructorsDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripSeparator1,
            this.editMembersInstructorsToolStripMenuItem,
            this.toolStripSeparator2,
            this.cmsDelete,
            this.toolStripSeparator3,
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem,
            this.toolStripSeparator4});
            this.cnsShowMembers_InstructorsDetails.Name = "gunaContextMenuStrip1";
            this.cnsShowMembers_InstructorsDetails.RenderStyle.ArrowColor = System.Drawing.Color.White;
            this.cnsShowMembers_InstructorsDetails.RenderStyle.BorderColor = System.Drawing.Color.RosyBrown;
            this.cnsShowMembers_InstructorsDetails.RenderStyle.ColorTable = null;
            this.cnsShowMembers_InstructorsDetails.RenderStyle.RoundedEdges = true;
            this.cnsShowMembers_InstructorsDetails.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cnsShowMembers_InstructorsDetails.RenderStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.cnsShowMembers_InstructorsDetails.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cnsShowMembers_InstructorsDetails.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cnsShowMembers_InstructorsDetails.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cnsShowMembers_InstructorsDetails.Size = new System.Drawing.Size(316, 132);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.Image = global::KarateClub__Project_3_.Properties.Resources.add_user1;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.addToolStripMenuItem.Text = "Add Members_Instructors";
            this.addToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(312, 6);
            // 
            // editMembersInstructorsToolStripMenuItem
            // 
            this.editMembersInstructorsToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.editMembersInstructorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMembersInstructorsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.editMembersInstructorsToolStripMenuItem.Image = global::KarateClub__Project_3_.Properties.Resources.user__3_;
            this.editMembersInstructorsToolStripMenuItem.Name = "editMembersInstructorsToolStripMenuItem";
            this.editMembersInstructorsToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.editMembersInstructorsToolStripMenuItem.Text = "Edit Members_Instructors";
            this.editMembersInstructorsToolStripMenuItem.Click += new System.EventHandler(this.editMembersInstructorsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(312, 6);
            // 
            // cmsDelete
            // 
            this.cmsDelete.BackColor = System.Drawing.Color.DarkGray;
            this.cmsDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDelete.Image = global::KarateClub__Project_3_.Properties.Resources.bin;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(315, 26);
            this.cmsDelete.Text = "Delete Members_Instructors";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(312, 6);
            // 
            // cmsshowMembersInstructorsDetailsToolStripMenuItem
            // 
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.Image = global::KarateClub__Project_3_.Properties.Resources.presentation;
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.Name = "cmsshowMembersInstructorsDetailsToolStripMenuItem";
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.Text = "Show Members_Instructors Details";
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.Click += new System.EventHandler(this.cmsshowMembersInstructorsDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(312, 6);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.CheckedImage = null;
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Image = global::KarateClub__Project_3_.Properties.Resources.plus__1_;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAdd.LineColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(683, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.btnAdd.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnAdd.OnHoverForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.btnAdd.OnPressedColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Size = new System.Drawing.Size(121, 99);
            this.btnAdd.TabIndex = 279;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbSearch.Image = global::KarateClub__Project_3_.Properties.Resources.searching_magnifying_glass;
            this.pbSearch.Location = new System.Drawing.Point(615, 266);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(35, 30);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 275;
            this.pbSearch.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClub__Project_3_.Properties.Resources.community;
            this.pictureBox1.Location = new System.Drawing.Point(300, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 268;
            this.pictureBox1.TabStop = false;
            // 
            // dgvMemberInstractors
            // 
            this.dgvMemberInstractors.AllowUserToAddRows = false;
            this.dgvMemberInstractors.AllowUserToDeleteRows = false;
            this.dgvMemberInstractors.AllowUserToResizeRows = false;
            this.dgvMemberInstractors.BackgroundColor = System.Drawing.Color.White;
            this.dgvMemberInstractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberInstractors.ContextMenuStrip = this.cnsShowMembers_InstructorsDetails;
            this.dgvMemberInstractors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMemberInstractors.Location = new System.Drawing.Point(54, 336);
            this.dgvMemberInstractors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMemberInstractors.MultiSelect = false;
            this.dgvMemberInstractors.Name = "dgvMemberInstractors";
            this.dgvMemberInstractors.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberInstractors.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberInstractors.RowHeadersWidth = 51;
            this.dgvMemberInstractors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberInstractors.Size = new System.Drawing.Size(725, 306);
            this.dgvMemberInstractors.TabIndex = 292;
            this.dgvMemberInstractors.TabStop = false;
            // 
            // frmMemberInstructorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 706);
            this.Controls.Add(this.dgvMemberInstractors);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMemberInstructorsList";
            this.Text = "frmMemberInstructorsList";
            this.Load += new System.EventHandler(this.frmMemberInstructorsList_Load);
            this.cnsShowMembers_InstructorsDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInstractors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbSearch;
        private Guna.UI.WinForms.GunaTextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaContextMenuStrip cnsShowMembers_InstructorsDetails;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMembersInstructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsshowMembersInstructorsDetailsToolStripMenuItem;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridView dgvMemberInstractors;
    }
}