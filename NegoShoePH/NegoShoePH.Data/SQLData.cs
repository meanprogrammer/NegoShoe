using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace NegoShoePH.Data
{
    public class SQLData
    {
        InventoryDataDataContext context = null;
        public SQLData()
        {
            context = new InventoryDataDataContext();
        }

        public int Execute(string query)
        {
            return context.ExecuteCommand(query);
        }

        public void ResetDatabase()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                  
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    
                    //throw;
                    Transaction.Current.Rollback(ex);
                }
            }
        }
    }
}
