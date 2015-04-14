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
            CString = (from c in t

                               where c != 'A'
                               where c != 'E'
                               where c != 'I'
                               where c != 'O'
                               where c != 'U'
                               select c).ToString();
            
            return CString;
        }
    }
}
