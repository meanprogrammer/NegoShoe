using NegoShoePH.Common;
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
                    string itemsTblName = "dbo.Items";
                    string itemBrandTblName = "dbo.ItemBrand";
                    string itemTypeTblName = "dbo.ItemType";

                    //Items
                    int result = context.ExecuteCommand(string.Format("IF OBJECT_ID('{0}', 'U') IS NOT NULL DROP TABLE {1};", itemsTblName, itemsTblName));
                    result = context.ExecuteCommand(NegoShoePH.Common.Resources.CREATE_ITEMS_TABLE);

                    //ItemBrand
                    result = context.ExecuteCommand(string.Format("IF OBJECT_ID('{0}', 'U') IS NOT NULL DROP TABLE {1};", itemBrandTblName, itemBrandTblName));
                    result = context.ExecuteCommand(Resources.CREATE_ITEMBRAND_TABLE);
                    //insert
                    result = context.ExecuteCommand(Resources.INSERT_ITEMBRAND_DATA);

                    //ItemType
                    result = context.ExecuteCommand(string.Format("IF OBJECT_ID('{0}', 'U') IS NOT NULL DROP TABLE {1};", itemTypeTblName, itemTypeTblName));
                    result = context.ExecuteCommand(Resources.CREATE_ITEMTYPE_TABLE);
                    //insert
                    result = context.ExecuteCommand(Resources.INSERT_ITEMTYPE_DATA);

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
