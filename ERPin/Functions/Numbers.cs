using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPin.Models;

namespace ERPin.Functions
{
    class Numbers
    {
        private readonly ERPinDbContext _db = new ERPinDbContext();

        /// <summary>
        /// Get lastest item account code from database
        /// </summary>
        /// <returns></returns>
        public string LastInventoryItemCode()
        {
            string num = "";
            try
            {
                var firstOrDefault = _db.Inventory.OrderByDescending(x => x.ItemCode).Select(s => s.ItemCode).FirstOrDefault();
                if (firstOrDefault != null)
                {
                    int number = int.Parse(firstOrDefault);
                    number++;
                    num = number.ToString().PadLeft(8 - LenHelper(number), '0');
                    return num;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return num;

        }

        /// <summary>
        /// Get lastest current account code from database
        /// </summary>
        /// <returns></returns>
        public string LastCurrAccCode()
        {
            string num = "00001";
            try
            {
                var firstOrDefault = _db.CurrAcc.OrderByDescending(x => x.CurrAccCode).Select(s => s.CurrAccCode).FirstOrDefault();
                if (firstOrDefault != null)
                {
                    int number = int.Parse(firstOrDefault);
                    number++;
                    num = number.ToString().PadLeft(5 - LenHelper(number), '0');
                    return num;
                }
                return num;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return num;
        }

        /// <summary>
        /// Get lastest cash account code from database
        /// </summary>
        /// <returns></returns>
        public string LastCashAccCode()
        {
            string num = "00001";
            try
            {
                var firstOrDefault = _db.CashAcc.OrderByDescending(x => x.CashAccCode).Select(s => s.CashAccCode).FirstOrDefault();
                if (firstOrDefault != null)
                {
                    int number = int.Parse(firstOrDefault);
                    number++;
                    num = number.ToString().PadLeft(5 - LenHelper(number), '0');
                    return num;
                }
                return num;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return num;
        }
        
        int LenHelper(int x)
        {
            if (x >= 1000000000) return 10;
            if (x >= 100000000) return 9;
            if (x >= 10000000) return 8;
            if (x >= 1000000) return 7;
            if (x >= 100000) return 6;
            if (x >= 10000) return 5;
            if (x >= 1000) return 4;
            if (x >= 100) return 3;
            if (x >= 10) return 2;
            return 1;
        }
    }
}
