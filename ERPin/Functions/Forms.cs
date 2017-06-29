using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPin.Modules.Cash;
using ERPin.Modules.Current;
using ERPin.Modules.Stock;

namespace ERPin.Functions
{
    class Forms
    {
        #region Inventory
        public void InventoryItem(bool open = false)
        {
            FrmInventoryItem inventoryItem = new FrmInventoryItem();
            inventoryItem.ShowDialog();
        }

        public int InventoryGroup(bool selection = false)
        {
            FrmInventoryGroup inventoryGroup = new FrmInventoryGroup();
            if (selection) inventoryGroup.Selection = selection;
            inventoryGroup.ShowDialog();
            return MainForm.Transfer;
        }

        public int InventoryList(bool selection = false)
        {
            FrmInventoryList inventoryList = new FrmInventoryList();
            if (selection)
            {
                inventoryList.Selection = selection;
                inventoryList.ShowDialog();
            }
            else
            {
                inventoryList.MdiParent = MainForm.ActiveForm;
                inventoryList.Show();
            }
            return MainForm.Transfer;
        }

        public void InventoryTransaction(bool open = false)
        {

        }
        #endregion


        #region Current Account
        public void CurrAcc(bool open = false, int currAccId = -1)
        {
            FrmCurrAcc currAcc = new FrmCurrAcc();
            if (open)
            {
                currAcc.Open(currAccId);
            }
            currAcc.ShowDialog();
        }

        public int CurrAccGroup(bool selection = false)
        {
            Modules.Current.FrmCurrAccGroup currAccGroup = new FrmCurrAccGroup();
            if (selection)
            {
                currAccGroup.Selection = selection;
            }
            currAccGroup.ShowDialog();
            return MainForm.Transfer;
        }

        public int CurrAccList(bool selection = false)
        {
            Modules.Current.FrmCurrAccList currAccList = new FrmCurrAccList();
            if (selection)
            {
                currAccList.Selection = selection;
                currAccList.ShowDialog();
            }
            else
            {
                currAccList.MdiParent = MainForm.ActiveForm;
                currAccList.Show();
            }
            return MainForm.Transfer;
        }
        #endregion


        #region Cash Account
        public void CashAccount()
        {
            Modules.Cash.FrmCashAccount cashAccount = new FrmCashAccount();
            cashAccount.ShowDialog();
        }

        public void CashDeposit(bool open = false, int id = -1)
        {
            FrmCashDeposit cashDeposit = new FrmCashDeposit();
            if (open)
            {
                cashDeposit.OpenCashDeposit(id);
            }
            cashDeposit.ShowDialog();
        }

        public void CashTransaction(bool open = false, int TransactionId = -1)
        {
            Modules.Cash.FrmCashTransfer cashTransfer = new FrmCashTransfer();
            if (open)
            {
                cashTransfer.OpenCashTransfer(TransactionId);
            }
            cashTransfer.ShowDialog();
        }

        public int CashList(bool Selection = false)
        {
            Modules.Cash.FrmCashList cashList = new FrmCashList();
            if (Selection)
            {
                cashList.Selection = Selection;
                cashList.ShowDialog();
            }
            else
            {
                cashList.MdiParent = MainForm.ActiveForm;
                cashList.Show();
            }

            return MainForm.Transfer;
        }
        #endregion
    }
}