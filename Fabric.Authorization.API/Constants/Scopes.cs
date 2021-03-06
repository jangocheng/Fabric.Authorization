﻿namespace Fabric.Authorization.API.Constants
{
    public static class Scopes
    {
        public static readonly string ReadScope = "fabric/authorization.read";
        public static readonly string WriteScope = "fabric/authorization.write";
        public static readonly string ManageClientsScope = "fabric/authorization.manageclients";
        public static readonly string ManageDosScope = "fabric/authorization.dos.write";
    }

    public static class IdentityScopes
    {
        public static readonly string ReadScope = "fabric/identity.read";
        public static readonly string SearchUsersScope = "fabric/identity.searchusers";
    }
}