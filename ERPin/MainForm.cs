using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ERPin.Functions;
using ERPin.Managers;

namespace ERPin
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Functions.Forms _forms = new Forms();

        public static int UserId = -1;
        public static int Transfer = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        #region Inventory
        private void barBtnInventoryItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            _forms.InventoryItem();
        }

        private void barBtnInventoryGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            _forms.InventoryGroup();
        }

        private void barBtnInventoryList_ItemClick(object sender, ItemClickEventArgs e)
        {
            _forms.InventoryList();
        }

        private void barBtnInventoryTransaction_ItemClick(object sender, ItemClickEventArgs e)
        {
            _forms.InventoryTransaction();
        }
        #endregion

        #region Current Account
        private void barBtnCurrAcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            _forms.CurrAcc();
        }

        private void barBtnCurrAccGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            _forms.CurrAccGroup();
        }

        private void barBtnCurrAccList_ItemClick(object sender, ItemClickEventArgs e)
        {
            _forms.CurrAccList();
        }

        private void barBtnCurrAccTransaction_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion


        #region Cash Account
        private void barBtnCashAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            _forms.CashAccount();
        }

        private void barBtnCashList_ItemClick(object sender, ItemClickEventArgs e)
        {
            _forms.CashList();
        }

        private void barBCashTransfer_ItemClick(object sender, ItemClickEventArgs e)
        {
            _forms.CashTransaction();
        }

        private void barBCashDeposit_ItemClick(object sender, ItemClickEventArgs e)
        {
            _forms.CashDeposit();
        }
        #endregion

        private void barBtnNebimV3Connection_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show(ConnectionManager.GetVersion);
        }
    }
}