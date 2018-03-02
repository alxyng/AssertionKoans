using Xunit;

namespace AssertionKoans.Engine.Tests
{
    public class RealityTests
    {
        [Fact]
        public void TrueShouldBeTrue()
        {
            Assert.True(true);
        }
    }
}