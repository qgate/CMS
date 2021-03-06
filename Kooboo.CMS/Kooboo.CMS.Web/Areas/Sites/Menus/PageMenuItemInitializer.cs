﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using Kooboo.Web.Mvc;
using Kooboo.Web.Mvc.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Kooboo.CMS.Web.Areas.Sites.Menus
{
    public class PageMenuItemInitializer : DataRuleMenuItemInitializer
    {
        public override string From
        {
            get { return "page"; }
        }

        protected override bool GetIsActive(MenuItem item, System.Web.Mvc.ControllerContext controllerContext)
        {
            string parent = controllerContext.RequestContext.GetRequestValue("uuid");
            var fullName = item.RouteValues["uuid"] == null ? "" : item.RouteValues["uuid"].ToString();

            return (string.Compare(parent, fullName, true) == 0 || string.IsNullOrEmpty(fullName)) && controllerContext.RequestContext.GetRequestValue("controller").ToLower() == "page";

        }
    }
}