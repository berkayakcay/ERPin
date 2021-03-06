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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region Methods
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
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
        }

        void ClearRecord()
        {
            IEnumerable<TextEdit> list = groupControlCashAccInfo.Controls.OfType<TextEdit>();
            foreach (TextEdit textEdit in list)
            {
                textEdit.Text = "";
            }

            _edit = false;
            _selectionId = -1;
        }
        #endregion
    }
}