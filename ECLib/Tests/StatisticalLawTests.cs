namespace ECLib.Math.Statistics.Tests
{
	using System;
	using NUnit.Framework;
	
	public class StatisticalLawTests
	{
		const int NB_TRY = 100000;
		const double REF_MEAN = 50.0;
		const double REF_STANDARDDEVIATION = 10.0;
		
		public IStatisticalLaw law;
		
		[Test]
		public void TestMean()
		{
			law.Mean = REF_MEAN;
			double average=0;
			for(int i=0; i<NB_TRY; i++)
			{
				average += law.NextDouble();
			}
			average = average / NB_TRY;
			Assert.AreEqual(REF_MEAN, average, 0.1 * REF_MEAN);		// Test NextDouble
			Assert.AreEqual(REF_MEAN, law.Mean, 0.1 * REF_MEAN);	// Test property set
		}
		
		[Test]
		public void TestStandardDeviation()
		{
			law.StandardDeviation = REF_STANDARDDEVIATION;
			double Ex = 0;
			double Ex2 = 0;
			double current;
			for(int i=0; i<NB_TRY; i++)
			{
				Ex += law.NextDouble();
			}
			Ex = Ex / NB_TRY;
			for(int i=0; i<NB_TRY; i++)
			{
				current = law.NextDouble();
				Ex2 += current*current;
			}
			Ex2 = Ex2 / NB_TRY;
			
			Assert.AreEqual(REF_STANDARDDEVIATION, System.Math.Sqrt(Ex2 - Ex*Ex), 0.1 * REF_STANDARDDEVIATION);	// Test NextDouble
			Assert.AreEqual(REF_STANDARDDEVIATION, law.StandardDeviation, 0.1 * REF_STANDARDDEVIATION);			// Test property set
		}
	}
}
