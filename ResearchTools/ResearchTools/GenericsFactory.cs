using System;
using System.Collections.Generic;
using System.IO;

namespace ResearchTools
{
    public struct ValuePair<T, U> where T : IConvertible where U : IConvertible
    {
        public T V1;
        public U V2;
    }

    public static class GenericsFactory<T, U> where T : IConvertible where U : IConvertible
    {
        public static IDictionary<T, U> CreateDictionary(String Filename, Char Separator = '\t')
        {
            IDictionary<T, U> dict = new Dictionary<T, U>();
            foreach (String line in File.ReadAllLines(Filename))
            {
                String[] kv = line.Split(Separator);
                dict.Add((T)Convert.ChangeType(kv[0], typeof(T)), (U)Convert.ChangeType(kv[1], typeof(U)));
            }
            return dict;
        }

        public static IList<ValuePair<T, U>> CreateList(String Filename, Char Separator = '\t')
        {
            IList<ValuePair<T, U>> list = new List<ValuePair<T, U>>();
            foreach (String line in File.ReadAllLines(Filename))
            {
                String[] kv = line.Split(Separator);
                list.Add(new ValuePair<T, U>() { V1 = (T)Convert.ChangeType(kv[0], typeof(T)), V2 = (U)Convert.ChangeType(kv[1], typeof(U)) });
            }
            return list;
        }
    }
}
