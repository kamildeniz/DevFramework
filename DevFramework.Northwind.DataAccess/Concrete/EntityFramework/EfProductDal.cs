using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using DevFramework.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}