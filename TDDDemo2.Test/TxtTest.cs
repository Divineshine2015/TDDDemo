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
            var answer = p.TextMessage("different input");
            Assert.Equal("dffrnt npt", answer);                       

        }       
        public void Upperclass()
        {
            string pancake = "pancake";
            string pancake2 = pancake.ToUpper();

            Assert.Equal("PANCAKE", pancake2);

        }
        [Fact]
        public void Alphabetized()
        {
            var c = new whatever();
           // var answer = c.TextMessage("different input");
            var alphaanswer = c.Alphabetize("dffrnt npt");
            Assert.Equal(" dffnnprtt", alphaanswer);
        }
        [Fact]
        public void NoRepeatsTest()
        {
            var d = new whatever();
            var repanswer = d.NoRepeats("dffnnprtt");
            Assert.Equal("dfnprt", repanswer);

        }
        [Fact]
        public void AllLowercase()
        {
            var l = new whatever();
            var lowercaseAnswer = l.LowerCases("DFNPRT");

            Assert.Equal("dfnprt", lowercaseAnswer);

        }
    }
}
