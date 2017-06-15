using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPin.Modules.Stock;

namespace ERPin.Functions
{
    class Forms
    {
        public int InventoryList(bool Selection = false)
        {
            frmInventoryList inventoryList = new frmInventoryList();
            if (Selection)
            {
                inventoryList.Selection = Selection;
                inventoryList.ShowDialog();
            }
            else
            {
                inventoryList.MdiParent = MainForm.ActiveForm;
                inventoryList.Show();
            }
            return MainForm.Transfer;
        }

        public int InventoryGroup(bool Selection = false)
        {
            frmInventoryGroup inventoryGroup = new frmInventoryGroup();
            if (Selection) inventoryGroup.Selection = Selection;
                inventoryGroup.ShowDialog();
            return MainForm.Transfer;
        }

        public void InventoryTransaction(bool Open = false)
        {
            
        }

        public void InventoryItem(bool Open = false)
        {
            frmInventoryItem inventoryItem = new frmInventoryItem();
            inventoryItem.ShowDialog();
        }
    }
}
