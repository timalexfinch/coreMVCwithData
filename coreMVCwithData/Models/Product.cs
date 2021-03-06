﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coreMVCwithData.Models
{
    public partial class Product
    {
        public Product()
        {
            SalesOrderDetail = new HashSet<SalesOrderDetail>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal StandardCost { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public decimal? Weight { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? ProductModelId { get; set; }

        [DataType(DataType.Date)]
        public DateTime SellStartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? SellEndDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DiscontinuedDate { get; set; }
        public byte[] ThumbNailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public Guid Rowguid { get; set; }

        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Category")]
        public ProductCategory ProductCategory { get; set; }
        [Display(Name = "Model")]
        public ProductModel ProductModel { get; set; }
        public ICollection<SalesOrderDetail> SalesOrderDetail { get; set; }
    }
}
