using Microsoft.AspNetCore.Http;

namespace ZbazinersBar.Infrastructure {

    public static class UrlExtensions {

        public static string PathAndQuery(this HttpRequest request)
        {
            if (request.QueryString.HasValue)
            {
                return $"{request.Path}{request.QueryString}";
            }

            return request.Path.ToString();
        }
    }
}
