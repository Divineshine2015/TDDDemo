using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDDDemo2.Test
{
    public class Class1
    {

        [Fact]
        public void CreateString()
        {
            var newString = new textMessage();

            Assert.NotNull(newString);
        }
    }
}
