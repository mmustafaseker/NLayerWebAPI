﻿using Core.Entities;
using Core.Repository;
using Core.Service;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int ProductId)
        {
           return  await _unitOfWork.Product.GetWithCategoryByIdAsync(ProductId);
        }
    }
}
