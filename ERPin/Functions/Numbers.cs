using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPin.Functions
{
    class Numbers
    {
        private readonly ERPinEntities _db = new ERPinEntities();

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
                    num = number.ToString().PadLeft(8 - lenHelper(number), '0');
                    return num;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return num;

        }

        public string LastCurrAccCode()
        {
            string num = "";
            try
            {
                var firstOrDefault = _db.CurrAcc.OrderByDescending(x => x.CurrAccCode).Select(s => s.CurrAccCode).FirstOrDefault();
                if (firstOrDefault!=null)
                {
                    int number = int.Parse(firstOrDefault);
                    number++;
                    num = number.ToString().PadLeft(5 - lenHelper(number), '0');
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

        int lenHelper(int x)
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
