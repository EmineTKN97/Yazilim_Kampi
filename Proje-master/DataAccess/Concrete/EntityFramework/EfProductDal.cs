using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepısitoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (var context = new NorthwindContext())
            {
                //ürünlerle kategorileri join etmiş oluyorum
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
            { ProductId = p.ProductId, ProductName =p.ProductName, CategoryName = c.CategoryName,UnitsInStock = p.UnitsInStock
            };
                return result.ToList();
            }
       
        }
    }
}
