﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

//ProductTest();
//CategoryTest();

/*static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    var result = productManager.GetProductDetails();
    if (result.Success == true)
    {
        foreach (var product in productManager.GetProductDetails().Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}
  

static void CategoryTest()
{
    CategoryManager categoryManager = new(new EFCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);

    }
}*/