﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using T.Library.Model.Catalogs;
using T.Library.Model.Interface;
using T.Web.Areas.Admin.Models;
using T.Web.Areas.Admin.Models.SearchModel;

namespace T.Web.Services.PrepareModelServices.PrepareAdminModel
{
    public interface ICategoryModelService
    {
        Task<CategoryModel> PrepareCategoryModelAsync(CategoryModel model, Category category);
        Task<ProductCategorySearchModel> PrepareAddProductToCategorySearchModel(ProductCategorySearchModel model);
    }
    public class CategoryModelService : ICategoryModelService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryServiceCommon _categoryService;
        private readonly IBaseAdminModelService _baseAdminModelService;

        public CategoryModelService(IMapper mapper, ICategoryServiceCommon categoryService, IBaseAdminModelService baseAdminModelService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
            _baseAdminModelService = baseAdminModelService;
        }

        public async Task<CategoryModel> PrepareCategoryModelAsync(CategoryModel model, Category category)
        {
            if (category is not null)
            {
                model ??= new CategoryModel()
                {
                    Id = category.Id
                };
                _mapper.Map(category, model);
            }

            await _baseAdminModelService.PrepareSelectListCategoryAsync(model.AvailableCategories);

            return model;
        }

        public async Task<ProductCategorySearchModel> PrepareAddProductToCategorySearchModel(ProductCategorySearchModel model)
        {
            await _baseAdminModelService.PrepareSelectListCategoryAsync(model.AvailableCategories);
            return model;
        }
    }
}
