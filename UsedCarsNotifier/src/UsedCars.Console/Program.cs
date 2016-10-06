using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace UsedCars.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sURL;
            sURL = "http://api.polovniautomobili.com/json/v3/getAds?pageID=1&SortingType=1&category=26&brand=114&modelID=1330&old_or_new=both&yearFrom=2011&powerFrom=103";

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);

            
            Stream objStream;
            var response = wrGETURL.GetResponseAsync();
            objStream = response.Result.GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);
            string text = objReader.ReadToEnd();

            
        }
    }
}
