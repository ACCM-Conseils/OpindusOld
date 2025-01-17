namespace ECLib.Math.Statistics
{
	using System;
	
	public class ExponentialLaw : IStatisticalLaw
	{
		IStatisticalLaw x;
		double lambda;
		
		public ExponentialLaw(IStatisticalLaw x, double lambda)
		{
			this.x=x;
			this.lambda=lambda;
		}
		
		public double NextDouble()
		{
			double result= -1.0 * lambda * System.Math.Log(x.NextDouble());
			return result;
		}
		
		public double Mean
		{
			get
			{
				return lambda;
			}
			set
			{
				lambda = value;
			}
		}
		
		public double StandardDeviation
		{
			get
			{
				return lambda;
			}
			set
			{
				lambda = value;
			}
		}
	}
}
