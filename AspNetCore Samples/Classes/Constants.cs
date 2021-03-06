﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_Samples.Classes
{
    public class Constants
    {
        public static class ClaimTypes
        {
            public const string Name = "ClaimTypes.Name";
            public const string NextRefreshUtc = "ClaimTypes.NextRefreshUtc";
        }

        public static class AuthorizationPolicies
        {
            public const string RefreshAuthRequirement = "AuthorizationPolicies.RefreshAuthRequirement";
        }

        public static class Toastr
        {
            public const string Success = "Toastr.Success";
            public const string Error = "Toastr.Error";
            public const string Warning = "Toastr.Warning";
            public const string Information = "Toastr.Information";

            public class Ajax
            {
                public const string Success = "Toastr.Ajax.Success";
                public const string Warning = "Toastr.Ajax.Warning";
                public const string Error = "Toastr.Ajax.Error";
                public const string Information = "Toastr.Ajax.Information";
            }
        }

        public static class ViewComponentKeys
        {
            public const string SiteAjaxMessageView = "SiteAjaxMessageView";
            public const string SiteMessageView = "SiteMessageView";
        }
    }
}
