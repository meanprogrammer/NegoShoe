using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegoShoePH.Data
{
    public class SQLData
    {
        InventoryDataDataContext context = null;
        public SQLData()
        {
            context = new InventoryDataDataContext();
        }

        public void Execute(string query)
        {
            context.ExecuteCommand(query);
        }
    }
}
