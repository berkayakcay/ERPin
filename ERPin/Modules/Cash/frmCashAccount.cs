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

namespace ERPin.Modules.Cash
{
    public partial class FrmCashAccount : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private ERPinDbContext _dbContext;
        private IUnitOfWork _unitOfWork;
        private IRepository<CashAcc> _cashAccRepository;

        private readonly Messages _messages = new Messages();
        private readonly Numbers _numbers = new Numbers();

        private bool _edit = false;
        private int _selectionId = -1;
        #endregion


        #region Events
        public FrmCashAccount()
        {
            InitializeComponent();

            _dbContext = new ERPinDbContext();
            _unitOfWork = new EfUnitOfWork(_dbContext);
            _cashAccRepository = _unitOfWork.GetRepository<CashAcc>();
        }

        private void frmCashAccount_Load(object sender, EventArgs e)
        {
            ListRecord();
            txtCashAccCode.Text = _numbers.LastCashAccCode();
        }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_edit && _selectionId > 0 && _messages.Delete() == DialogResult.Yes)
            {
                DeleteRecord();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            SelectRecord();
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
                CashAcc cashAcc = new CashAcc();
                cashAcc.CashAccCode = txtCashAccCode.Text;
                cashAcc.CashAccName = txtCashAccName.Text;
                cashAcc.Description = txtDescription.Text;
                cashAcc.CreatedUserId = MainForm.UserId;
                cashAcc.CreatedDate = DateTime.Now;
                cashAcc.UpdatedUserId = MainForm.UserId;
                cashAcc.UpdatedDate = DateTime.Now;
                _cashAccRepository.Add(cashAcc);
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
        void UpdateRecord()
        {
            try
            {
                CashAcc cashAcc = _cashAccRepository.GetById(_selectionId);
                cashAcc.CashAccCode = txtCashAccCode.Text;
                cashAcc.CashAccName = txtCashAccName.Text;
                cashAcc.Description = txtDescription.Text;
                // Audit trail
                cashAcc.CreatedUserId = MainForm.UserId;
                cashAcc.CreatedDate = DateTime.Now;
                cashAcc.UpdatedUserId = MainForm.UserId;
                cashAcc.UpdatedDate = DateTime.Now;
                
                _cashAccRepository.Update(cashAcc);
                _unitOfWork.SaveChanges();
                _messages.Update();
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
        void DeleteRecord()
        {
            try
            {
                _cashAccRepository.Delete(_selectionId);
                _unitOfWork.SaveChanges();
                ClearRecord();
            }
            catch (Exception e)
            {
                _messages.Error(e);
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void ClearRecord()
        {
            IEnumerable<TextEdit> list = groupControlCashAccInfo.Controls.OfType<TextEdit>();
            foreach (TextEdit textEdit in list)
            {
                textEdit.Text = "";
            }

            _edit = false;
            _selectionId = -1;
            ListRecord();
        }

        /// <summary>
        /// 
        /// </summary>
        void SelectRecord()
        {
            try
            {
                _edit = true;
                _selectionId = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                txtCashAccCode.Text = gridView1.GetFocusedRowCellValue("CashAccCode").ToString();
                txtCashAccName.Text = gridView1.GetFocusedRowCellValue("CashAccName").ToString();
                txtDescription.Text = gridView1.GetFocusedRowCellValue("Description").ToString();
            }
            catch (Exception)
            {
                _edit = false;
                _selectionId = -1;
            }
        }

        void ListRecord()
        {
            var list = _cashAccRepository.GetAll().ToList();
            gcList.DataSource = list;
        }

        #endregion
    }
}