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
    public partial class FrmBankAcc : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private bool _edit = false;
        private int _selectionId = -1;
        #endregion


        #region Events
        public FrmBankAcc()
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