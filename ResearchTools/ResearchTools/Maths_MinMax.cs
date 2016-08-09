using System;

public static partial class Maths
{
	public static Int16 MaxVal(Int16[] Values)
    {
        Int32 idx;
        return MaxValIdx(Values, out idx);
    }

    public static Int16 MaxValIdx(Int16[] Values, out Int32 Idx)
    {
        Int16 maxValue = Int16.MinValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] > maxValue) maxValue = Values[Idx = i];
        return maxValue;
    }

    public static Int16 MinVal(Int16[] Values)
    {
        Int32 idx;
        return MinValIdx(Values, out idx);
    }

    public static Int16 MinValIdx(Int16[] Values, out Int32 Idx)
    {
        Int16 minValue = Int16.MaxValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] < minValue) minValue = Values[Idx = i];
        return minValue;
    }

	/*public static Int16 Random(Int16 Min, Int16 Max)
	{
		return
	}*/
	public static Int32 MaxVal(Int32[] Values)
    {
        Int32 idx;
        return MaxValIdx(Values, out idx);
    }

    public static Int32 MaxValIdx(Int32[] Values, out Int32 Idx)
    {
        Int32 maxValue = Int32.MinValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] > maxValue) maxValue = Values[Idx = i];
        return maxValue;
    }

    public static Int32 MinVal(Int32[] Values)
    {
        Int32 idx;
        return MinValIdx(Values, out idx);
    }

    public static Int32 MinValIdx(Int32[] Values, out Int32 Idx)
    {
        Int32 minValue = Int32.MaxValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] < minValue) minValue = Values[Idx = i];
        return minValue;
    }

	/*public static Int32 Random(Int32 Min, Int32 Max)
	{
		return
	}*/
	public static Int64 MaxVal(Int64[] Values)
    {
        Int32 idx;
        return MaxValIdx(Values, out idx);
    }

    public static Int64 MaxValIdx(Int64[] Values, out Int32 Idx)
    {
        Int64 maxValue = Int64.MinValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] > maxValue) maxValue = Values[Idx = i];
        return maxValue;
    }

    public static Int64 MinVal(Int64[] Values)
    {
        Int32 idx;
        return MinValIdx(Values, out idx);
    }

    public static Int64 MinValIdx(Int64[] Values, out Int32 Idx)
    {
        Int64 minValue = Int64.MaxValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] < minValue) minValue = Values[Idx = i];
        return minValue;
    }

	/*public static Int64 Random(Int64 Min, Int64 Max)
	{
		return
	}*/
	public static UInt16 MaxVal(UInt16[] Values)
    {
        Int32 idx;
        return MaxValIdx(Values, out idx);
    }

    public static UInt16 MaxValIdx(UInt16[] Values, out Int32 Idx)
    {
        UInt16 maxValue = UInt16.MinValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] > maxValue) maxValue = Values[Idx = i];
        return maxValue;
    }

    public static UInt16 MinVal(UInt16[] Values)
    {
        Int32 idx;
        return MinValIdx(Values, out idx);
    }

    public static UInt16 MinValIdx(UInt16[] Values, out Int32 Idx)
    {
        UInt16 minValue = UInt16.MaxValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] < minValue) minValue = Values[Idx = i];
        return minValue;
    }

	/*public static UInt16 Random(UInt16 Min, UInt16 Max)
	{
		return
	}*/
	public static UInt32 MaxVal(UInt32[] Values)
    {
        Int32 idx;
        return MaxValIdx(Values, out idx);
    }

    public static UInt32 MaxValIdx(UInt32[] Values, out Int32 Idx)
    {
        UInt32 maxValue = UInt32.MinValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] > maxValue) maxValue = Values[Idx = i];
        return maxValue;
    }

    public static UInt32 MinVal(UInt32[] Values)
    {
        Int32 idx;
        return MinValIdx(Values, out idx);
    }

    public static UInt32 MinValIdx(UInt32[] Values, out Int32 Idx)
    {
        UInt32 minValue = UInt32.MaxValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] < minValue) minValue = Values[Idx = i];
        return minValue;
    }

	/*public static UInt32 Random(UInt32 Min, UInt32 Max)
	{
		return
	}*/
	public static UInt64 MaxVal(UInt64[] Values)
    {
        Int32 idx;
        return MaxValIdx(Values, out idx);
    }

    public static UInt64 MaxValIdx(UInt64[] Values, out Int32 Idx)
    {
        UInt64 maxValue = UInt64.MinValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] > maxValue) maxValue = Values[Idx = i];
        return maxValue;
    }

    public static UInt64 MinVal(UInt64[] Values)
    {
        Int32 idx;
        return MinValIdx(Values, out idx);
    }

    public static UInt64 MinValIdx(UInt64[] Values, out Int32 Idx)
    {
        UInt64 minValue = UInt64.MaxValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] < minValue) minValue = Values[Idx = i];
        return minValue;
    }

	/*public static UInt64 Random(UInt64 Min, UInt64 Max)
	{
		return
	}*/
	public static Single MaxVal(Single[] Values)
    {
        Int32 idx;
        return MaxValIdx(Values, out idx);
    }

    public static Single MaxValIdx(Single[] Values, out Int32 Idx)
    {
        Single maxValue = Single.MinValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] > maxValue) maxValue = Values[Idx = i];
        return maxValue;
    }

    public static Single MinVal(Single[] Values)
    {
        Int32 idx;
        return MinValIdx(Values, out idx);
    }

    public static Single MinValIdx(Single[] Values, out Int32 Idx)
    {
        Single minValue = Single.MaxValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] < minValue) minValue = Values[Idx = i];
        return minValue;
    }

	/*public static Single Random(Single Min, Single Max)
	{
		return
	}*/
	public static Double MaxVal(Double[] Values)
    {
        Int32 idx;
        return MaxValIdx(Values, out idx);
    }

    public static Double MaxValIdx(Double[] Values, out Int32 Idx)
    {
        Double maxValue = Double.MinValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] > maxValue) maxValue = Values[Idx = i];
        return maxValue;
    }

    public static Double MinVal(Double[] Values)
    {
        Int32 idx;
        return MinValIdx(Values, out idx);
    }

    public static Double MinValIdx(Double[] Values, out Int32 Idx)
    {
        Double minValue = Double.MaxValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] < minValue) minValue = Values[Idx = i];
        return minValue;
    }

	/*public static Double Random(Double Min, Double Max)
	{
		return
	}*/
	public static Decimal MaxVal(Decimal[] Values)
    {
        Int32 idx;
        return MaxValIdx(Values, out idx);
    }

    public static Decimal MaxValIdx(Decimal[] Values, out Int32 Idx)
    {
        Decimal maxValue = Decimal.MinValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] > maxValue) maxValue = Values[Idx = i];
        return maxValue;
    }

    public static Decimal MinVal(Decimal[] Values)
    {
        Int32 idx;
        return MinValIdx(Values, out idx);
    }

    public static Decimal MinValIdx(Decimal[] Values, out Int32 Idx)
    {
        Decimal minValue = Decimal.MaxValue;
        Idx = Int32.MinValue;
        for (Int32 i = 0; i < Values.Length; i++) if (Values[i] < minValue) minValue = Values[Idx = i];
        return minValue;
    }

	/*public static Decimal Random(Decimal Min, Decimal Max)
	{
		return
	}*/
}