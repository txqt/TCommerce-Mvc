﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Library.Model.Paging
{
    public class ProductAttributeMappingPareameters : QueryStringParameters
    {
        public int ProductId { get; set; }
        public string? searchText { get; set; }
    }
}
