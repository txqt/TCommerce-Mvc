﻿using T.Library.Model.Catalogs;
using T.Library.Model.Common;

namespace T.Library.Model
{
    /// <summary>
    /// Represents a product category mapping
    /// </summary>
    public partial class ProductCategory : BaseEntity
    {
        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the category identifier
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the product is featured
        /// </summary>
        public bool IsFeaturedProduct { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        public Category? Category { get; set; }

        public Product? Product { get; set;}
    }
}
