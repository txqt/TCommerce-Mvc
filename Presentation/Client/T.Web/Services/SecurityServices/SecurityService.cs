﻿using Microsoft.CodeAnalysis;
using System.Net;
using T.Library.Model;
using T.Library.Model.Interface;
using T.Library.Model.Response;
using T.Library.Model.Security;
using T.Library.Model.Users;

namespace T.Web.Services.SecurityServices
{
    public class SecurityService : ISecurityService
    {
        private readonly HttpClient _httpClient;
        public SecurityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Role>> GetRoles()
        {
            var result = await _httpClient.GetAsync($"api/security/roles");
            return await result.Content.ReadFromJsonAsync<List<Role>>();
        }

        public async Task<List<PermissionRecord>> GetAllPermissionRecordAsync()
        {
            var result = await _httpClient.GetAsync($"api/security/permissions");
            return await result.Content.ReadFromJsonAsync<List<PermissionRecord>>();
        }

        public async Task<ServiceResponse<Role>> GetRoleByRoleId(string roleId)
        {
            var result = await _httpClient.GetAsync($"api/security/role/{roleId}");
            return await result.Content.ReadFromJsonAsync<ServiceResponse<Role>>();
        }

        public async Task<ServiceResponse<bool>> CreatePermissionMappingAsync(PermissionRecordUserRoleMapping permissionRecordUserRoleMapping)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/security/permission-mapping", permissionRecordUserRoleMapping);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }

        public async Task<ServiceResponse<bool>> DeletePermissionRecordByIdAsync(int permissionMapping)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<PermissionRecordUserRoleMapping>> GetPermissionMappingAsync(string roleId, int permissionId)
        {
            var result = await _httpClient.GetAsync($"api/security/role/{roleId}/permission/{permissionId}");
            return await result.Content.ReadFromJsonAsync<ServiceResponse<PermissionRecordUserRoleMapping>>();
        }


        public Task<ServiceResponse<PermissionRecord>> GetPermissionRecordByIdAsync(int permissionRecordId)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<PermissionRecord>> GetPermissionRecordBySystemNameAsync(string permissionRecordSystemName)
        {
            var result = await _httpClient.GetAsync($"api/security/permission/system-name/{permissionRecordSystemName}");
            return await result.Content.ReadFromJsonAsync<ServiceResponse<PermissionRecord>>();
        }

        public Task<ServiceResponse<List<PermissionRecord>>> GetPermissionRecordsByCustomerRoleIdAsync(Guid roleId)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<bool>> CreatePermissionRecord(PermissionRecord permissionRecord)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<bool>> UpdatePermissionRecord(PermissionRecord permissionRecord)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AuthorizeAsync(PermissionRecord permissionRecord)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/security/authorize-permission", permissionRecord);

            if (result.StatusCode == HttpStatusCode.Forbidden)
            {
                // Handle the Forbidden error...
                return false;
            }
            else if (!result.IsSuccessStatusCode)
            {
                // Handle other possible errors...
                return false;
            }

            return await result.Content.ReadFromJsonAsync<bool>();
        }
        public async Task<bool> AuthorizeAsync(string permissionRecordSystemName)
        {
            var result = await _httpClient.GetAsync($"api/security/authorize-permission/system-name/{permissionRecordSystemName}");

            if (result.StatusCode == HttpStatusCode.Forbidden)
            {
                // Handle the Forbidden error...
                return false;
            }
            else if (!result.IsSuccessStatusCode)
            {
                // Handle other possible errors...
                return false;
            }

            return await result.Content.ReadFromJsonAsync<bool>();
        }

        [Obsolete]
        public Task<bool> AuthorizeAsync(string permissionSystemName, User user)
        {
            throw new NotImplementedException();
        }
        [Obsolete]
        public Task<bool> AuthorizeAsync(string permissionSystemName, Guid roleId)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<bool>> DeletePermissionMappingByIdAsync(int mappingId)
        {
            var result = await _httpClient.DeleteAsync($"api/security/permission-mapping/{mappingId}");
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }

    }
}
