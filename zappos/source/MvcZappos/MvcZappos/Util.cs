using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Web;
using System.Text.RegularExpressions;
using System.Collections;
using System.Configuration;

namespace MvcZappos 
{
    public class Util
    {


        
        

        public static string GetWebStream(string url)
        {
            string responseFromServer = "";
            try
            {
                StreamReader sr = null;        
                System.Text.Encoding code = System.Text.Encoding.UTF8;
           
                WebRequest HttpWebRequest = null;
                WebResponse HttpWebResponse = null;
                HttpWebRequest = WebRequest.Create(url);
                HttpWebResponse = HttpWebRequest.GetResponse();

              
                sr = new StreamReader(HttpWebResponse.GetResponseStream(), code);
                responseFromServer = sr.ReadToEnd();
                sr.Close();
                //sr.Dispose();
                HttpWebResponse.Close();
            }
            catch (Exception ex)
            {
                return "false";
            }
            if (responseFromServer == null)
            {
                responseFromServer = "";
            }
            return responseFromServer;
        }


    }
}
