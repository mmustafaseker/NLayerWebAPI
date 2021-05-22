using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                    new Product { Id = 1, Name = "Pilot Kalem", Price = 12.50m, Stok = 100, CategoryId = _ids[0] },
                    new Product { Id = 2, Name = "Kurşun Kalem", Price = 40m, Stok = 200, CategoryId = _ids[0] },
                    new Product { Id = 3, Name = "Tükenmez Kalem", Price = 500m, Stok = 300, CategoryId = _ids[0] },
                    new Product { Id = 4, Name = "Küçük Boy Defter", Price = 12.50m, Stok = 100, CategoryId = _ids[1] },
                    new Product { Id = 5, Name = "Orta Boy Defte", Price = 14.50m, Stok = 100, CategoryId = _ids[1] },
                    new Product { Id = 6, Name = "Büyük Boy Defte", Price = 16.50m, Stok = 100, CategoryId = _ids[1] }
                );
        }
    }
}
