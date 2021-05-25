using System;
using Xunit;

namespace Uppgift9.Tests
{
    public class SwedishID_Can
    {
        [Fact]
        public void Check_A_Valid_ID_Number()
        {
            var number = 9702175747;
            var IdType = new SwedishID();
            Assert.True(IdType.CheckIfValid(number));
        }
        [Fact]
        public void Check_A_False_ID_Number()
        {
            var number = 9702175742;
            var IdType = new SwedishID();
            Assert.False(IdType.CheckIfValid(number));
        }
        [Fact]
        public void Parse_A_yyyyMMddXXXX_Number()
        {
            var number = 199702175747;
            var IdType = new SwedishID();
            Assert.True(IdType.CheckIfValid(number));
        }
    }
}
