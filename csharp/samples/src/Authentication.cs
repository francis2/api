/* 
 * 
 * Tradovate API, Samples. 
 * AccessTokenRequest
 *
*/

using System.Diagnostics;
using System.Net;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate
{
    class Authentication
    {
        public static AccessTokenResponse GetAccessToken(string basePath, string username, string password)
        {
            var apiInstance = new AuthenticationApi(basePath);
            var body = new AccessTokenRequest(Name: username, Password: password, AppId: "SampleApp", AppVersion: "0.1.0");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            AccessTokenResponse result = apiInstance.AccessTokenRequest(body);
            Debug.WriteLine(result);
            return result;
        }
    }
}
