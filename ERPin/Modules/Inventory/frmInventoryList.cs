﻿using System;
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

namespace ERPin.Modules.Stock
{
    public partial class FrmInventoryList : DevExpress.XtraEditors.XtraForm
    {
        Functions.ERPinEntities _db = new ERPinEntities();

        public bool Selection = false;
        private int _selectionId = -1;

        public FrmInventoryList()
        {
            InitializeComponent();
        }

        private void frmInventoryList_Load(object sender, EventArgs e)
        {
            ListRecord();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListRecord();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearRecord();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            SelectRecord();
            if (Selection && _selectionId > 0)
            {
                MainForm.Transfer = _selectionId;
                this.Close();
            }
        }

        void ListRecord()
        {
            List<Inventory> list = _db.Inventory.Where(x=> x.ItemCode.Contains(txtItemCode.Text) && x.ItemName.Contains(txtItemName.Text) && x.Barcode.Contains(txtItemBarcode.Text)).ToList();
            gcList.DataSource = list;
        }

        void ClearRecord()
        {
            var controls = xtraTabPage1.Controls.OfType<TextEdit>();

            foreach (TextEdit textEdit in controls)
            {
                textEdit.Text = "";
            }
        }

        void SelectRecord()
        {
            try
            {
                _selectionId = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _selectionId = -1;
            }
        }

    }
}