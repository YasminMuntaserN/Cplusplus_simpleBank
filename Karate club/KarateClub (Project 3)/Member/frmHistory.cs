using Karate_Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub__Project_3_.Member
{
    public partial class frmHistory : Form
    {
        enum enOperation { Periods = 0, Payments = 1, Tests = 2 }

        private DataTable _dtList;
        private int? _ID;
        private enOperation _OperationName;

        public frmHistory(int? ID, string OperationName)
        {
            _OperationName = _setOperationName(OperationName);
            InitializeComponent();
            _ID = ID;
        }

        private enOperation _setOperationName(string OperationName)
        {
            switch (OperationName)
            {
                case "Periods": return enOperation.Periods;
                case "Payments": return enOperation.Payments;
                case "Tests": return enOperation.Tests;
            }
            return enOperation.Periods;
        }

        private void _Periods()
        {
            lblTitle.Text = "Subscription Periods History";
            clsSubscriptionPeriod period = clsSubscriptionPeriod.FindByMemberID(_ID);
            _dtList = clsSubscriptionPeriod.AllSubscriptionPeriods(period.MemberInfo.Name);
            dataGridView1.DataSource = _dtList;
        }

        private void _Tests()
        {
            lblTitle.Text = "Member Tests History";
            _dtList = clsMember.AllTests(_ID);
            dataGridView1.DataSource = _dtList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSubscriptionPeriodHistory_Load(object sender, EventArgs e)
        {
            ctrlMemberCard1.LoadMemberInfo(_ID);
            switch (_OperationName)
            {
                case enOperation.Periods:
                    _Periods(); break;
                case enOperation.Tests:
                    _Tests(); break;
            }
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPayments payment = new clsPayments();
            clsSubscriptionPeriod _SubscriptionPeriod = clsSubscriptionPeriod.FindByMemberID(_ID);
            payment.Amount = _SubscriptionPeriod.MemberInfo.LastBeltRankInfo.TestFees;
            payment.MemberID = _SubscriptionPeriod.MemberID;
            payment.Date = DateTime.Now;

            if (payment.Save())
            {
                payment.Mode = clsPayments.enMode.Update;
                _SubscriptionPeriod.PaymentID = payment.PaymentID;
                _SubscriptionPeriod.Fees = payment.Amount;
            }

            else
            {
                MessageBox.Show("payment Saved Failed.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
