﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Kooboo.CMS.Sites.Extension.ModuleArea
{
    public static class ModuleUrlHelper
    {
        public static string Encode(string moduleUrl)
        {
            return moduleUrl.Replace("?", "~~");
        }
        public static string Decode(string encodedModuleUrl)
        {
            var url = HttpUtility.UrlDecode(encodedModuleUrl);
            return encodedModuleUrl.Replace("~~", "?");
        }
        public static string RemoveApplicationPath(string moduleUrl, string applicationPath)
        {
            if (applicationPath != "/")
            {
                moduleUrl = moduleUrl.Remove(0, applicationPath.Length);
            }
            return moduleUrl;
        }
    }
}
