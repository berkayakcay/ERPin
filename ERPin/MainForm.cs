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

namespace ERPin
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Functions.Forms forms = new Forms();

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
            forms.InventoryItem();
        }

        private void barBtnInventoryGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            forms.InventoryGroup();
        }

        private void barBtnInventoryList_ItemClick(object sender, ItemClickEventArgs e)
        {
            forms.InventoryList();
        }

        private void barBtnInventoryTransaction_ItemClick(object sender, ItemClickEventArgs e)
        {
            forms.InventoryTransaction();
        }
        #endregion

        #region Current Account
        private void barBtnCurrAcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            forms.CurrAcc();
        }

        private void barBtnCurrAccGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            forms.CurrAccGroup();
        }

        private void barBtnCurrAccList_ItemClick(object sender, ItemClickEventArgs e)
        {
            forms.CurrAccList();
        }

        private void barBtnCurrAccTransaction_ItemClick(object sender, ItemClickEventArgs e)
        {

        } 
        #endregion
    }
}