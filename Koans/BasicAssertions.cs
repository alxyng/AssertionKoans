using System;
using AssertionKoans.Engine;
using AssertionKoans.Engine.Extensions;
using FluentAssertions;

namespace AssertionKoans.Koans
{
    class BasicAssertions : Koan
    {
		//[Step(1)]
	    public void BasicAssertionUsingUnidaysShould()
	    {
			// observe failure message, nice and clear right?
		    "hello".ShouldEqual("helll");
	    }

	    //[Step(2)]
	    public void BasicAssertionUsingFluentAssertions()
	    {
			// how does the error message compare with the previous step?
		    "hello".Should().Be("helll");
	    }

	  //  [Step(3)]
	    public void TrueAssertionUsingUnidaysShould()
	    {
			// what is wrong with this failure message?
			(1 == 2).ShouldBeTrue();
	    }

	    //[Step(4)]
	    public void TrueAssertionUsingFluentAssertions()
	    {
			// what is better about this failure message?
		    (1 == 2).Should().BeTrue();
	    }

	    //[Step(5)]
	    public void NotNullAssertionUsingUnidaysShould()
	    {
		    string b = null;
			// does this say what is null in the error?
			b.ShouldNotBeNull();
	    }

	    //[Step(6)]
	    public void NotNullAssertionUsingFluentAssertions()
	    {
		    string b = null;

			// is this clearer
		    b.Should().NotBeNull();
	    }

	   // [Step(7)]
	    public void NullAssertionUsingUnidaysShould()
	    {
		    var b = "hello";
		    // this is not a terrible failure message
		    b.ShouldBeNull();
	    }

	    //[Step(8)]
	    public void NullAssertionUsingFluentAssertions()
	    {
		    var b = "hello";

		    // this gives the same info, but is a little bit more succinct
		    b.Should().BeNull();
	    }

//	   // [Step(9)]
//		public void badger()
//	    {
//		    var a = new DateTime(2018, 10, 1);
//			a.Year.ShouldEqual(2019);
//			a.Month.ShouldEqual(11);
//	    }
//
//	    [Step(9)]
//	    public void badger2()
//	    {
//		    var a = new DateTime(2018, 10, 1);
//		    a.Should().HaveYear(2019).And.HaveMonth(11);
//		}


	}

	class StringAssertions : Koan
	{
		//	[Step(1)]
		public void StringContainsUsingUnidaysShould()
		{
			// does this say much about the assertion
			"hello world".ShouldContain("badger");
		}

		//[Step(2)]
		public void StringContainsUsingFluentAssertions()
		{
			// much better?
			"hello world".Should().Contain("badger");
		}

		//[Step(3)]
		public void StringStartsAndEndsWithUsingUnidaysShould()
		{
			var message = "hello world";
			message.ShouldStartWith("goodbye");
			message.ShouldEndWith("badger");
		}

		[Step(4)]
		public void StringStartsAndEndsWithUsingFluentAssertions()
		{
			var message = "hello world";
			message.Should().StartWith("goodbye").And.EndWith("badger");
		}
	}
}
