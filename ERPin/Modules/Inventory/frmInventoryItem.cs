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
using ERPin.Models;
using ERPin.Repositories;
using ERPin.UnitOfWork;

namespace ERPin.Modules.Stock
{
    public partial class FrmInventoryItem : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private ERPinDbContext _dbContext;
        private IUnitOfWork _unitOfWork;
        private IRepository<Inventory> _inventoryRepository;
        private IRepository<InventoryGroup> _inventoryGroupRepository;

        private readonly Messages _messages = new Messages();
        private readonly Numbers _numbers = new Numbers();
        private readonly Forms _forms = new Forms();
        private Pictures _pictures = new Pictures();

        private bool _edit = false;
        private bool _picture = false;
        private int _groupId = -1;
        private int _itemId = -1; 
        #endregion

        #region Events
        public FrmInventoryItem()
        {
            InitializeComponent();

            _dbContext = new ERPinDbContext();
            _unitOfWork = new EfUnitOfWork(_dbContext);
            _inventoryRepository = _unitOfWork.GetRepository<Inventory>();
            _inventoryGroupRepository = _unitOfWork.GetRepository<InventoryGroup>();
        }

        private void frmInventoryItem_Load(object sender, EventArgs e)
        {
            txtItemCode.Text = _numbers.LastInventoryItemCode();
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            PictureRecord();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_edit && _itemId > 0 && _messages.Update() == DialogResult.Yes)
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
            if (_edit && _itemId > 0 && _messages.Delete() == DialogResult.Yes) { _messages.Delete(); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtItemCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = _forms.InventoryList(true);
            if (id > 0)
            {
                OpenItem(id);
            }
            MainForm.Transfer = -1;
        }

        private void txtGroupCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = _forms.InventoryGroup(true);
            if (id > 0)
            {
                OpenGroup(id);
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
                    _picture = true;
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
                inventory.GroupId = _groupId;
                inventory.Unit = txtUnit.Text;
                inventory.Barcode = txtBarcode.Text;
                inventory.PurchasePrice = decimal.Parse(txtPurchasePrice.Text);
                inventory.SalePrice = decimal.Parse(txtSalePrice.Text);
                inventory.PurchaseTax = decimal.Parse(txtPurchaseTax.Text);
                inventory.SaleTax = decimal.Parse(txtSaleTax.Text);
                inventory.CreatedDate = DateTime.Now;
                inventory.CreatedUserId = MainForm.UserId;
                if(_picture) inventory.Picture = _pictures.UploadPicture(pbItemPicture.Image);
                _inventoryRepository.Add(inventory);
                _unitOfWork.SaveChanges();
                _messages.Save("New record has been created.");
                ClearRecord();
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
        }

        void UpdateRecord()
        {
            try
            {
                Inventory inventory = _inventoryRepository.GetById(_itemId);
                inventory.ItemCode = txtItemCode.Text;
                inventory.ItemName = txtItemName.Text;
                inventory.GroupId = _groupId;
                inventory.Unit = txtUnit.Text;
                inventory.Barcode = txtBarcode.Text;
                inventory.PurchasePrice = decimal.Parse(txtPurchasePrice.Text);
                inventory.SalePrice = decimal.Parse(txtSalePrice.Text);
                inventory.PurchaseTax = decimal.Parse(txtPurchaseTax.Text);
                inventory.SaleTax = decimal.Parse(txtSaleTax.Text);
                inventory.CreatedDate = DateTime.Now;
                inventory.CreatedUserId = MainForm.UserId;
                if (_picture) inventory.Picture = _pictures.UploadPicture(pbItemPicture.Image);

                _unitOfWork.SaveChanges();
                _messages.Update();
                ClearRecord();
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
        }

        void DeleteRecord()
        {
            try
            {
                _inventoryRepository.Delete(_itemId);
                _unitOfWork.SaveChanges();
            }
            catch (Exception e)
            {
                _messages.Error(e);
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
            _edit = false;
            _picture = false;
            _groupId = -1;
            _itemId = -1;
            MainForm.Transfer = -1;
        }

        void OpenGroup(int id)
        {
            _groupId = id;
            InventoryGroup inventoryGroup = _inventoryGroupRepository.GetById(_groupId);
            txtGroupCode.Text = inventoryGroup.GroupCode;
            txtGroupName.Text = inventoryGroup.GroupName;
        }

        void OpenItem(int id)
        {
            _edit = true;
            _itemId = id;
            Inventory inventory = _inventoryRepository.GetById(_itemId);
            OpenGroup(inventory.GroupId.Value);
            pbItemPicture.Image = _pictures.RetrievePicture(inventory.Picture.ToArray());
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