using AssertionKoans.Engine;
using AssertionKoans.Engine.Extensions;
using FluentAssertions;

namespace AssertionKoans.Koans
{
	class NumericAssertions : Koan
	{
        //[Step(1)]
        public void GreaterThanComparisonUsingUnidaysShould()
        {
            (-1).ShouldBeGreaterThan(0);
        }

        //[Step(2)]
        public void GreaterThanUsingFluentAssertions()
        {
            // also has less than equivalent
            (-1).Should().BeGreaterThan(0);
        }

        //[Step(3)]
        public void GreaterThanOrEqualUsingFluentAssertions()
        {
            // also has less than equivalent
            (-1).Should().BeGreaterOrEqualTo(1);
        }

        //[Step(4)]
        public void BePositiveUsingFluentAssertions()
        {
            // also has negative equivalent            
            (-1).Should().BePositive();
        }

        //[Step(5)]
        public void RangeComparison()
        {
            12.Should().BeInRange(1, 10);
        }
	}
}