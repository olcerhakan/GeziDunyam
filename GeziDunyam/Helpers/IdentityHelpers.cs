﻿using GeziDunyam.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace GeziDunyam.Helpers
{
    public static class IdentityHelpers
    {
        public static string DisplayName(this IIdentity identity)
        {
            var claims = ((ClaimsIdentity)identity).Claims;

            string displayName = claims.FirstOrDefault(x => x.Type == "DisplayName").Value;
           

            return displayName;
        }

    }
}