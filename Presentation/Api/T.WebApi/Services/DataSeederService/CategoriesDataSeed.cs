﻿using T.Library.Model.Catalogs;
using T.WebApi.Extensions;

namespace T.WebApi.Services.DataSeederService
{
    public class CategoriesDataSeed : SingletonBase<CategoriesDataSeed>
    {
        public static readonly string Fashion = "Thời trang";
        public static readonly string Electronic = "Điện tử";
        public static readonly string Electric_Appliances = "Điện gia dụng";
        public static readonly string Accessory = "Phụ kiện";
        public List<Category> GetAll()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Name = Fashion.ToString(),
                    ShowOnHomepage = true,
                    Published = true,
                    CreatedOnUtc = DateTime.Now,
                    Description = Fashion.ToString(),
                },
                new Category()
                {
                    Name = Electronic.ToString(),
                    ShowOnHomepage = true,
                    Published = true,
                    CreatedOnUtc = DateTime.Now,
                    Description = Electronic.ToString(),
                },
                new Category()
                {
                    Name = Electric_Appliances.ToString(),
                    ShowOnHomepage = true,
                    Published = true,
                    CreatedOnUtc = DateTime.Now,
                    Description = Electric_Appliances.ToString(),
                },
                new Category()
                {
                    Name = Accessory.ToString(),
                    ShowOnHomepage = true,
                    Published = true,
                    CreatedOnUtc = DateTime.Now,
                    Description = Accessory.ToString(),
                },
            };
        }
    }
}
