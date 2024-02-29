using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstarct;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationException = FluentValidation.ValidationException;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _IProductDal;
        ICategoryService _categoryService;
        public ProductManager(IProductDal ProductDal, ICategoryService categoryService)
        {
            _IProductDal = ProductDal;
            _categoryService = categoryService;
        }
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Product product)
        {
           IResult  result =BusinessRules.Run(CheckİfProductCountOfCategoryCorrect(product.CategoryId), CheckİfProductNameExist(product.ProductName), CheckİfCategoryLimitExceded());
            if (result != null)
            {
                return result;
            }
       
            _IProductDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }
        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 12)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_IProductDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_IProductDal.GetProductDetails());
        }


        IDataResult<List<Product>> IProductService.GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_IProductDal.GetAll(p => p.CategoryId == id));
        }
        [CacheAspect(duration:10)]
        //Ürünün detayına inmek istediğimde kullanılır.
        IDataResult<Product> IProductService.GetById(int productİd)
        {
            return new SuccessDataResult<Product>(_IProductDal.Get(p => p.ProductId == productİd));
        }


        IDataResult<List<Product>> IProductService.GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_IProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        private IResult CheckİfProductCountOfCategoryCorrect(int categoryId)
        {
            var result = _IProductDal.GetAll(p =>p.CategoryId == categoryId).Count();
            if (result > 10)
            {
                return new ErrorResult(Messages.ProductCountOfCategoryError); 

            }
            return new SuccessResult();
        
        }
        private IResult CheckİfProductNameExist(string ProductName)
        {
            var result = _IProductDal.GetAll(p => p.ProductName == ProductName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);

            }
            return new SuccessResult();

        }
        private IResult CheckİfCategoryLimitExceded()
        {
            var result = _categoryService.GetAll();
            if (result.Data.Count>15)
            {
                return new ErrorResult(Messages.CategoryLimitExceded);

            }
            return new SuccessResult();

        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Product product)
        {
            _IProductDal.Update(product);
            _IProductDal.Add(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}


