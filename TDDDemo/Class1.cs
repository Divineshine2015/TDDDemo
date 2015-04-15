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
        // public string AMessage { get; set; }
        public string TextMessage()
        {
            TMessage = "strint n stuff";
            return TMessage;
        }
        ////public string Alphabetize()
        //{
        //    AMessage = "stuff";
        //    return AMessage;

        //}
        
        //new method to removel vowels
        public string TextMessage(string input)
        {

            int index = 0;
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] != 'a' && input[i] != 'e' && input[i] != 'i' && input[i] != 'o' && input[i] != 'u' && input[i] != 'A' && input[i] != 'E' && input[i] != 'I' && input[i] != 'O' && input[i] != 'U')
                {
                    result[index++] = input[i];
                }
            }
            return new string(result, 0, index);
         }
        // new method to alphabetize string
        public string Alphabetize(string TextMessage)
        {
            char[] a = TextMessage.ToCharArray();
            Array.Sort(a);
            return new string (a);
        }
        // new method to remove any repeats in string
        public string Repeats(string Alphabetize)
        {
            char[] a = Alphabetize.ToCharArray();
            List<char> b = new List<char>();
            var pchar = '0';
            foreach (var cchar in a)
            {
                if (cchar != pchar)
                {
                    b.Add(cchar);
                    
                    pchar = cchar;
                       
                }

                return new string(b.ToArray());
            }
        }

            
        }
    
}
