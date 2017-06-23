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
    public partial class frmCashList : DevExpress.XtraEditors.XtraForm
    {
        public bool Selection = false;

        public frmCashList()
        {
            InitializeComponent();
        }

        private void frmCashList_Load(object sender, EventArgs e)
        {
            ListRecord();
        }


        void ListRecord()
        {
            
        }
    }
}