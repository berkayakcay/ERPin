using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERPin.Functions;

namespace ERPin.Modules.Stock
{
    public partial class frmInventoryItem : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        Functions.ERPinEntities db = new ERPinEntities();
        Functions.Messages messages = new Messages();
        Functions.Numbers numbers = new Numbers();
        Functions.Forms forms = new Forms();
        Functions.Pictures pictures = new Pictures();

        private bool Edit = false;
        private bool Picture = false;
        private int GroupId = -1;
        private int ItemId = -1; 
        #endregion

        #region Events
        public frmInventoryItem()
        {
            InitializeComponent();
        }

        private void frmInventoryItem_Load(object sender, EventArgs e)
        {
            txtItemCode.Text = numbers.LastInventoryItemCode();
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            PictureRecord();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit && ItemId > 0 && messages.Update() == DialogResult.Yes)
            {
                UpdateRecord();
            }
            else
            {
                CreateRecord();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Edit && ItemId > 0 && messages.Delete() == DialogResult.Yes) { messages.Delete(); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtItemCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = forms.InventoryList(true);
            if (Id > 0)
            {
                OpenItem(Id);
            }
            MainForm.Transfer = -1;
        }

        private void txtGroupCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = forms.InventoryGroup(true);
            if (Id > 0)
            {
                OpenGroup(Id);
            }
            MainForm.Transfer = -1;
        }

        #endregion

        #region Methods

        void PictureRecord()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbItemPicture.ImageLocation = openFileDialog.FileName;
                    Picture = true;
                }
            }
        }

        void CreateRecord()
        {
            try
            {
                Inventory inventory = new Inventory();
                inventory.ItemCode = txtItemCode.Text;
                inventory.ItemName = txtItemName.Text;
                inventory.GroupId = GroupId;
                inventory.Unit = txtUnit.Text;
                inventory.Barcode = txtBarcode.Text;
                inventory.PurchasePrice = decimal.Parse(txtPurchasePrice.Text);
                inventory.SalePrice = decimal.Parse(txtSalePrice.Text);
                inventory.PurchaseTax = decimal.Parse(txtPurchaseTax.Text);
                inventory.SaleTax = decimal.Parse(txtSaleTax.Text);
                inventory.CreatedDate = DateTime.Now;
                inventory.CreatedUserId = MainForm.UserId;
                if(Picture) inventory.Picture = pictures.UploadPicture(pbItemPicture.Image);
                db.Inventory.Add(inventory);
                db.SaveChanges();
                messages.Save("New record has been created.");
                ClearRecord();
            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }

        void UpdateRecord()
        {
            try
            {
                Inventory inventory = db.Inventory.First(s => s.Id == ItemId);
                inventory.ItemCode = txtItemCode.Text;
                inventory.ItemName = txtItemName.Text;
                inventory.GroupId = GroupId;
                inventory.Unit = txtUnit.Text;
                inventory.Barcode = txtBarcode.Text;
                inventory.PurchasePrice = decimal.Parse(txtPurchasePrice.Text);
                inventory.SalePrice = decimal.Parse(txtSalePrice.Text);
                inventory.PurchaseTax = decimal.Parse(txtPurchaseTax.Text);
                inventory.SaleTax = decimal.Parse(txtSaleTax.Text);
                inventory.CreatedDate = DateTime.Now;
                inventory.CreatedUserId = MainForm.UserId;
                if (Picture) inventory.Picture = pictures.UploadPicture(pbItemPicture.Image);

                db.SaveChanges();
                messages.Update();
                ClearRecord();
            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }

        void DeleteRecord()
        {
            try
            {
                Inventory inventory = new Inventory { Id = ItemId };
                db.Entry(inventory).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                messages.Error(e);
                throw;
            }
        }

        void ClearRecord()
        {
            List<TextEdit> controls = new List<TextEdit>();
            controls.AddRange(groupControlInventory.Controls.OfType<TextEdit>().ToList());
            controls.AddRange(groupControlGroup.Controls.OfType<TextEdit>().ToList());
            controls.AddRange(groupControlUnit.Controls.OfType<TextEdit>().ToList());
            controls.AddRange(groupControlPrice.Controls.OfType<TextEdit>().ToList());
            controls.AddRange(groupControlTax.Controls.OfType<TextEdit>().ToList());

            foreach (var textEdit in controls)
            {
                textEdit.Text = "";
            }
            if (pbItemPicture.Image != null)
            {
                pbItemPicture.Image.Dispose();
                pbItemPicture.Image = null;
            }
            Edit = false;
            Picture = false;
            GroupId = -1;
            ItemId = -1;
            MainForm.Transfer = -1;
        }

        void OpenGroup(int id)
        {
            GroupId = id;
            txtGroupCode.Text = db.InventoryGroup.First(s => s.Id == GroupId).GroupCode;
            txtGroupName.Text = db.InventoryGroup.First(s => s.Id == GroupId).GroupName;
        }

        void OpenItem(int id)
        {
            Edit = true;
            ItemId = id;
            Functions.Inventory inventory = db.Inventory.First(s => s.Id == ItemId);
            OpenGroup(inventory.GroupId.Value);
            pbItemPicture.Image = pictures.RetrievePicture(inventory.Picture.ToArray());
            txtItemCode.Text = inventory.ItemCode;
            txtItemName.Text = inventory.ItemName;
            txtBarcode.Text = inventory.Barcode;
            txtUnit.Text = inventory.Unit;
            txtPurchasePrice.Text = inventory.PurchasePrice.ToString();
            txtSalePrice.Text = inventory.SalePrice.ToString();
            txtPurchaseTax.Text = inventory.PurchaseTax.ToString();
            txtSaleTax.Text = inventory.SaleTax.ToString();
        }

        #endregion

    }
}