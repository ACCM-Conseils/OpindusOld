namespace ECLib.Math.Statistics
{
	using System;

	public class UniformLaw : Random, IStatisticalLaw
	{
		double a;
		double b;

		public UniformLaw() : base()
		{
			a = 0.0;
			b = 1.0;
		}
		
		public UniformLaw(int seed) : base(seed)
		{
			a = 0.0;
			b = 1.0;
		}

		public UniformLaw(int seed, double a, double b) : this(seed)
		{
			this.a = a;
			this.b = b;
		}
		
		public override double NextDouble()
		{
			return a+(b-a)*base.NextDouble();
		}
		
		public double Mean
		{
			get
			{
				return (a+b)/2.0;
			}
			set
			{
				double currentStdDeviation = StandardDeviation;
				a = value - Math.Sqrt(3) * currentStdDeviation;
				b = value + Math.Sqrt(3) * currentStdDeviation;
			}
		}
		
		public double StandardDeviation
		{
			get
			{
				return (b-a)/Math.Sqrt(12.0);
			}
			set
			{
				double currentMean = Mean;
				a = currentMean - Math.Sqrt(3) * value;
				b = currentMean + Math.Sqrt(3) * value;
			}
		}

	}
}
