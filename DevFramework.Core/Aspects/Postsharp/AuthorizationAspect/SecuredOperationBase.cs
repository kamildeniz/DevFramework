﻿using PostSharp.Aspects;
using System;
using System.Security;

namespace DevFramework.Core.Aspects.Postsharp.AuthorizationAspect
{
    [Serializable]
    public class SecuredOperationBase
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            string[] roles = Roles.Split(',');
            bool isAuthorized = false;
            for (int i = 0; i < roles.Length; i++)
            {
                if (System.Threading.Thread.CurrentPrincipal.IsInRole(roles[i]))
                {
                    isAuthorized = true;
                }
            }
            if (isAuthorized)
            {
                throw new SecurityException("You are not authorized!");
            }
        }
    }
}