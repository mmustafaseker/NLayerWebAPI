using Core.Entities;
using Core.Repository;
using Core.Service;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithProductBtIdAsync(int categoryId)
        {
            return await _unitOfWork.Category.GetWithProductBtIdAsync(categoryId);
        }
    }
}
