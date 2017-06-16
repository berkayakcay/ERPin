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

namespace ERPin.Modules.Current
{
    public partial class frmCurrAccList : DevExpress.XtraEditors.XtraForm
    {
        public bool Selection = false;
        private int SelectionId = -1;

        public frmCurrAccList()
        {
            InitializeComponent();
        }

        private void frmCurrAccList_Load(object sender, EventArgs e)
        {
            ListRecord();
        }

        void ListRecord()
        {
            
        }
    }
}