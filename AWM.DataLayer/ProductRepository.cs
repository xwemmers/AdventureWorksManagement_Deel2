using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWM.DataLayer
{
    public class ProductRepository
    {
        AdventureWorksEntities ctx = new AdventureWorksEntities();

        public ProductRepository()
        {

        }

        public List<Product> GetAllProducts()
        {
            return ctx.Products.AsNoTracking().ToList();
        }

        public void SaveProduct(Product p)
        {
            ctx.Entry(p).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
