using Karate_Bussiness;
using KarateClub__Project_3_.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub__Project_3_.Subscription_Period
{
    public partial class frmAddEditSubscriptionPeriod : Form
    {
        enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private clsSubscriptionPeriod _SubscriptionPeriod;

        private int? _SubscriptionPeriodID = null;

        public frmAddEditSubscriptionPeriod()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;  
        }

        public frmAddEditSubscriptionPeriod(int SubscriptionPeriodID)
        {
            _SubscriptionPeriodID = SubscriptionPeriodID;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Subscription Period";
                this.Text = "Add New Subscription Period";
                _SubscriptionPeriod = new clsSubscriptionPeriod();
            }
            else
            {
                this.Text = "Update Subscription Period";
                lblTitle.Text = "Update Subscription Period";
            }
        }

        public void LoadData()
        {
            _SubscriptionPeriod = clsSubscriptionPeriod.FindByPeriodID(_SubscriptionPeriodID);

            if (_SubscriptionPeriodID == null)
            {
                MessageBox.Show("No Subscription Period with ID = " + _SubscriptionPeriodID, "Subscription Period Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }

            lblMemberID.Text = _SubscriptionPeriod.MemberID.ToString();

            ctrlMemberCardWithFilter1.FilterEnabled = false;

            ctrlMemberCardWithFilter1.LoadPersonInfo(_SubscriptionPeriod.MemberInfo.PersonID);

            lblPaymentID.Text = _SubscriptionPeriod.PaymentID.ToString();

            lblFees.Text = _SubscriptionPeriod.MemberInfo.LastBeltRankInfo.TestFees.ToString();

            cbIsPaid.Checked = _SubscriptionPeriod.IsPaid;

            dtpStartDate.Text = _SubscriptionPeriod.StartDate.ToShortDateString();

            dtpEndDate.Text = _SubscriptionPeriod.EndDate.ToShortDateString();

            btnNext.Enabled = true;
            tpSubscriptionPeriodInfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private bool _Paid()
        {
            clsPayments payment= clsPayments.PayForSubscriptionPeriod(_SubscriptionPeriod);
            if (cbIsPaid.Checked)
            {
                if (payment.Save())
                {
                    lblPaymentID.Text = payment.PaymentID.ToString();
                    lblFees.Text=payment.Amount.ToString();
                    payment.Mode = clsPayments.enMode.Update;
                    _SubscriptionPeriod.PaymentID = payment.PaymentID;
                    _SubscriptionPeriod.Fees = payment.Amount;
                    return true;
                }

                else
                {
                    MessageBox.Show("payment Saved Failed.", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        private void _FillData()
        {
            _SubscriptionPeriod.MemberID = ctrlMemberCardWithFilter1.MemberInfo.MemberID;
            _SubscriptionPeriod.IsPaid = _Paid();
            _SubscriptionPeriod.StartDate = dtpStartDate.Value;
            _SubscriptionPeriod.EndDate = dtpEndDate.Value;

        }

        private void _SaveData()
        {
            if (_SubscriptionPeriod.Save())
            {
                MessageBox.Show("Subscription Period Data Saved Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPeriodID.Text = _SubscriptionPeriod.PeriodID.ToString();
                lblMemberID.Text = _SubscriptionPeriod.MemberID.ToString();
                lblTitle.Text = "Update Subscription Period Info";
                this._Mode = enMode.Update;
                _SubscriptionPeriod.Mode = clsSubscriptionPeriod.enMode.Update;
            }

            else
            {
                MessageBox.Show("Subscription Period Saved Failed.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                MessageBox.Show("The end date should be after the start date!", "Date Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillData();
            _SaveData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcMember.SelectedTab = tcMember.TabPages["tpSubscriptionPeriodInfo"];
        }

        private void ctrlMemberCardWithFilter1_OnMemberSelectedEvent(object sender, Member.User_Control.ctrlMemberCardWithFilter.SelectMemberEventArgs e)
        {
            //بدنا نحط شرط نتاكد من خلالو انو هل هاد الشخص عندو فترة اشتراك من قبل اذا كان عندو لازم يخلص وقت الاشتراك قبل اضافة اشترالك جديد
            if (ctrlMemberCardWithFilter1.MemberInfo.HasMemberSubscriptionPeriod )
            {
                if (clsSubscriptionPeriod.FindByMemberID(ctrlMemberCardWithFilter1.MemberInfo.MemberID).EndDate > DateTime.Now)
                {
                    MessageBox.Show("This Member has already been registered as a Member in this system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnNext.Enabled = false;
                    tpSubscriptionPeriodInfo.Enabled = false;
                    btnSave.Enabled = false;
                    return;
                }
            }
            btnNext.Enabled = true;
            tpSubscriptionPeriodInfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private void frmAddEditSubscriptionPeriod_Load(object sender, EventArgs e)
        {
            tpSubscriptionPeriodInfo.Enabled = false;
            _ResetTitles();
            if (_Mode == enMode.Update)
            {
                LoadData();
            }
        }
    }
}
