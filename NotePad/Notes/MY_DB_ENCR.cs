using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    static class MY_DB_ENCR
    {
        static public string Encrypt(string c,string key="")
        {

            string encr = "";
            try
            {
                if (key != "")
                {
                    encr = Convert.ToBase64String(Encoding.Unicode.GetBytes(c));
                    encr.Replace("=", key);
                }
                   
                else
                    encr = Convert.ToBase64String(Encoding.Unicode.GetBytes(c));


            }
            catch {
                return "c";
            }
           


            return encr;

        }
        static public string Decrypt(string c,string key)
        {
            string encr = "";
            try
            {
                if (key != "")
                {
                    encr = Encoding.Unicode.GetString(Convert.FromBase64String(c));
                    encr.Replace(key, "=");
                }
                else
                    encr = Encoding.Unicode.GetString(Convert.FromBase64String(c));


            }
            catch {
                return "c";
            }
           
            


            return encr;
        }





    }
}
