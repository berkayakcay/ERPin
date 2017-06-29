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
    public partial class FrmCashDeposit : DevExpress.XtraEditors.XtraForm
    {
        private bool _edit = false;
        private int _transactionId = -1;
        private string _transactionType = "";

        public FrmCashDeposit()
        {
            InitializeComponent();
        }

        private void frmCashDeposit_Load(object sender, EventArgs e)
        {

        }

        private void txtTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _transactionType = txtTransactionType.SelectedItem.ToString();

        }
    }
}