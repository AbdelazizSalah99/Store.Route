﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }
        public ProductBrand ProductBrand { get; set; } // Navigation property
        public int BrandId { get; set; } // Foreign key


        public ProductType ProductType { get; set; } // Navigation property
        public int TypeId { get; set; } // Foreign key
    }
}
