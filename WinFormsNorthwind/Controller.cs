using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WinFormsNorthwind
{
    public static class Controller
    {
        public static List<Supplier> GetSuppliers()
        {
            try
            {
                using (var db = new NorthwindContext())
                {
                    var lst = db.Suppliers.ToList();
                    if (lst != null) return lst;
                    else return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
