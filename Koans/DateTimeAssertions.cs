using System;
using AssertionKoans.Engine;
using AssertionKoans.Engine.Extensions;
using FluentAssertions;
using FluentAssertions.Extensions;

namespace AssertionKoans.Koans
{
	class DateTimeAssertions : Koan
	{
        //[Step(1)]
        public void FancyDateTimeExpression()
        {
            var dateTime = new DateTime(2018, 03, 07, 19, 30, 00, DateTimeKind.Utc);

            dateTime.Should().Be(7.March(2018).At(19, 30, 25).AsUtc());
        }

        //[Step(2)]
        public void BeBefore()
        {
            // also has after equivalent
            2.March(2018).Should().BeBefore(1.March(2018));
        }

	    //[Step(3)]
	    public void HaveProperties()
	    {
		    var dateTime = new DateTime(2018, 10, 1);
		    dateTime.Should().HaveYear(2019).And.HaveMonth(11).And.HaveDay(2);
		}

        //[Step(4)]
        public void RangeComparison()
        {            
            2.March(2018).Should().BeLessThan(2.Days()).Before(4.March(2018));
            2.March(2018).Should().BeWithin(2.Days()).Before(5.March(2018));
            7.March(2018).Should().BeMoreThan(2.Days()).After(2.March(2018));
        }

        //[Step(5)]
        public void CloseTo()
        {
            var firstDate = new DateTime(2018, 03, 07, 19, 00, 00);
            var secondDate = new DateTime(2018, 03, 07, 19, 30, 25);
            
            secondDate.Should().BeCloseTo(firstDate, 30.Minutes());
        }
	}
}