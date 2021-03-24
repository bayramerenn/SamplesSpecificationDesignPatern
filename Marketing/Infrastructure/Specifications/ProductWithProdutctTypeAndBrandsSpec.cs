using Marketing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketing.Infrastructure.Specifications
{
    public class ProductWithProdutctTypeAndBrandsSpec:BaseSpecification<Product>
    {
        public ProductWithProdutctTypeAndBrandsSpec()
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }
    }
}
