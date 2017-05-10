﻿using System;
using System.Collections.Generic;
using Fabric.Authorization.Domain.Models;
using Fabric.Authorization.Domain.Stores;
using Fabric.Authorization.Domain.Validators;
using FluentValidation.Results;

namespace Fabric.Authorization.Domain.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionStore _permissionStore;

        public PermissionService(IPermissionStore permissionStore)
        {
            _permissionStore = permissionStore ?? throw new ArgumentNullException(nameof(permissionStore));
        }
        public IEnumerable<Permission> GetPermissions(string grain = null, string resource = null, string permissionName = null)
        {
            return _permissionStore.GetPermissions(grain, resource, permissionName);
        }

        public Permission GetPermission(Guid permissionId)
        {
            return _permissionStore.GetPermission(permissionId);
        }

        public Permission AddPermission(Permission permission)
        {
            return _permissionStore.AddPermission(permission);
        }

        public void DeletePermission(Permission permission)
        {
            _permissionStore.DeletePermission(permission);
        }
    }
}
