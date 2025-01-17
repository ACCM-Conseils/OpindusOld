namespace ECLib.Math.Statistics
{
	using System;
	
	public class NormalLaw : IStatisticalLaw
	{
		protected IStatisticalLaw[] source;
		const int NB_LAW=100;
		
		public NormalLaw()
		{
			Random randomizer = new Random();
			source = new IStatisticalLaw[NB_LAW];
			for(int i=0; i<source.Length; i++)
			{
				source[i] = new UniformLaw(randomizer.Next());
			}
		}
		
		public double NextDouble()
		{
			double result=0.0;
			foreach(IStatisticalLaw rnd in source)
			{
				result += rnd.NextDouble();
			}
			return result / source.Length;
		}
		
		public double Mean
		{
			get
			{
				return source[0].Mean;
			}
			set
			{
				foreach(IStatisticalLaw rnd in source)
				{
					rnd.Mean = value;
				}
			}
		}

		public double StandardDeviation
		{
			get
			{
				return source[0].StandardDeviation / Math.Sqrt(NB_LAW);
			}
			set
			{
				foreach(IStatisticalLaw rnd in source)
				{
					rnd.StandardDeviation = value * Math.Sqrt(NB_LAW);
				}
			}
		}
	}
}
