using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.Web.DTO_s
{
    public class ProductwithCategory : ProductDto
    {
        public CategoryDTO Category { get; set; }
    }
}
