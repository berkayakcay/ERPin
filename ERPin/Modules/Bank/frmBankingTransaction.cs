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
    public partial class frmBankingTransaction : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private int TransactionId = -1;
        #endregion

        #region Events
        public frmBankingTransaction()
        {
            InitializeComponent();
        }

        private void frmBankingTransaction_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Methods

        #endregion
    }
}