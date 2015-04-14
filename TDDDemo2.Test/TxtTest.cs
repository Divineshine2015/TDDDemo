using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDDemo;
using Xunit;

namespace TDDDemo2.Test
{
    public class TxtTest
    {

        [Fact]
        public void CreateString()
        {
            
            
            var newString = new whatever();

            Assert.NotNull(newString);
        }
        [Fact]
        public void Consonants()
        {
            var p = new whatever();
            p.AnyString = "some input";
            var answer = p.ConvertConsonants("different input");

            var output = p.CString;


            Assert.Equal("smnpt", answer);
            Assert.Equal("smnpt", output);


        }
        public void Upperclass()
        {
            string pancake = "pancake";
            string pancake2 = pancake.ToUpper();

            Assert.Equal("PANCAKE", pancake2);

        }
    }
}
