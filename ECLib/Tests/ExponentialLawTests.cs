namespace ECLib.Math.Statistics.Tests
{
	using System;
	using NUnit.Framework;
	
	[TestFixture]
	public class ExponentialLawTests : StatisticalLawTests
	{		
		public ExponentialLawTests()
		{
			law = new ExponentialLaw(new UniformLaw(),0.5);
		}
	}
}

