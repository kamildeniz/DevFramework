using DevFramework.Core.DataAccess;
using DevFramework.Northwind.Entities.Concrete;
using DevFramework.Northwind.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;
namespace DevFramework.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
