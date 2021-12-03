using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Vaskova_433.Classes.Elements;

namespace Vaskova_433.Classes
{
    class APIClass
    {
        public static List<InquiryClass> Vivod()
        {
            HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create ("https://api.cfif31.ru/BookRequest");
            DataContractJsonSerializer contractJsonSerializer = new DataContractJsonSerializer(typeof (List<InquiryClass>));
            List<InquiryClass> inquiryList = (List<InquiryClass>)contractJsonSerializer.ReadObject(webRequest.GetResponse().GetResponseStream());
            return inquiryList;
        }
    }
}
