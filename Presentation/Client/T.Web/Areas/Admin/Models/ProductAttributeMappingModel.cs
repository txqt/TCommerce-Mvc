﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using T.Library.Model.Catalogs;
using T.Library.Model.Common;

namespace T.Web.Areas.Admin.Models
{
    public class ProductAttributeMappingModel : BaseEntity
    {
        #region Ctor

        public ProductAttributeMappingModel()
        {
            AvailableProductAttributes = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        public int ProductId { get; set; }
        public int ProductAttributeId { get; set; }
        [Display(Name = "Tên thuộc tính")]
        public string ProductAttributeName { get; set; }
        public IList<SelectListItem> AvailableProductAttributes { get; set; }
        public string TextPrompt { get; set; }
        [Display(Name = "Bắt buộc")]
        public bool IsRequired { get; set; }
        [Display(Name = "Thứ tự hiển thị")]
        public int DisplayOrder { get; set; }
        [UIHint("Int32Nullable")]
        public int? ValidationMinLength { get; set; }
        [UIHint("Int32Nullable")]
        public int? ValidationMaxLength { get; set; }
        public string ValidationFileAllowedExtensions { get; set; }
        [UIHint("Int32Nullable")]
        public int? ValidationFileMaximumSize { get; set; }
        public string DefaultValue { get; set; }
        public int AttributeControlTypeId { get; set; }
        public AttributeControlType AttributeControlType
        {
            get => (AttributeControlType)AttributeControlTypeId;
            set => AttributeControlTypeId = (int)value;
        }

        #endregion
    }
}
