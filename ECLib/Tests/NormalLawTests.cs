namespace ECLib.Math.Statistics.Tests
{
	using System;
	using NUnit.Framework;
	
	[TestFixture]
	public class NormalLawTests : StatisticalLawTests
	{
		public NormalLawTests()
		{
			law = new NormalLaw();
		}
	}
}
