using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;

namespace CurrencyExchanger
{
    public static class NetworkService
    {
        public static string getJSONResponse()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.nbrb.by/api/exrates/rates?periodicity=0");
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";
            
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            JArray array = new JArray();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                return responseText;
            }

        }
    }
}
