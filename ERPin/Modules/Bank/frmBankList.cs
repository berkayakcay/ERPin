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
    public partial class FrmBankList : DevExpress.XtraEditors.XtraForm
    {
        private bool _selection = false;
        private int _selectionId = -1;

        public FrmBankList()
        {
            InitializeComponent();
        }

        private void frmBankList_Load(object sender, EventArgs e)
        {
            ListRecord();
        }


        void ListRecord()
        {
            
        }
    }
}