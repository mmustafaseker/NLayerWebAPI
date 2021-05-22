using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IProductRepository :IRepository<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int ProductId);
    }
}
