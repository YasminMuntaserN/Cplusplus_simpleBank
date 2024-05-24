using Karate_Bussiness;
using KarateClub__Project_3_.Global_Classes;
using KarateClub__Project_3_.Person;
using KarateClub__Project_3_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace KarateClub__Project_3_.MemberInstructors
{
    public partial class frmAddEditMemberInstructors : Form
    {
        // Fill Members , Instructors Info
        private List<int> _AllMemberIDList;
        private List<int> _AllInstructorIDList;

        private int _MembersCount =0;
        private int _InstructorsCount = 0;


        public frmAddEditMemberInstructors()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditMemberInstructors(int MemberInstructorID)
        {
            _MemberInstructorID=MemberInstructorID;
            InitializeComponent();
            _Mode=enMode.Update;
        }

        public frmAddEditMemberInstructors(int MemberInstructorID , string title ="Show Details")
        {
            _MemberInstructorID = MemberInstructorID;
            InitializeComponent();
            _Mode = enMode.ShowDetails;
        }

        private List<int> LoadAllMembersID()
        {
            List<int> list = new List<int>();
            DataTable dt = clsMember.AllMembers();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(clsValidation.ValidateNumbers(dt.Rows[i]["MemberID"].ToString()));
            }
            return list;
        }

        private void LoadMembersInfo(int? MemberID)
        {
            clsMember Member = clsMember.Find(MemberID);
            if (Member.ImagePath == "")
            {
                pbDoctorImage.Image = (Member.Gender == 0) ? Resources.judo__1_ : Resources.judo__2_;
            }
            else
            {
                pbDoctorImage.ImageLocation = Member.ImagePath;
            }
            lblMemberID.Text = Member.MemberID.ToString();
            lblMemberName.Text= Member.Name;
            lblActive.Text = (Member.IsActive) ? "True" : "False";
        }

        private List<int> LoadAllInstructorID()
        {
            List<int> list = new List<int>();
            DataTable dt = clsInstructor.AllInstructors();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(clsValidation.ValidateNumbers(dt.Rows[i]["InstructorID"].ToString()));
            }
            return list;
        }

        private void LoadInstructorsInfo(int? InstructorID)
        {
            clsInstructor Instructor = clsInstructor.FindByInstructorID(InstructorID);
            if (Instructor.ImagePath == "")
            {
                pbDoctorImage.Image = (Instructor.Gender == 0) ? Resources.man : Resources.woman;
            }
            else
            {
                pbDoctorImage.ImageLocation = Instructor.ImagePath;
            }
            lblInstructorID.Text= Instructor.InstructorID.ToString();
            lblInstructorName.Text= Instructor.Name;
            lblQualification.Text= Instructor.Qualification;    
        }

       
        // save MemberInstructor Data
        enum enMode { AddNew = 0, Update = 1 ,ShowDetails =2};

        private enMode _Mode;

        private clsMemberInstructor _MemberInstructor;

        private int? _MemberInstructorID = null;

        private void _ResetTitles()
        {
            switch (_Mode) {
                case enMode.AddNew:
            
                lblTitle.Text = "Add New Member_Instructor";
                this.Text = "Add New Member_Instructor";
                _MemberInstructor = new clsMemberInstructor();
                    break;
            
            case enMode.Update:
                this.Text = "Update Member_Instructor";
                lblTitle.Text = "Update Member_Instructor";
                    break;

            case enMode.ShowDetails:
                 this.Text = "  Member_Instructor Details";
                 lblTitle.Text = "  Member_Instructor Details";
                    break;

            }
        }

        public void LoadData()
        {
            _MemberInstructor = clsMemberInstructor.Find(_MemberInstructorID);

            if (_MemberInstructorID == null)
            {
                MessageBox.Show("No Member_Instructors with ID = " + _MemberInstructorID, "Member_Instructor Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }

            LoadMembersInfo(_MemberInstructor.MemberID);

            LoadInstructorsInfo(_MemberInstructor.InstructorID);

            lblMemberInstructorsID.Text = _MemberInstructor.MemberInstructorID.ToString();

            dtpDate.Value= _MemberInstructor.AssignDate;

        }

        private void _ShowDetails()
        {
            _MemberInstructor = clsMemberInstructor.Find(_MemberInstructorID);

            if (_MemberInstructorID == null)
            {
                MessageBox.Show("No Member_Instructors with ID = " + _MemberInstructorID, "Member_Instructor Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }

            LoadMembersInfo(_MemberInstructor.MemberID);

            LoadInstructorsInfo(_MemberInstructor.InstructorID);

            lblMemberInstructorsID.Text = _MemberInstructor.MemberInstructorID.ToString();

            dtpDate.Value = _MemberInstructor.AssignDate;
            btnSave.Visible = false;
            panelSearch.Visible = false;
            nextMember.Visible = false;
            nextInstructors.Visible = false;

        }

        private void _FillData()
        {
            _MemberInstructor.MemberID = clsValidation.ValidateNumbers(lblMemberID.Text);

            _MemberInstructor.InstructorID = clsValidation.ValidateNumbers(lblInstructorID.Text);

            _MemberInstructor.AssignDate = dtpDate.Value;

        }

        private void _SaveData()
        {
            if (_MemberInstructor.Save())
            {
                MessageBox.Show("Member_Instructor Data Saved Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                lblMemberInstructorsID.Text = _MemberInstructor.MemberInstructorID.ToString();
                lblTitle.Text = "Update Member_Instructor Info";
                this._Mode = enMode.Update;

                _MemberInstructor.Mode = clsMemberInstructor.enMode.Update;
            }

            else
            {
                MessageBox.Show("Member_Instructor Saved Failed.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool _CheckForCorrectData()
        {
            if (lblMemberID.Text == "[????]")
            {
                MessageBox.Show("Select Member first!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (lblInstructorID.Text == "[????]")
            {
                MessageBox.Show("Select Instructor first!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if(clsMemberInstructor.DoesMemberTrainByInstructor(
                clsValidation.ValidateNumbers(lblMemberID.Text), clsValidation.ValidateNumbers(lblInstructorID.Text)))
            {
                MessageBox.Show("This Instructor has trained this member before!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void frmAddEditMemberInstructors_Load(object sender, EventArgs e)
        {
            _ResetTitles();
            if(_Mode ==enMode.Update) LoadData();
            if (_Mode == enMode.ShowDetails) _ShowDetails();

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckForCorrectData()) return;
            _FillData();
            _SaveData();
        }

        private void btnListMemberInstructors_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInstructorID.Text.Trim()))
            {
                errorProvider1.SetError(txtInstructorID, "Enter Instructor ID First !");
                return;
            }
            else
            {
                int InstructorID = clsValidation.ValidateNumbers(txtInstructorID.Text.Trim());
                if (InstructorID == -1)
                {
                    errorProvider1.SetError(txtInstructorID, "Invalid Instructor ID  !");
                    return;
                }
                if (clsInstructor.Exist(InstructorID))
                {
                    frmTrainedMembersByInstructorList frm = new frmTrainedMembersByInstructorList(InstructorID);
                    frm.ShowDialog();
                }
            }
        }

        private void nextInstructors_Click_1(object sender, EventArgs e)
        {
            _AllInstructorIDList = LoadAllInstructorID();
            if (_InstructorsCount > _AllInstructorIDList.Count - 1)
            {
                _InstructorsCount = 0;
            }
            LoadInstructorsInfo(_AllInstructorIDList[_InstructorsCount]);
            _InstructorsCount++;
        }

        private void nextMember_Click_1(object sender, EventArgs e)
        {
            _AllMemberIDList = LoadAllMembersID();
            if (_MembersCount > _AllMemberIDList.Count - 1)
            {
                _MembersCount = 0;
            }
            LoadMembersInfo(_AllMemberIDList[_MembersCount]);
            _MembersCount++;
        }


    }
}
