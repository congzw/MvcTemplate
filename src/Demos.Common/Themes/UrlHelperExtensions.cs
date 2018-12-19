using System.Web.Mvc;

namespace Demos.Common.Themes
{
    public static class UrlHelperExtensions
    {
        public static string ThemeUrl(this UrlHelper urlHelper, string virtualPath)
        {
            var themeableRazorViewEngine = ThemeableRazorViewEngine.Current;
            if (themeableRazorViewEngine == null)
            {
                return virtualPath;
            }
            return themeableRazorViewEngine.GetVirtualPathForTheme(virtualPath);
        }
    }
}