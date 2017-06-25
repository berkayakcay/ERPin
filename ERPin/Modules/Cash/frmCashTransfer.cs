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
    public partial class FrmCashTransfer : DevExpress.XtraEditors.XtraForm
    {
        public FrmCashTransfer()
        {
            InitializeComponent();
        }

        private void frmCashTransfer_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}