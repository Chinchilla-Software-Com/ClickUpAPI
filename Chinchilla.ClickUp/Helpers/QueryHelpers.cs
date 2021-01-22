using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace Chinchilla.ClickUp.Helpers
{
    internal static class QueryHelpers
    {
        internal static string ToQueryString(this NameValueCollection values)
        {
            var array = (
                from key in values.AllKeys
                from value in values.GetValues(key)
                select $"{HttpUtility.UrlEncode(key)}={HttpUtility.UrlEncode(value)}"
            ).ToArray();
            return "?" + string.Join("&", array);
        }
    }
}
