using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AWM.BusinessLayer;
using AWM.DataLayer;

namespace AdventureWorksManagement
{
    class MainWindowViewModel
    {
        ProductLogic pl = new ProductLogic();

        public MainWindowViewModel()
        {
            this.Products = pl.GetAllProducts();
        }

        public List<Product> Products { get; set; }
    }
}
