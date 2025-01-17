namespace ECLib.Math.Statistics
{
	public interface IStatisticalLaw
	{
		double NextDouble();
		double Mean {get; set;}
		double StandardDeviation {get; set;}
	}
}
