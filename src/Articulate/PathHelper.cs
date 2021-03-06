﻿using System;
using Articulate.Models;
using Umbraco.Core;

namespace Articulate
{
    public static class PathHelper
    {
        public static string GetThemePath(IMasterModel model)
        {
            if (model.Theme.IsNullOrWhiteSpace())
            {
                throw new InvalidOperationException("No theme has been set for this Articulate root, republish the root with a selected theme");
            }

            var path = "~/App_Plugins/Articulate/Themes/{0}/";
            return string.Format(path, model.Theme);
        }

        public static string GetThemeViewPath(IMasterModel model, string viewName)
        {
            if (model.Theme.IsNullOrWhiteSpace())
            {
                throw new InvalidOperationException("No theme has been set for this Articulate root, republish the root with a selected theme");
            }

            var path = "~/App_Plugins/Articulate/Themes/{0}/Views/{1}.cshtml";
            return string.Format(path, model.Theme, viewName);
        }

        public static string GetThemePartialViewPath(IMasterModel model, string viewName)
        {
            if (model.Theme.IsNullOrWhiteSpace())
            {
                throw new InvalidOperationException("No theme has been set for this Articulate root, republish the root with a selected theme");
            }

            var path = "~/App_Plugins/Articulate/Themes/{0}/Views/Partials/{1}.cshtml";
            return string.Format(path, model.Theme, viewName);
        }
    }
}