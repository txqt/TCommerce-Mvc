﻿using T.Library.Model.Banners;
using T.Library.Model.Common;
using T.Library.Model.Interface;
using T.Library.Model.Response;
using T.Library.Model.ViewsModel;
using T.Web.Helpers;

namespace T.Web.Services.BannerServices
{
    public class BannerService : IBannerService
    {
        private readonly HttpClientHelper _httpClientHelper;
        private readonly string defaulApiRoute = "api/banner/";
        public BannerService(HttpClientHelper httpClientHelper)
        {
            _httpClientHelper = httpClientHelper;
        }

        public async Task<List<Banner>> GetAllBannerAsync()
        {
            return await _httpClientHelper.GetAsync<List<Banner>>($"{defaulApiRoute + APIRoutes.GETALL}");
        }

        public async Task<Banner> GetBannerByIdAsync(int id)
        {
            return await _httpClientHelper.GetAsync<Banner>($"{defaulApiRoute + id}");
        }

        public async Task<ServiceResponse<bool>> CreateBannerAsync(BannerViewModel banner)
        {
            return await _httpClientHelper.PostWithFormFileAsync<ServiceResponse<bool>>($"{defaulApiRoute}", banner, banner.ImageFile);
        }

        public async Task<ServiceResponse<bool>> UpdateBannerAsync(BannerViewModel banner)
        {
            return await _httpClientHelper.PutWithFormFileAsync<ServiceResponse<bool>>($"{defaulApiRoute}", banner, banner.ImageFile);
        }

        public async Task<ServiceResponse<bool>> DeleteBannerByIdAsync(int id)
        {
            return await _httpClientHelper.DeleteAsync<ServiceResponse<bool>>($"{defaulApiRoute + id}");
        }
    }
}
