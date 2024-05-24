namespace KarateClub__Project_3_.Users
{
    partial class frmShowPermissions
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI.WinForms.GunaGradientButton();
            this.gbPermissions = new Guna.UI.WinForms.GunaGroupBox();
            this.chkManagePayments = new Guna.UI.WinForms.GunaCheckBox();
            this.chkManageBeltTests = new Guna.UI.WinForms.GunaCheckBox();
            this.chkManageSubscriptionPeriods = new Guna.UI.WinForms.GunaCheckBox();
            this.chkManageBeltRanks = new Guna.UI.WinForms.GunaCheckBox();
            this.chkManageMembersInstructors = new Guna.UI.WinForms.GunaCheckBox();
            this.chkManageUsers = new Guna.UI.WinForms.GunaCheckBox();
            this.chkManageInstructors = new Guna.UI.WinForms.GunaCheckBox();
            this.chkAllPermissions = new Guna.UI.WinForms.GunaCheckBox();
            this.chkManageMembers = new Guna.UI.WinForms.GunaCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(-17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permissions List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClub__Project_3_.Properties.Resources.shield;
            this.pictureBox1.Location = new System.Drawing.Point(156, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 158;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor1 = System.Drawing.Color.Maroon;
            this.btnClose.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::KarateClub__Project_3_.Properties.Resources.close__2_;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(156, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor1 = System.Drawing.Color.Maroon;
            this.btnClose.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 15;
            this.btnClose.Size = new System.Drawing.Size(183, 42);
            this.btnClose.TabIndex = 232;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbPermissions
            // 
            this.gbPermissions.BackColor = System.Drawing.Color.Transparent;
            this.gbPermissions.BaseColor = System.Drawing.Color.White;
            this.gbPermissions.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbPermissions.Controls.Add(this.chkManagePayments);
            this.gbPermissions.Controls.Add(this.chkManageBeltTests);
            this.gbPermissions.Controls.Add(this.chkManageSubscriptionPeriods);
            this.gbPermissions.Controls.Add(this.chkManageBeltRanks);
            this.gbPermissions.Controls.Add(this.chkManageMembersInstructors);
            this.gbPermissions.Controls.Add(this.chkManageUsers);
            this.gbPermissions.Controls.Add(this.chkManageInstructors);
            this.gbPermissions.Controls.Add(this.chkAllPermissions);
            this.gbPermissions.Controls.Add(this.chkManageMembers);
            this.gbPermissions.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissions.LineColor = System.Drawing.Color.Gainsboro;
            this.gbPermissions.Location = new System.Drawing.Point(12, 151);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(472, 262);
            this.gbPermissions.TabIndex = 233;
            this.gbPermissions.Text = "All Permissions";
            this.gbPermissions.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // chkManagePayments
            // 
            this.chkManagePayments.BaseColor = System.Drawing.Color.White;
            this.chkManagePayments.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkManagePayments.CheckedOnColor = System.Drawing.Color.Maroon;
            this.chkManagePayments.FillColor = System.Drawing.Color.White;
            this.chkManagePayments.Font = new System.Drawing.Font("Tahoma", 11.8F);
            this.chkManagePayments.Location = new System.Drawing.Point(265, 151);
            this.chkManagePayments.Name = "chkManagePayments";
            this.chkManagePayments.Size = new System.Drawing.Size(196, 28);
            this.chkManagePayments.TabIndex = 8;
            this.chkManagePayments.Tag = "128";
            this.chkManagePayments.Text = "Manage Payments";
            // 
            // chkManageBeltTests
            // 
            this.chkManageBeltTests.BaseColor = System.Drawing.Color.White;
            this.chkManageBeltTests.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkManageBeltTests.CheckedOnColor = System.Drawing.Color.Maroon;
            this.chkManageBeltTests.FillColor = System.Drawing.Color.White;
            this.chkManageBeltTests.Font = new System.Drawing.Font("Tahoma", 11.8F);
            this.chkManageBeltTests.Location = new System.Drawing.Point(265, 111);
            this.chkManageBeltTests.Name = "chkManageBeltTests";
            this.chkManageBeltTests.Size = new System.Drawing.Size(197, 28);
            this.chkManageBeltTests.TabIndex = 7;
            this.chkManageBeltTests.Tag = "64";
            this.chkManageBeltTests.Text = "Manage Belt Tests";
            // 
            // chkManageSubscriptionPeriods
            // 
            this.chkManageSubscriptionPeriods.BaseColor = System.Drawing.Color.White;
            this.chkManageSubscriptionPeriods.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkManageSubscriptionPeriods.CheckedOnColor = System.Drawing.Color.Maroon;
            this.chkManageSubscriptionPeriods.FillColor = System.Drawing.Color.White;
            this.chkManageSubscriptionPeriods.Font = new System.Drawing.Font("Tahoma", 11.8F);
            this.chkManageSubscriptionPeriods.Location = new System.Drawing.Point(15, 219);
            this.chkManageSubscriptionPeriods.Name = "chkManageSubscriptionPeriods";
            this.chkManageSubscriptionPeriods.Size = new System.Drawing.Size(289, 28);
            this.chkManageSubscriptionPeriods.TabIndex = 6;
            this.chkManageSubscriptionPeriods.Tag = "32";
            this.chkManageSubscriptionPeriods.Text = "Manage Subscription Periods";
            // 
            // chkManageBeltRanks
            // 
            this.chkManageBeltRanks.BaseColor = System.Drawing.Color.White;
            this.chkManageBeltRanks.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkManageBeltRanks.CheckedOnColor = System.Drawing.Color.Maroon;
            this.chkManageBeltRanks.FillColor = System.Drawing.Color.White;
            this.chkManageBeltRanks.Font = new System.Drawing.Font("Tahoma", 11.8F);
            this.chkManageBeltRanks.Location = new System.Drawing.Point(265, 74);
            this.chkManageBeltRanks.Name = "chkManageBeltRanks";
            this.chkManageBeltRanks.Size = new System.Drawing.Size(203, 28);
            this.chkManageBeltRanks.TabIndex = 5;
            this.chkManageBeltRanks.Tag = "8";
            this.chkManageBeltRanks.Text = "Manage Belt Ranks";
            // 
            // chkManageMembersInstructors
            // 
            this.chkManageMembersInstructors.BaseColor = System.Drawing.Color.White;
            this.chkManageMembersInstructors.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkManageMembersInstructors.CheckedOnColor = System.Drawing.Color.Maroon;
            this.chkManageMembersInstructors.FillColor = System.Drawing.Color.White;
            this.chkManageMembersInstructors.Font = new System.Drawing.Font("Tahoma", 11.8F);
            this.chkManageMembersInstructors.Location = new System.Drawing.Point(15, 185);
            this.chkManageMembersInstructors.Name = "chkManageMembersInstructors";
            this.chkManageMembersInstructors.Size = new System.Drawing.Size(293, 28);
            this.chkManageMembersInstructors.TabIndex = 4;
            this.chkManageMembersInstructors.Tag = "4";
            this.chkManageMembersInstructors.Text = "Manage Members Instructors";
            // 
            // chkManageUsers
            // 
            this.chkManageUsers.BaseColor = System.Drawing.Color.White;
            this.chkManageUsers.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkManageUsers.CheckedOnColor = System.Drawing.Color.Maroon;
            this.chkManageUsers.FillColor = System.Drawing.Color.White;
            this.chkManageUsers.Font = new System.Drawing.Font("Tahoma", 11.8F);
            this.chkManageUsers.Location = new System.Drawing.Point(15, 148);
            this.chkManageUsers.Name = "chkManageUsers";
            this.chkManageUsers.Size = new System.Drawing.Size(158, 28);
            this.chkManageUsers.TabIndex = 3;
            this.chkManageUsers.Tag = "16";
            this.chkManageUsers.Text = "Manage Users";
            // 
            // chkManageInstructors
            // 
            this.chkManageInstructors.BaseColor = System.Drawing.Color.White;
            this.chkManageInstructors.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkManageInstructors.CheckedOnColor = System.Drawing.Color.Maroon;
            this.chkManageInstructors.FillColor = System.Drawing.Color.White;
            this.chkManageInstructors.Font = new System.Drawing.Font("Tahoma", 11.8F);
            this.chkManageInstructors.Location = new System.Drawing.Point(15, 111);
            this.chkManageInstructors.Name = "chkManageInstructors";
            this.chkManageInstructors.Size = new System.Drawing.Size(206, 28);
            this.chkManageInstructors.TabIndex = 2;
            this.chkManageInstructors.Tag = "2";
            this.chkManageInstructors.Text = "Manage Instructors";
            // 
            // chkAllPermissions
            // 
            this.chkAllPermissions.BaseColor = System.Drawing.Color.White;
            this.chkAllPermissions.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkAllPermissions.CheckedOnColor = System.Drawing.Color.Maroon;
            this.chkAllPermissions.FillColor = System.Drawing.Color.White;
            this.chkAllPermissions.Font = new System.Drawing.Font("Tahoma", 11.8F);
            this.chkAllPermissions.Location = new System.Drawing.Point(15, 37);
            this.chkAllPermissions.Name = "chkAllPermissions";
            this.chkAllPermissions.Size = new System.Drawing.Size(54, 28);
            this.chkAllPermissions.TabIndex = 1;
            this.chkAllPermissions.Tag = "-1";
            this.chkAllPermissions.Text = "All";
            this.chkAllPermissions.CheckedChanged += new System.EventHandler(this.chkAllPermissions_CheckedChanged);
            // 
            // chkManageMembers
            // 
            this.chkManageMembers.BaseColor = System.Drawing.Color.White;
            this.chkManageMembers.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkManageMembers.CheckedOnColor = System.Drawing.Color.Maroon;
            this.chkManageMembers.FillColor = System.Drawing.Color.White;
            this.chkManageMembers.Font = new System.Drawing.Font("Tahoma", 11.8F);
            this.chkManageMembers.Location = new System.Drawing.Point(15, 74);
            this.chkManageMembers.Name = "chkManageMembers";
            this.chkManageMembers.Size = new System.Drawing.Size(190, 28);
            this.chkManageMembers.TabIndex = 0;
            this.chkManageMembers.Tag = "1";
            this.chkManageMembers.Text = "Manage Members";
            // 
            // frmShowPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 481);
            this.Controls.Add(this.gbPermissions);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPermissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmShowPermissions";
            this.Load += new System.EventHandler(this.frmShowPermissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaGradientButton btnClose;
        private  Guna.UI.WinForms.GunaGroupBox gbPermissions;
        private Guna.UI.WinForms.GunaCheckBox chkManageMembers;
        private  Guna.UI.WinForms.GunaCheckBox chkAllPermissions;
        private Guna.UI.WinForms.GunaCheckBox chkManageInstructors;
        private Guna.UI.WinForms.GunaCheckBox chkManageUsers;
        private Guna.UI.WinForms.GunaCheckBox chkManageSubscriptionPeriods;
        private Guna.UI.WinForms.GunaCheckBox chkManageBeltRanks;
        private Guna.UI.WinForms.GunaCheckBox chkManageMembersInstructors;
        private Guna.UI.WinForms.GunaCheckBox chkManagePayments;
        private Guna.UI.WinForms.GunaCheckBox chkManageBeltTests;
    }
}