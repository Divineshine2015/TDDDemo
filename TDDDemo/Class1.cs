using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDemo
{
    public class whatever
    {
        public string TMessage { get; set; }
        public string TextMessage()
        {
            TMessage = "strint n stuff";
            return TMessage;
        }
        public string TextMessage(string t)
        {
            TMessage = (from c in t

                               where c != 'A'
                               where c != 'E'
                               where c != 'I'
                               where c != 'O'
                               where c != 'U'
                               select c).ToString();
            
            return TMessage;
        }
    }
}
