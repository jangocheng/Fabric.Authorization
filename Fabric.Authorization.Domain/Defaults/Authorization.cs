﻿using System.Collections.Generic;
using Fabric.Authorization.Domain.Models;

namespace Fabric.Authorization.Domain.Defaults
{
    public class Authorization
    {
        public static readonly string AppGrain = "app";
        public static readonly string DosGrain = "dos";
        public static readonly string ManageAuthorizationPermissionName = "manageauthorization";
        public static readonly string InstallerClientId = "fabric-installer";

        public IList<Grain> Grains { get; }
        public IList<Role> Roles { get; }

        public Authorization()
        {
            Grains = new List<Grain>
            {
                new Grain
                {
                    Name = AppGrain
                },
                new Grain
                {
                    Name = DosGrain,
                    IsShared = true,
                    RequiredWriteScopes = new List<string> { "fabric/authorization.dos.write" },
                    SecurableItems = new List<SecurableItem>
                    {
                        new SecurableItem
                        {
                            Name = "datamarts",
                            ClientOwner = "dos-metadata-service"
                        }
                    }
                }
            };

            Roles = new List<Role>
            {
                new Role
                {
                    Name = "dosadmin",
                    Grain = DosGrain,
                    SecurableItem = "datamarts",
                    Permissions = new List<Permission>
                    {
                        new Permission
                        {
                            Name = ManageAuthorizationPermissionName,
                            Grain = "dos",
                            SecurableItem = "datamarts"
                        }
                    }
                }
            };
        }
    }
}
