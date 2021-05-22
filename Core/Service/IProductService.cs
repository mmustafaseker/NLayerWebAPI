using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface IProductService :IService<Product>
    {
        //product nesnesi üzerinde sadece ver tabanıyla işlemimiz olmayabilir. Bundan dolayı service oluşturabiliriz.
        //bool ControlInnerBarcode(Product product);

        Task<Product> GetWithCategoryByIdAsync(int ProductId);

    }
}
