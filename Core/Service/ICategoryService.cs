using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface ICategoryService : IService<Category>
    {
        Task<Category> GetWithProductBtIdAsync(int categoryId);
    }
}
