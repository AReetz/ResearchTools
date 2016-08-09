using System;

namespace ResearchTools
{
    public static class Maths<T> where T : IComparable<T>
    {
        public static T MaxVal(T[] Values)
        {
            Int32 idx;
            return MaxValIdx(Values, out idx);
        }

        public static T MaxValIdx(T[] Values, out int Idx)
        {
            T maxValue = Values[0];
            Idx = Int32.MinValue;
            for (Int32 i = 0; i < Values.Length; i++) if (Values[i].CompareTo(maxValue) > 0) maxValue = Values[Idx = i];
            return maxValue;
        }

        public static T MinVal(T[] Values)
        {
            Int32 idx;
            return MinValIdx(Values, out idx);
        }

        public static T MinValIdx(T[] Values, out Int32 Idx)
        {
            T minValue = Values[0];
            Idx = Int32.MinValue;
            for (Int32 i = 0; i < Values.Length; i++) if (Values[i].CompareTo(minValue) < 0) minValue = Values[Idx = i];
            return minValue;
        }
    }

    public static partial class Maths
    {
        /// ONLY ADD CODE TO THE MATHS CLASS VIA TEXT TEMPLATE
    }
}
