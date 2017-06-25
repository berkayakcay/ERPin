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

namespace ERPin.Modules.Current
{
    public partial class FrmCurrAccGroup : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private ERPinDbContext _dbContext;
        private IUnitOfWork _unitOfWork;
        private IRepository<CurrAccGroup> _currAccGroupRepository;

        private readonly Messages _messages = new Messages();

        public bool Selection = false;
        private bool _edit = false;
        private int _selectionId = -1;

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public FrmCurrAccGroup()
        {
            InitializeComponent();

            _dbContext = new ERPinDbContext();
            _unitOfWork = new EfUnitOfWork(_dbContext);
            _currAccGroupRepository = _unitOfWork.GetRepository<CurrAccGroup>();
        }

        #region Events

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCurrAccGroup_Load(object sender, EventArgs e)
        {
            ListRecord();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_edit && _selectionId > 0 && _messages.Update() == DialogResult.Yes)
            {
                UpdateRecord();
            }
            else
            {
                CreateRecord();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_edit && _selectionId > 0 && _messages.Delete() == DialogResult.Yes)
            {
                DeleteRecord();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        void CreateRecord()
        {
            try
            {
                CurrAccGroup currAccGroup = new CurrAccGroup
                {
                    GroupCode = txtGroupCode.Text,
                    GroupName = txtGroupName.Text,
                    CreatedUserId = MainForm.UserId,
                    CreatedDate = DateTime.Now,
                    UpdatedUserId = MainForm.UserId,
                    UpdatedDate = DateTime.Now
                };
                _currAccGroupRepository.Add(currAccGroup);
                _unitOfWork.SaveChanges();
                _messages.Save("Created");
                ListRecord();
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void UpdateRecord()
        {
            try
            {
                CurrAccGroup currAccGroup =_currAccGroupRepository.GetById(_selectionId);
                if (currAccGroup != null)
                {
                    currAccGroup.GroupCode = txtGroupCode.Text;
                    currAccGroup.GroupName = txtGroupName.Text;
                    currAccGroup.UpdatedUserId = MainForm.UserId;
                    currAccGroup.UpdatedDate = DateTime.Now;
                }
                _unitOfWork.SaveChanges();
                _messages.Update("Updated");
                ListRecord();
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void DeleteRecord()
        {
            try
            {
                _currAccGroupRepository.Delete(_selectionId);
                _unitOfWork.SaveChanges();
                ClearRecord();
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void ListRecord()
        {
            var list = _currAccGroupRepository.GetAll();
            gcListe.DataSource = list;
        }

        /// <summary>
        /// 
        /// </summary>
        void SelectRecord()
        {
            try
            {
                _edit = true;
                _selectionId = (int)gridView1.GetFocusedRowCellValue("Id");
                txtGroupCode.Text = gridView1.GetFocusedRowCellValue("GroupCode").ToString();
                txtGroupName.Text = gridView1.GetFocusedRowCellValue("GroupName").ToString();
            }
            catch (Exception e)
            {
                _messages.Error(e);
                _edit = false;
                _selectionId = -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void ClearRecord()
        {
            List<TextEdit> list = new List<TextEdit>();
            list.AddRange(gcCurrAccInfo.Controls.OfType<TextEdit>());
            _edit = false;
            _selectionId = -1;
            ListRecord();
        }

        #endregion
    }
}