using Guna.UI.WinForms;
using KarateClub__Project_3_.Belt_Rank;
using KarateClub__Project_3_.Belt_Tests;
using KarateClub__Project_3_.Home;
using KarateClub__Project_3_.Instructors;
using KarateClub__Project_3_.MemberInstructors;
using KarateClub__Project_3_.Subscription_Period;
using KarateClub__Project_3_.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub__Project_3_
{
    public partial class frmMain : Form
    {
        private GunaAdvenceButton _currentButton;
        private Form _activeForm;
        public frmMain()
        {
            InitializeComponent();
        }
        private void _ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != (GunaAdvenceButton)btnSender)
                {
                    _DisableMenuButton();
                    _currentButton = (GunaAdvenceButton)btnSender;
                }
            }
        }

        private void _DisableMenuButton()
        {
            GunaAdvenceButton GunaAdvenceButton = new GunaAdvenceButton();

            foreach (Control previousBtn in Disaplypanel.Controls)
            {
                if (previousBtn.GetType() == typeof(GunaAdvenceButton))
                {
                    GunaAdvenceButton = (GunaAdvenceButton)previousBtn;
                }
            }
        }

        public async void OpenChildFormAsync(Form childForm, object btnSender)
        {
            await Task.Delay(100);

            _activeForm?.Close();

            _ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Disaplypanel.Controls.Add(childForm);
            Disaplypanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public  void LoadSubClass(Form childForm)
        {
            childForm.TopLevel = false;
            Disaplypanel.Controls.Add(childForm);
            childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubscriptionPeriods_Click(object sender, EventArgs e)
        {
            OpenChildFormAsync(new frmMemberInstructorsList(), sender);
        }

        private void btnMembers_Instructors_Click(object sender, EventArgs e)
        {
            OpenChildFormAsync(new frmMemberInstructorsList(), sender);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            OpenChildFormAsync(new frmMemberList(), sender);
        }

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            OpenChildFormAsync(new frmInstructorList(), sender);    
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildFormAsync(new frmListUsers(), sender);
        }

        private void btnBeltRanks_Click(object sender, EventArgs e)
        {
            OpenChildFormAsync(new frmListBeltRank(), sender);
        }

        private void btnBeltTests_Click(object sender, EventArgs e)
        {
            OpenChildFormAsync(new frmListBeltTests(), sender);
        }
    }
}
