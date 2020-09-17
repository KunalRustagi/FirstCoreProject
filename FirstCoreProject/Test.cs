using System;
using Xunit;
using FirstLib;


namespace FirstCoreProject{
    public class Test{
        [Fact]
        public void addNums(){
            Calculator c1 = new Calculator();
            Assert.Equal(11,c1.add(5,6));
        }
    }
}