using System;
using ERPin.Models;
using ERPin.Repositories;
using ERPin.UnitOfWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ERPin.Test
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class EntityTest
    {

        private ERPinDbContext _dbContext;
        private IUnitOfWork _unitOfWork;
        private IRepository<CurrAcc> _currAccRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _dbContext = new ERPinDbContext();

            _unitOfWork = new EfUnitOfWork(_dbContext);
            _currAccRepository = _unitOfWork.GetRepository<CurrAcc>();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _dbContext = null;
            _unitOfWork.Dispose();
        }

        [TestMethod]
        public void AddCurrAcc()
        {

        }
    }
}
