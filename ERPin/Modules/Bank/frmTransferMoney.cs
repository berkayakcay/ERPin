using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ERPin.Modules.Bank
{
    public partial class FrmTransferMoney : DevExpress.XtraEditors.XtraForm
    {
        private string _transactionType = "Bank Transfer";

        public FrmTransferMoney()
        {
            InitializeComponent();
        }

        private void txtTransferType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTransferType.SelectedIndex == 0)
            {
                rBtnInflow.Text = "Inflow Transfer";
                rBtnOutflow.Text = "Outflow Transfer";
                _transactionType = "Bank Transfer";
            }
            else if(txtTransferType.SelectedIndex == 1)
            {
                rBtnInflow.Text = "Inflow EFT";
                rBtnOutflow.Text = "Outflow EFT";
                _transactionType = "Bank EFT";
            }
        }

        private void frmBankList_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}