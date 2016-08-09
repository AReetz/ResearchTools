using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Maths
{
	public static Single StandardDeviationNaive(this IEnumerable<Single> values)
	{
		Single avg = values.Average();
        Single sum = values.Sum(val => (val - avg) * (val - avg));
        return (Single)Math.Sqrt(sum / (Single)values.Count());
	}

	public static Single StandardDeviationWelford(this IEnumerable<Single> values)
	{
		Single m = values.First(), q = default(Single);
		UInt64 idx = 1U;
		foreach (Single value in values.Skip(1))
		{
			q += (idx - 1U) * (value - m) * (value - m) / idx;
			m += (value - m) / idx;
			idx++;
		}
		return (Single)Math.Sqrt(q / values.Count());
	}
	public static Double StandardDeviationNaive(this IEnumerable<Double> values)
	{
		Double avg = values.Average();
        Double sum = values.Sum(val => (val - avg) * (val - avg));
        return (Double)Math.Sqrt(sum / (Double)values.Count());
	}

	public static Double StandardDeviationWelford(this IEnumerable<Double> values)
	{
		Double m = values.First(), q = default(Double);
		UInt64 idx = 1U;
		foreach (Double value in values.Skip(1))
		{
			q += (idx - 1U) * (value - m) * (value - m) / idx;
			m += (value - m) / idx;
			idx++;
		}
		return (Double)Math.Sqrt(q / values.Count());
	}
}
