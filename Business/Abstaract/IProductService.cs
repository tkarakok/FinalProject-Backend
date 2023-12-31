﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstaract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByUnitPrice(decimal min , decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
        IResult Update(Product product);
        IDataResult<Product> GetById(int productId);

        IResult AddTransactionalTest(Product product);

    }
}
