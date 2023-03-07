using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using DevFramework.Northwind.Entities;
using DevFramework.Core;


namespace DevFramework.Northwind.DataAccess.Tests.NHibernate.Test
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal productDal = new NhProductDal();
            var result = productDal.GetList();

            Assert.AreEqual(78, result.Count);
        }
        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            NhProductDal productDal = new NhProductDal();
            var result = productDal.GetList(p=>p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
        }
    }
}
