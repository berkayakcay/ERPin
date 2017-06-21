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
using ERPin.Functions;

namespace ERPin.Modules.Current
{
    public partial class frmCurrAccList : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        Functions.ERPinEntities db = new ERPinEntities();

        public bool Selection = false;
        private int SelectionId = -1;
        #endregion

        #region Events
        public frmCurrAccList()
        {
            InitializeComponent();
        }

        private void frmCurrAccList_Load(object sender, EventArgs e)
        {
            ListRecord();
        }
        #endregion

        #region Methods
        void ListRecord()
        {
            List<CurrAcc> list = db.CurrAcc.Where(s => s.CurrAccCode.Contains(txtCurrAccCode.Text) && s.CurrAccName.Contains(txtCurrAccName.Text)).ToList();
            gcList.DataSource = list;
        }

        void SelectRecord()
        {
            try
            {
                SelectionId = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            }
            catch (Exception)
            {
                SelectionId = -1;
            }
        }
        #endregion

        private void gcList_DoubleClick(object sender, EventArgs e)
        {
            SelectRecord();
            if (Selection && SelectionId > 0)
            {
                MainForm.Transfer = SelectionId;
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }
    }
}