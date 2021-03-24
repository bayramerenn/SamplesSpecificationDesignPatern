using Marketing.Infrastructure;
using Marketing.Infrastructure.Specifications;
using Marketing.Models;
using System;
using System.Linq;

namespace Marketing
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new ProductRepository(new StoreContext()))
            //{
            //    var result = context.GetProductAsync().Result;
            //}

            var respo = new GenericRepository<Product>();

            var spec = new ProductWithProdutctTypeAndBrandsSpec();

            var data = respo.ListAsync(spec).Result;



        }
    }
}
