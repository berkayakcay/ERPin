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
    public partial class FrmCashDeposit : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private ERPinDbContext _dbContext;
        private IUnitOfWork _unitOfWork;
        private IRepository<CashAcc> _cashAccRepository;
        private IRepository<CashTransaction> _cashTransactionRepository;
        private IRepository<CurrAcc> _currAccRepository;
        private IRepository<CurrAccTransaction> _currAccranTransactionRepository;

        private readonly Messages _messages = new Messages();
        private readonly Forms _forms = new Forms();
        private readonly Numbers _numbers = new Numbers();

        private bool _edit = false;
        private int _cashAccId = -1;
        private int _transactionId = -1;
        private int _currAccId = -1;
        private int _currAccTransactionId = -1;
        #endregion


        #region Events
        public FrmCashDeposit()
        {
            InitializeComponent();

            _dbContext = new ERPinDbContext();
            _unitOfWork = new EfUnitOfWork(_dbContext);
            _cashAccRepository = _unitOfWork.GetRepository<CashAcc>();
            _cashTransactionRepository = _unitOfWork.GetRepository<CashTransaction>();
            _currAccRepository = _unitOfWork.GetRepository<CurrAcc>();
            _currAccranTransactionRepository = _unitOfWork.GetRepository<CurrAccTransaction>();
        }

        private void frmCashDeposit_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }

        private void txtTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateRecord();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
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

        private void txtCurrAccCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = _forms.CurrAccList(true);
            if (id > 0)
            {
                OpenCurrAcc(id);
            }
            MainForm.Transfer = -1;
        }
        #endregion


        #region Methods

        void CreateRecord()
        {
            try
            {
                CashTransaction cashTransaction = new CashTransaction();
                cashTransaction.Description = txtDescription.Text;
                cashTransaction.DocumentNumber = txtDocumentNumber.Text;
                cashTransaction.CurrAccId = _currAccId;
                cashTransaction.TransactionType = txtTransactionType.SelectedItem.ToString();
                if (txtTransactionType.SelectedIndex == 0) cashTransaction.InOutCode = "In";
                if (txtTransactionType.SelectedIndex == 1) cashTransaction.InOutCode = "Out";
                cashTransaction.CashAccId = _cashAccId;
                cashTransaction.Date = DateTime.Parse(txtDate.Text);
                cashTransaction.Amount = decimal.Parse(txtAmount.Text.ToString());
                // Audit trail
                cashTransaction.CreatedUserId = MainForm.UserId;
                cashTransaction.CreatedDate = DateTime.Now;
                cashTransaction.UpdatedUserId = MainForm.UserId;
                cashTransaction.UpdatedDate = DateTime.Now;

                _cashTransactionRepository.Add(cashTransaction);
                _messages.Save("Saved \n " + txtTransactionType.SelectedItem.ToString());

                CurrAccTransaction currAccTransaction = new CurrAccTransaction();
                currAccTransaction.Description = $@"Document Number :{txtDocumentNumber.Text} \n {txtTransactionType.SelectedItem}";
                if (txtTransactionType.SelectedIndex == 0) currAccTransaction.Credit = decimal.Parse(txtAmount.Text);
                if (txtTransactionType.SelectedIndex == 1) currAccTransaction.Debit = decimal.Parse(txtAmount.Text);
                currAccTransaction.CurrAccId = _currAccId;
                currAccTransaction.TransactionType = txtTransactionType.SelectedItem.ToString();
                currAccTransaction.Date = DateTime.Parse(txtDate.Text);
                if (txtTransactionType.SelectedIndex == 0) currAccTransaction.Type = "CC";
                if (txtTransactionType.SelectedIndex == 1) currAccTransaction.Type = "CD";
                // Audit trail
                currAccTransaction.CreatedUserId = MainForm.UserId;
                currAccTransaction.CreatedDate = DateTime.Now;
                currAccTransaction.UpdatedUserId = MainForm.UserId;
                currAccTransaction.UpdatedDate = DateTime.Now;

                _currAccranTransactionRepository.Add(currAccTransaction);
                _messages.Save("New current account transaction as " + txtTransactionType.SelectedItem);

                _unitOfWork.SaveChanges();
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
                CurrAccTransaction currAccTransaction =
                    _currAccranTransactionRepository.Get(x => x.TransactionType == cashTransaction.TransactionType &&
                                                          x.TransactionId == cashTransaction.TransactionId);

                // Cash account transaction
                cashTransaction.Description = txtDescription.Text;
                cashTransaction.DocumentNumber = txtDocumentNumber.Text;
                cashTransaction.CurrAccId = _currAccId;
                cashTransaction.TransactionType = txtTransactionType.SelectedItem.ToString();
                if (txtTransactionType.SelectedIndex == 0) cashTransaction.InOutCode = "In";
                if (txtTransactionType.SelectedIndex == 1) cashTransaction.InOutCode = "Out";
                cashTransaction.CashAccId = _cashAccId;
                cashTransaction.Date = DateTime.Parse(txtDate.Text);
                cashTransaction.Amount = decimal.Parse(txtAmount.Text.ToString());
                // Audit trail
                cashTransaction.UpdatedUserId = MainForm.UserId;
                cashTransaction.UpdatedDate = DateTime.Now;

                _cashTransactionRepository.Update(cashTransaction);
                _messages.Update();

                // Current account transaction
                currAccTransaction.Description = $@"Document Number :{txtDocumentNumber.Text} \n {txtTransactionType.SelectedItem}";
                if (txtTransactionType.SelectedIndex == 0) currAccTransaction.Credit = decimal.Parse(txtAmount.Text);
                if (txtTransactionType.SelectedIndex == 1) currAccTransaction.Debit = decimal.Parse(txtAmount.Text);
                currAccTransaction.CurrAccId = _currAccId;
                currAccTransaction.TransactionType = txtTransactionType.SelectedItem.ToString();
                currAccTransaction.Date = DateTime.Parse(txtDate.Text);
                if (txtTransactionType.SelectedIndex == 0) currAccTransaction.Type = "CC";
                if (txtTransactionType.SelectedIndex == 1) currAccTransaction.Type = "CD";
                // Audit trail
                currAccTransaction.UpdatedUserId = MainForm.UserId;
                currAccTransaction.UpdatedDate = DateTime.Now;

                _currAccranTransactionRepository.Update(currAccTransaction);
                _messages.Update();

                _unitOfWork.SaveChanges();
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
                _cashTransactionRepository.Delete(_transactionId);
                _currAccranTransactionRepository.Delete(_currAccTransactionId);
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
            ClearRecord();
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
            txtTransactionType.SelectedIndex = 0;
            txtDate.Text = DateTime.Now.ToShortDateString();
            _edit = false;
            _transactionId = -1;
            _cashAccId = -1;
            _currAccId = -1;
            _currAccTransactionId = -1;
            MainForm.Transfer = -1;
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
                _cashAccId = -1;
            }
        }

        void OpenCurrAcc(int id)
        {
            try
            {
                _currAccId = id;
                txtCurrAccCode.Text = _currAccRepository.GetById(_currAccId).CurrAccCode;
                txtCurrAccName.Text = _currAccRepository.GetById(_currAccId).CurrAccName;
            }
            catch (Exception)
            {
                _currAccId = -1;
            }
        }

        public void OpenCashDeposit(int transactionId)
        {
            try
            {
                _edit = true;
                _transactionId = transactionId;
                CashTransaction cashTransaction = _cashTransactionRepository.GetById(_transactionId);
                _currAccTransactionId = _currAccranTransactionRepository
                    .Get(x => x.TransactionType == cashTransaction.TransactionType && x.TransactionId == _transactionId)
                    .Id;
                MessageBox.Show("Current account transaction id : " + _currAccTransactionId);
                txtDescription.Text = cashTransaction.Description;
                txtDocumentNumber.Text = cashTransaction.DocumentNumber;
                if (cashTransaction.TransactionType == "Cash Credit") txtTransactionType.SelectedIndex = 0;
                if (cashTransaction.TransactionType == "Cash Ödeme") txtTransactionType.SelectedIndex = 0;
                txtDate.Text = cashTransaction.Date.Value.ToShortDateString();
                txtAmount.Text = cashTransaction.Amount.Value.ToString();
                OpenCashAcc(cashTransaction.CashAccId.Value);
                OpenCurrAcc(cashTransaction.CurrAccId.Value);
            }
            catch (Exception e)
            {
                ClearRecord();
                _messages.Error(e);
            }
        }
        #endregion
    }
}