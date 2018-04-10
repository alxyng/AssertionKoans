using AssertionKoans.Engine;

namespace AssertionKoans.Koans
{
    public class PathToEnlightenment : Path
    {
        public PathToEnlightenment()
        {
	        Types = new[] 
            {
                typeof(BasicAssertions), 
                typeof(StringAssertions),
                typeof(NumericAssertions),
                typeof(DateTimeAssertions),
                typeof(CollectionAssertions)
            };
        } 
    }
}