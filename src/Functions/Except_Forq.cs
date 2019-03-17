using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static List<TSource> Except<TSource>(
            this List<TSource> first,
            List<TSource> second)
        {
            EvaluateNull(first, second);

            List<TSource> result = new List<TSource>();

            for(int i = 0; i < first.Count; i++)
            {
                if (!second.Contains(first[i]))
                {
                    result.Add(first[i]);
                }
            }

            return result;
        }

        public static List<TSource> Except<TSource>(
            this List<TSource> first,
            List<TSource> second,
            IEqualityComparer<TSource> comparer)
        {
            EvaluateNull(first, second, comparer);

            List<TSource> result = new List<TSource>();

            for(int i = 0; i < first.Count; i++)
            {
                if (!second.Contains(first[i], comparer))
                {
                    result.Add(first[i]);
                }
            }

            return result;
        }
    }
}

