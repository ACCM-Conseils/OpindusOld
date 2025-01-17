namespace ECLib.Math.Statistics.Tests
{
	using System;
	using NUnit.Framework;
	
	[TestFixture]
	public class UniformLawTest : StatisticalLawTests
	{
		public UniformLawTest()
		{
			law = new UniformLaw(0,0.0,10.0);	
		}
	}
}
