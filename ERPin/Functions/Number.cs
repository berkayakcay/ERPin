using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPin.Functions
{
    class Number
    {
        ERPinEntities db = new ERPinEntities();
        Messages messages = new Messages();

        public string LastInventoryItemCode()
        {
            string num = "0000001";
            try
            {
                var firstOrDefault = db.InventoryGroup.OrderByDescending(x => x.GroupCode).FirstOrDefault();
                if (firstOrDefault != null)
                {
                    int number = int.Parse(firstOrDefault.ToString());
                    number++;
                    num = number.ToString().PadLeft(7, '0');
                    return num;
                }
            }
            catch (Exception)
            {
                
            }
            return num;

        }
    }
}
