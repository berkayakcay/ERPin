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

namespace ERPin.Modules.Cash
{
    public partial class frmCashDeposit : DevExpress.XtraEditors.XtraForm
    {
        private bool Edit = false;
        private int TransactionId = -1;
        private string TransactionType = "";

        public frmCashDeposit()
        {
            InitializeComponent();
        }

        private void frmCashDeposit_Load(object sender, EventArgs e)
        {

        }

        private void txtTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TransactionType = txtTransactionType.SelectedItem.ToString();

        }
    }
}