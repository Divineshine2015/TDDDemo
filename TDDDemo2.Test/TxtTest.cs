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

            var c1 = new whatever("abc");

            var testc = c1.do();

            Assert.Equal("bc", testc);

        }
        [Fact]
        public void Upperclass()
        {
            string pancake = "pancake";
            string pancake2 = pancake.ToUpper();

            Assert.Equal("PANCAKE", pancake2);
    
        }
    }
}
