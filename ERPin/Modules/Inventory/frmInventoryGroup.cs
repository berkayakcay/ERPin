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
using ERPin.Models;
using ERPin.Repositories;
using ERPin.UnitOfWork;

namespace ERPin.Modules.Stock
{
    public partial class FrmInventoryGroup : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        private ERPinDbContext _dbContext;
        private IUnitOfWork _unitOfWork;
        private IRepository<InventoryGroup> _inventoryGroupRepository;

        private readonly Messages _messages = new Messages();

        public bool Selection = false;
        private int _selectedId = -1;
        private bool _edit = false;

        #endregion


        public FrmInventoryGroup()
        {
            InitializeComponent();

            _dbContext = new ERPinDbContext();
            _unitOfWork = new EfUnitOfWork(_dbContext);
            _inventoryGroupRepository = _unitOfWork.GetRepository<InventoryGroup>();
        }


        #region Events

        private void frmInventoryGroup_Load(object sender, EventArgs e)
        {
            ListRecord();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_edit && _selectedId > 0 && _messages.Delete() == DialogResult.Yes)
            {
                DeleteRecord();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_edit && _selectedId > 0 && _messages.Update() == DialogResult.Yes)
            {
                UpdateRecord();
            }
            else
            {
                CreateRecord();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            SelectRecord();
            if (Selection && _selectedId > 0)
            {
                MainForm.Transfer = _selectedId;
                this.Close();
            }
        }
        #endregion


        #region Functions

        void ListRecord()
        {
            try
            {
                var list = _inventoryGroupRepository.GetAll();
                gcListe.DataSource = list;
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
        }

        void ClearRecord()
        {
            List<TextEdit> controls = groupControl1.Controls.OfType<TextEdit>().ToList();
            foreach (var textEdit in controls)
            {
                textEdit.Text = "";
            }
        }

        void CreateRecord()
        {
            try
            {
                InventoryGroup inventoryGroup = new InventoryGroup();
                inventoryGroup.GroupCode = txtGroupCode.Text;
                inventoryGroup.GroupName = txtGroupName.Text;
                _inventoryGroupRepository.Add(inventoryGroup);
                _unitOfWork.SaveChanges();
                _messages.Save("New record has been created");
                ClearRecord();
                ListRecord();
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
                InventoryGroup inventoryGroup = _inventoryGroupRepository.GetById(_selectedId);
                if (inventoryGroup != null)
                {
                    inventoryGroup.GroupCode = txtGroupCode.Text;
                    inventoryGroup.GroupName = txtGroupName.Text;
                    _unitOfWork.SaveChanges();
                    _messages.Update(inventoryGroup.Id.ToString());
                }
                ClearRecord();
                ListRecord();
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
                _inventoryGroupRepository.Delete(_selectedId);
                _unitOfWork.SaveChanges();
                _messages.Delete();
                ClearRecord();
                ListRecord();
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
        }

        void SelectRecord()
        {
            try
            {
                _edit = true;
                _selectedId = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                txtGroupCode.Text = gridView1.GetFocusedRowCellValue("GroupCode").ToString();
                txtGroupName.Text = gridView1.GetFocusedRowCellValue("GroupName").ToString();
            }
            catch (Exception)
            {
                _edit = false;
                _selectedId = -1;
            }
        }
        #endregion


    }
}
