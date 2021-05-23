using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.Web.DTO_s
{
    public class CategoryWithProductDto :CategoryDTO
    {
        public ICollection<ProductDto> Products { get; set; }
    }
}
