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
    public partial class FrmCashTransfer : DevExpress.XtraEditors.XtraForm
    {
        #region Fiedls
        private ERPinDbContext _dbContext;
        private IUnitOfWork _unitOfWork;
        private IRepository<CashAcc> _cashAccRepository;
        private IRepository<CashTransaction> _cashTransactionRepository;

        private readonly Messages _messages = new Messages();
        private readonly Forms _forms = new Forms();
        private readonly Numbers _numbers = new Numbers();

        private bool _edit = false;
        private int _cashAccId = -1;
        private int _transactionId = -1;
        #endregion


        #region Events
        public FrmCashTransfer()
        {
            InitializeComponent();

            _dbContext = new ERPinDbContext();
            _unitOfWork = new EfUnitOfWork(_dbContext);
            _cashAccRepository = _unitOfWork.GetRepository<CashAcc>();
            _cashTransactionRepository = _unitOfWork.GetRepository<CashTransaction>();
        }

        private void frmCashTransfer_Load(object sender, EventArgs e)
        {
            ClearRecord();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_edit && _transactionId > 0 && _messages.Update() == DialogResult.Yes)
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
            if (_edit && _transactionId > 0 && _messages.Delete() == DialogResult.Yes)
            {
                DeleteRecord();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCashAccCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = _forms.CashList(true);
            if (Id > 0)
            {
                OpenCashAcc(Id);
                MainForm.Transfer = -1;
            }
        }

        private void txtDocumentNumber_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
        #endregion


        #region Methods
        void CreateRecord()
        {
            try
            {
                CashTransaction cashTransaction = new CashTransaction();
                cashTransaction.DocumentNumber = txtDocumentNumber.Text;
                if (rBtnInflowCash.Checked) cashTransaction.InOutCode = "In";
                if (rBtnOutflowCash.Checked) cashTransaction.InOutCode = "Out";
                cashTransaction.CashAccId = _cashAccId;
                cashTransaction.Date = DateTime.Now;
                cashTransaction.Amount = decimal.Parse(txtAmount.Text);
                cashTransaction.TransactionType = "Cash Transfer";
                cashTransaction.Description = txtDescription.Text;
                // Audit trail
                cashTransaction.CreatedUserId = MainForm.UserId;
                cashTransaction.CreatedDate = DateTime.Now;
                cashTransaction.UpdatedUserId = MainForm.UserId;
                cashTransaction.UpdatedDate = DateTime.Now;

                _cashTransactionRepository.Add(cashTransaction);
                _unitOfWork.SaveChanges();
                _messages.Save("Saved");
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
                CashTransaction cashTransaction = _cashTransactionRepository.GetById(_transactionId);
                cashTransaction.DocumentNumber = txtDocumentNumber.Text;
                if (rBtnInflowCash.Checked) cashTransaction.InOutCode = "In";
                if (rBtnOutflowCash.Checked) cashTransaction.InOutCode = "Out";
                cashTransaction.CashAccId = _cashAccId;
                cashTransaction.Date = DateTime.Now;
                cashTransaction.Amount = decimal.Parse(txtAmount.Text);
                cashTransaction.TransactionType = "Cash Transfer";
                cashTransaction.Description = txtDescription.Text;
                // Audit trail
                cashTransaction.UpdatedUserId = MainForm.UserId;
                cashTransaction.UpdatedDate = DateTime.Now;

                _cashTransactionRepository.Update(cashTransaction);
                _unitOfWork.SaveChanges();
                _messages.Update();
                ClearRecord();
            }
            catch (Exception e)
            {
                _messages.Error(e);
                throw;
            }
        }

        void DeleteRecord()
        {
            try
            {
                _cashTransactionRepository.Delete(_transactionId);
                _unitOfWork.SaveChanges();
                ClearRecord();
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
        }

        void ClearRecord()
        {
            foreach (TextEdit textEdit in groupControlCashAccountInfo.Controls.OfType<TextEdit>())
            {
                textEdit.Text = "";
            }
            foreach (TextEdit textEdit in groupControlCashTransactionInfo.Controls.OfType<TextEdit>())
            {
                textEdit.Text = "";
            }

            txtDate.Text = DateTime.Now.ToShortDateString();

            _edit = false;
            _cashAccId = -1;
            _transactionId = -1;
            MainForm.Transfer = -1;

        }

        public void OpenCashTransfer(int id)
        {
            try
            {
                _edit = true;
                _transactionId = id;
                CashTransaction cashTransaction = _cashTransactionRepository.GetById(_transactionId);
                txtDocumentNumber.Text = cashTransaction.DocumentNumber;
                OpenCashAcc(cashTransaction.TransactionId.Value);
                txtDate.Text = cashTransaction.Date.Value.ToShortDateString();
                txtAmount.Text = cashTransaction.Amount.Value.ToString();
                if (cashTransaction.InOutCode == "In") rBtnInflowCash.Checked = true;
                if (cashTransaction.InOutCode == "Out") rBtnOutflowCash.Checked = true;
                txtDescription.Text = cashTransaction.Description;
                

            }
            catch (Exception e)
            {
                _messages.Error(e);
            }    
        }

        void OpenCashAcc(int id)
        {
            try
            {
                _cashAccId = id;
                txtCashAccCode.Text = _cashAccRepository.GetById(_cashAccId).CashAccCode;
                txtCashAccName.Text = _cashAccRepository.GetById(_cashAccId).CashAccName;
            }
            catch (Exception)
            {
            }
        }
        #endregion
    }
}