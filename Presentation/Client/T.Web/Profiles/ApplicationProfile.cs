﻿using AutoMapper;
using T.Library.Model;
using T.Library.Model.Banners;
using T.Library.Model.Catalogs;
using T.Library.Model.Common;
using T.Library.Model.ViewsModel;
using T.Web.Areas.Admin.Models;
using T.Web.Models;

namespace T.Web.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Product, ProductModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ShortDescription, opt => opt.MapFrom(src => src.ShortDescription))
                .ForMember(dest => dest.FullDescription, opt => opt.MapFrom(src => src.FullDescription))
                .ForMember(dest => dest.StockQuantity, opt => opt.MapFrom(src => src.StockQuantity))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.OldPrice, opt => opt.MapFrom(src => src.OldPrice))
                .ForMember(dest => dest.MarkAsNew, opt => opt.MapFrom(src => src.MarkAsNew))
                .ForMember(dest => dest.MarkAsNewEndDateTimeUtc, opt => opt.MapFrom(src => src.MarkAsNewEndDateTimeUtc))
                .ForMember(dest => dest.MarkAsNewStartDateTimeUtc, opt => opt.MapFrom(src => src.MarkAsNewStartDateTimeUtc))
                .ForMember(dest => dest.DisplayOrder, opt => opt.MapFrom(src => src.DisplayOrder))
                .ForMember(dest => dest.Published, opt => opt.MapFrom(src => src.Published))
                .ForMember(dest => dest.VisibleIndividually, opt => opt.MapFrom(src => src.VisibleIndividually))
                .ForMember(dest => dest.AdminComment, opt => opt.MapFrom(src => src.AdminComment))
                .ForMember(dest => dest.ShowOnHomepage, opt => opt.MapFrom(src => src.ShowOnHomepage))
                .ForMember(dest => dest.MetaKeywords, opt => opt.MapFrom(src => src.MetaKeywords))
                .ForMember(dest => dest.MetaDescription, opt => opt.MapFrom(src => src.MetaDescription))
                .ForMember(dest => dest.MetaTitle, opt => opt.MapFrom(src => src.MetaTitle))
                .ForMember(dest => dest.AllowUserReviews, opt => opt.MapFrom(src => src.AllowUserReviews))
                .ForMember(dest => dest.Sku, opt => opt.MapFrom(src => src.Sku))
                .ForMember(dest => dest.IsShipEnabled, opt => opt.MapFrom(src => src.IsShipEnabled))
                .ForMember(dest => dest.IsFreeShipping, opt => opt.MapFrom(src => src.IsFreeShipping))
                .ForMember(dest => dest.OrderMinimumQuantity, opt => opt.MapFrom(src => src.OrderMinimumQuantity))
                .ForMember(dest => dest.OrderMaximumQuantity, opt => opt.MapFrom(src => src.OrderMaximumQuantity))
                .ForMember(dest => dest.NotReturnable, opt => opt.MapFrom(src => src.NotReturnable))
                .ForMember(dest => dest.DisableBuyButton, opt => opt.MapFrom(src => src.DisableBuyButton))
                .ForMember(dest => dest.AvailableForPreOrder, opt => opt.MapFrom(src => src.AvailableForPreOrder))
                .ForMember(dest => dest.PreOrderAvailabilityStartDateTimeUtc, opt => opt.MapFrom(src => src.PreOrderAvailabilityStartDateTimeUtc))
                .ForMember(dest => dest.Weight, opt => opt.MapFrom(src => src.Weight))
                .ForMember(dest => dest.Length, opt => opt.MapFrom(src => src.Length))
                .ForMember(dest => dest.Width, opt => opt.MapFrom(src => src.Width))
                .ForMember(dest => dest.Height, opt => opt.MapFrom(src => src.Height))
                .ForMember(dest => dest.AvailableStartDateTimeUtc, opt => opt.MapFrom(src => src.AvailableStartDateTimeUtc))
                .ForMember(dest => dest.AvailableEndDateTimeUtc, opt => opt.MapFrom(src => src.AvailableEndDateTimeUtc))
                .ForMember(dest => dest.CreatedOnUtc, opt => opt.MapFrom(src => src.CreatedOnUtc))
                .ForMember(dest => dest.UpdatedOnUtc, opt => opt.MapFrom(src => src.UpdatedOnUtc))
                .ReverseMap();

            CreateMap<ProductEditModel, ProductModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ShortDescription, opt => opt.MapFrom(src => src.ShortDescription))
                .ForMember(dest => dest.FullDescription, opt => opt.MapFrom(src => src.FullDescription))
                .ForMember(dest => dest.StockQuantity, opt => opt.MapFrom(src => src.StockQuantity))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.OldPrice, opt => opt.MapFrom(src => src.OldPrice))
                .ForMember(dest => dest.MarkAsNew, opt => opt.MapFrom(src => src.MarkAsNew))
                .ForMember(dest => dest.MarkAsNewEndDateTimeUtc, opt => opt.MapFrom(src => src.MarkAsNewEndDateTimeUtc))
                .ForMember(dest => dest.MarkAsNewStartDateTimeUtc, opt => opt.MapFrom(src => src.MarkAsNewStartDateTimeUtc))
                .ForMember(dest => dest.DisplayOrder, opt => opt.MapFrom(src => src.DisplayOrder))
                .ForMember(dest => dest.Published, opt => opt.MapFrom(src => src.Published))
                .ForMember(dest => dest.VisibleIndividually, opt => opt.MapFrom(src => src.VisibleIndividually))
                .ForMember(dest => dest.AdminComment, opt => opt.MapFrom(src => src.AdminComment))
                .ForMember(dest => dest.ShowOnHomepage, opt => opt.MapFrom(src => src.ShowOnHomepage))
                .ForMember(dest => dest.MetaKeywords, opt => opt.MapFrom(src => src.MetaKeywords))
                .ForMember(dest => dest.MetaDescription, opt => opt.MapFrom(src => src.MetaDescription))
                .ForMember(dest => dest.MetaTitle, opt => opt.MapFrom(src => src.MetaTitle))
                .ForMember(dest => dest.AllowUserReviews, opt => opt.MapFrom(src => src.AllowUserReviews))
                .ForMember(dest => dest.Sku, opt => opt.MapFrom(src => src.Sku))
                .ForMember(dest => dest.IsShipEnabled, opt => opt.MapFrom(src => src.IsShipEnabled))
                .ForMember(dest => dest.IsFreeShipping, opt => opt.MapFrom(src => src.IsFreeShipping))
                .ForMember(dest => dest.OrderMinimumQuantity, opt => opt.MapFrom(src => src.OrderMinimumQuantity))
                .ForMember(dest => dest.OrderMaximumQuantity, opt => opt.MapFrom(src => src.OrderMaximumQuantity))
                .ForMember(dest => dest.NotReturnable, opt => opt.MapFrom(src => src.NotReturnable))
                .ForMember(dest => dest.DisableBuyButton, opt => opt.MapFrom(src => src.DisableBuyButton))
                .ForMember(dest => dest.AvailableForPreOrder, opt => opt.MapFrom(src => src.AvailableForPreOrder))
                .ForMember(dest => dest.PreOrderAvailabilityStartDateTimeUtc, opt => opt.MapFrom(src => src.PreOrderAvailabilityStartDateTimeUtc))
                .ForMember(dest => dest.Weight, opt => opt.MapFrom(src => src.Weight))
                .ForMember(dest => dest.Length, opt => opt.MapFrom(src => src.Length))
                .ForMember(dest => dest.Width, opt => opt.MapFrom(src => src.Width))
                .ForMember(dest => dest.Height, opt => opt.MapFrom(src => src.Height))
                .ForMember(dest => dest.AvailableStartDateTimeUtc, opt => opt.MapFrom(src => src.AvailableStartDateTimeUtc))
                .ForMember(dest => dest.AvailableEndDateTimeUtc, opt => opt.MapFrom(src => src.AvailableEndDateTimeUtc))
                .ForMember(dest => dest.CreatedOnUtc, opt => opt.MapFrom(src => src.CreatedOnUtc))
                .ForMember(dest => dest.UpdatedOnUtc, opt => opt.MapFrom(src => src.UpdatedOnUtc))
                .ReverseMap();

            CreateMap<Product, ProductEditModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ShortDescription, opt => opt.MapFrom(src => src.ShortDescription))
                .ForMember(dest => dest.FullDescription, opt => opt.MapFrom(src => src.FullDescription))
                .ForMember(dest => dest.StockQuantity, opt => opt.MapFrom(src => src.StockQuantity))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.OldPrice, opt => opt.MapFrom(src => src.OldPrice))
                .ForMember(dest => dest.MarkAsNew, opt => opt.MapFrom(src => src.MarkAsNew))
                .ForMember(dest => dest.MarkAsNewEndDateTimeUtc, opt => opt.MapFrom(src => src.MarkAsNewEndDateTimeUtc))
                .ForMember(dest => dest.MarkAsNewStartDateTimeUtc, opt => opt.MapFrom(src => src.MarkAsNewStartDateTimeUtc))
                .ForMember(dest => dest.DisplayOrder, opt => opt.MapFrom(src => src.DisplayOrder))
                .ForMember(dest => dest.Published, opt => opt.MapFrom(src => src.Published))
                .ForMember(dest => dest.VisibleIndividually, opt => opt.MapFrom(src => src.VisibleIndividually))
                .ForMember(dest => dest.AdminComment, opt => opt.MapFrom(src => src.AdminComment))
                .ForMember(dest => dest.ShowOnHomepage, opt => opt.MapFrom(src => src.ShowOnHomepage))
                .ForMember(dest => dest.MetaKeywords, opt => opt.MapFrom(src => src.MetaKeywords))
                .ForMember(dest => dest.MetaDescription, opt => opt.MapFrom(src => src.MetaDescription))
                .ForMember(dest => dest.MetaTitle, opt => opt.MapFrom(src => src.MetaTitle))
                .ForMember(dest => dest.AllowUserReviews, opt => opt.MapFrom(src => src.AllowUserReviews))
                .ForMember(dest => dest.Sku, opt => opt.MapFrom(src => src.Sku))
                .ForMember(dest => dest.IsShipEnabled, opt => opt.MapFrom(src => src.IsShipEnabled))
                .ForMember(dest => dest.IsFreeShipping, opt => opt.MapFrom(src => src.IsFreeShipping))
                .ForMember(dest => dest.OrderMinimumQuantity, opt => opt.MapFrom(src => src.OrderMinimumQuantity))
                .ForMember(dest => dest.OrderMaximumQuantity, opt => opt.MapFrom(src => src.OrderMaximumQuantity))
                .ForMember(dest => dest.NotReturnable, opt => opt.MapFrom(src => src.NotReturnable))
                .ForMember(dest => dest.DisableBuyButton, opt => opt.MapFrom(src => src.DisableBuyButton))
                .ForMember(dest => dest.AvailableForPreOrder, opt => opt.MapFrom(src => src.AvailableForPreOrder))
                .ForMember(dest => dest.PreOrderAvailabilityStartDateTimeUtc, opt => opt.MapFrom(src => src.PreOrderAvailabilityStartDateTimeUtc))
                .ForMember(dest => dest.Weight, opt => opt.MapFrom(src => src.Weight))
                .ForMember(dest => dest.Length, opt => opt.MapFrom(src => src.Length))
                .ForMember(dest => dest.Width, opt => opt.MapFrom(src => src.Width))
                .ForMember(dest => dest.Height, opt => opt.MapFrom(src => src.Height))
                .ForMember(dest => dest.AvailableStartDateTimeUtc, opt => opt.MapFrom(src => src.AvailableStartDateTimeUtc))
                .ForMember(dest => dest.AvailableEndDateTimeUtc, opt => opt.MapFrom(src => src.AvailableEndDateTimeUtc))
                .ForMember(dest => dest.CreatedOnUtc, opt => opt.MapFrom(src => src.CreatedOnUtc))
                .ForMember(dest => dest.UpdatedOnUtc, opt => opt.MapFrom(src => src.UpdatedOnUtc))
                .ForMember(dest => dest.AvailableCategories, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ProductAttributeMappingModel, ProductAttributeMapping>()
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.ProductAttributeId, opt => opt.MapFrom(src => src.ProductAttributeId))
                .ForMember(dest => dest.TextPrompt, opt => opt.MapFrom(src => src.TextPrompt))
                .ForMember(dest => dest.IsRequired, opt => opt.MapFrom(src => src.IsRequired))
                .ForMember(dest => dest.DisplayOrder, opt => opt.MapFrom(src => src.DisplayOrder))
                .ForMember(dest => dest.ValidationMinLength, opt => opt.MapFrom(src => src.ValidationMinLength))
                .ForMember(dest => dest.ValidationMaxLength, opt => opt.MapFrom(src => src.ValidationMaxLength))
                .ForMember(dest => dest.ValidationFileAllowedExtensions, opt => opt.MapFrom(src => src.ValidationFileAllowedExtensions))
                .ForMember(dest => dest.ValidationFileMaximumSize, opt => opt.MapFrom(src => src.ValidationFileMaximumSize))
                .ForMember(dest => dest.DefaultValue, opt => opt.MapFrom(src => src.DefaultValue))
                //.ForMember(dest => dest.ValidationRulesString, opt => opt.MapFrom(src => src.ValidationRulesString))
                .ForPath(dest => dest.ProductAttribute.Name, opt => opt.MapFrom(src => src.ProductAttributeName))
                .AfterMap((src, dest) => dest.ProductAttribute = null)
                .ReverseMap();

            CreateMap<ProductAttributeValue, ProductAttributeValueModel>()
                .ForMember(dest => dest.ProductAttributeMappingId, opt => opt.MapFrom(src => src.ProductAttributeMappingId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ColorSquaresRgb, opt => opt.MapFrom(src => src.ColorSquaresRgb))
                .ForMember(dest => dest.PriceAdjustment, opt => opt.MapFrom(src => src.PriceAdjustment))
                .ForMember(dest => dest.PriceAdjustmentUsePercentage, opt => opt.MapFrom(src => src.PriceAdjustmentUsePercentage))
                .ForMember(dest => dest.WeightAdjustment, opt => opt.MapFrom(src => src.WeightAdjustment))
                .ForMember(dest => dest.Cost, opt => opt.MapFrom(src => src.Cost))
                .ForMember(dest => dest.CustomerEntersQty, opt => opt.MapFrom(src => src.CustomerEntersQty))
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.IsPreSelected, opt => opt.MapFrom(src => src.IsPreSelected))
                .ForMember(dest => dest.DisplayOrder, opt => opt.MapFrom(src => src.DisplayOrder))
                .ReverseMap();
            CreateMap<Category, CategoryModel>()
                .ReverseMap();

            CreateMap<UserModel, UserViewModel>()
                .ReverseMap();
            CreateMap<ProductCategoryModel, ProductCategory>()
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.IsFeaturedProduct, opt => opt.MapFrom(src => src.IsFeaturedProduct))
                .ForMember(dest => dest.DisplayOrder, opt => opt.MapFrom(src => src.DisplayOrder))
                .ForMember(dest => dest.Category, opt => opt.Ignore())
                .ForMember(dest => dest.Product, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ProductManufacturerModel, ProductManufacturer>()
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.ManufacturerId, opt => opt.MapFrom(src => src.ManufacturerId))
                .ForMember(dest => dest.IsFeaturedProduct, opt => opt.MapFrom(src => src.IsFeaturedProduct))
                .ForMember(dest => dest.DisplayOrder, opt => opt.MapFrom(src => src.DisplayOrder))
                .ForMember(dest => dest.Manufacturer, opt => opt.Ignore())
                .ForMember(dest => dest.Product, opt => opt.Ignore())
                .ReverseMap();

            //CreateMap<RelatedProductModel, RelatedProduct>()
            //    .ForMember(dest => dest.ProductId2, opt => opt.MapFrom(src=>src.ProductId2))
            //    .ReverseMap();

            CreateMap<BannerViewModel, Banner>()
                .ReverseMap();

            CreateMap<T.Web.Models.Catalog.CategoryModel, Category>()
                .ReverseMap();

            CreateMap<CategoryModelAdmin, Category>()
                .ReverseMap();

            CreateMap<AddressModel, Address>()
                .ReverseMap();
        }
    }
}
