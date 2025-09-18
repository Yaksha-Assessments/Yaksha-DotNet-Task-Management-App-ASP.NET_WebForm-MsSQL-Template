using System;
using System.Web;

namespace EventLite.WebForms.Utilities
{
    public static class CookieHelper
    {
        public static void WriteCookie(string name, string value, int days = 7)
        {
            var cookie = new HttpCookie(name, value) { Expires = DateTime.Now.AddDays(days) };
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        public static string ReadCookie(string name)
        {
            var cookie = HttpContext.Current.Request.Cookies[name];
            return cookie?.Value;
        }
    }
}