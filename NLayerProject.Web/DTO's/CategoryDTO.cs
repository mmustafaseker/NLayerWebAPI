﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.Web.DTO_s
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} alanı zorunludur")]
        public string Name { get; set; }
    }
}
