using System;
using AssertionKoans.Engine;
using FluentAssertions;
using FluentAssertions.Extensions;

namespace AssertionKoans.Koans
{
	class AdvancedAssertions : Koan
	{
		class TestObject
		{
			public int IntValue { get; set; }
			public string StringValue { get; set; }

			public float FloatValue => 3.14f;
		}

		[Step(1)]
		public void ObjectEquivalence()
		{
			var thing = new TestObject { };
  
			thing.Should()
				.BeOfType<TestObject>()
				.And.BeEquivalentTo(new
				{
					IntValue = 5,
					StringValue = "hello",
					DateValue = 10.January(1986) // You'll need to add this property
					// The float value doesn't matter
				});
		}
    }
}