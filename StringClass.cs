using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Utility
    {
        public static String dbConnection = @"Data Source=LAPTOP-ADN1IJSB;Initial Catalog=Inventory;Integrated Security=True";
        public static String frmTitle = "Inventory";

        public bool isOpen(Form form)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == form.Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
