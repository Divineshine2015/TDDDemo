using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDemo
{
    public class whatever
    {
        public string AnyString { get; set; }
        public string CString { get; set; }
        public string whatever(string t)
        {
            this.CString = t;
            return AnyString;
        }
        public string copy()
        {
           AnyString = "strint n stuff";
            return AnyString;
        }
        public string ConvertConsonants(string t)
        {
            t = AnyString.Split('-')[0];
            
            string startConsonants = t.ToUpper().Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "");
            

            return string.Format("{0}{1}-{2}{3}", startConsonants[0].ToString(), startConsonants[startConsonants.Length - 1].ToString());
        }
    }
}
