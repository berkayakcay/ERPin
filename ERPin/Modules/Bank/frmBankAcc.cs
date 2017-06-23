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
    public partial class frmBankAcc : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private bool Edit = false;
        private int SelectionId = -1;
        #endregion


        #region Events
        public frmBankAcc()
        {
            InitializeComponent();
        }

        private void frmBankAcc_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Methods

        #endregion
    }
}