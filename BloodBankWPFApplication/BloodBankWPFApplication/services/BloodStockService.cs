using System;
using BloodBankWPFApplication;

namespace services
{
    internal class BloodStockService
    {
        //method to add new blood stock info
        internal int AddBloodStock(BloodStock bloodstock)
        {
            using (var bbContext = new BloodBankDBEntities())
            {
                bbContext.BloodStocks.Add(bloodstock);
                bbContext.SaveChanges();
            }
            return 0;
        }
    }
}