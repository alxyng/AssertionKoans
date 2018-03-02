using AssertionKoans.Engine;
using AssertionKoans.Engine.Extensions;
using FluentAssertions;

namespace AssertionKoans.Koans
{
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