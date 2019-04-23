using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RegisterEmployeeFinger.src.Class.API
{
    class RestAPI
    {
        private const int timeout_conn = 5000; // 3 seconds
        public RestAPI()
        {

        }

        public DataResponseFull API_Post(string ip_address_server, string APIUrl, string sent_param = "")
        {
            string result = "";
            try
            {
                string full_API_URL = ip_address_server + APIUrl;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(full_API_URL);
                request.Method = "POST";
                request.Timeout = timeout_conn;

                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                Byte[] byteArray = encoding.GetBytes(sent_param);

                request.ContentLength = byteArray.Length;
                request.ContentType = @"application/json";
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }
                long length = 0;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    length = response.ContentLength;
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                    result = readStream.ReadToEnd();
                    var json = JsonConvert.DeserializeObject<DataResponseFull>(result);
                    return json;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public DataResponseFull API_Get(string ip_address_server, string API_URL)
        {
            string result = "";
            try
            {
                string full_URL_API = ip_address_server + API_URL;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(full_URL_API);
                request.Method = "GET";
                request.Timeout = timeout_conn;
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    result = reader.ReadToEnd();
                    var json = JsonConvert.DeserializeObject<DataResponseFull>(result);
                    return json;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
