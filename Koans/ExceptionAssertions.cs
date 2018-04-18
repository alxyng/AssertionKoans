using System;
using AssertionKoans.Engine;
using FluentAssertions;

namespace AssertionKoans.Koans
{
	class ExceptionAssertions : Koan
	{
        class Stub
        {
            public void TestMethod()
            {
                // This should throw an exception
            }

            public static void StaticMethod()
            {
                // This should throw an exception
            }
        }

        //[Step(1)]
        public void ExceptionAssertionsAreReallyEasy()
        {
            var stub = new Stub();

            stub.Invoking(x => x.TestMethod())
                .Should().Throw<ArgumentException>()
                .WithMessage("Unhelpful error message.")
                .WithInnerException<ArgumentNullException>()
                .Where(x => x.ParamName == "alsoUnhelpful");
        }

        //[Step(2)]
        public void StaticMethodsAreHarder()
        {
            Action action = () => Stub.StaticMethod();

            action.Should()
                .Throw<InvalidOperationException>()
                .Where(x => x.Message.StartsWith("Bang."));
        }
    }
}