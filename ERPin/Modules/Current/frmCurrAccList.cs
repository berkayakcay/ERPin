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
    public partial class FrmCurrAccList : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private ERPinDbContext _dbContext;
        private IUnitOfWork _unitOfWork;
        private IRepository<CurrAcc> _currAccRepository;

        public bool Selection = false;
        private int _selectionId = -1;
        #endregion

        #region Events
        public FrmCurrAccList()
        {
            InitializeComponent();

            _dbContext = new ERPinDbContext();
            _unitOfWork = new EfUnitOfWork(_dbContext);
            _currAccRepository = _unitOfWork.GetRepository<CurrAcc>();
        }

        private void frmCurrAccList_Load(object sender, EventArgs e)
        {
            ListRecord();
        }
        #endregion

        #region Methods
        void ListRecord()
        {
            var list = _currAccRepository.GetAll().Where(s => s.CurrAccCode.Contains(txtCurrAccCode.Text) && s.CurrAccName.Contains(txtCurrAccName.Text)).ToList();
            gcList.DataSource = list;
        }

        void SelectRecord()
        {
            try
            {
                _selectionId = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            }
            catch (Exception)
            {
                _selectionId = -1;
            }
        }
        #endregion

        private void gcList_DoubleClick(object sender, EventArgs e)
        {
            SelectRecord();
            if (Selection && _selectionId > 0)
            {
                MainForm.Transfer = _selectionId;
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }
    }
}