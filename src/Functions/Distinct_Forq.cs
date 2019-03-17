using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static List<TSource> Distinct<TSource>(
            this List<TSource> source)
        {
            EvaluateNull(source);
            List<TSource> result = new List<TSource>();

            for(int i = 0; i < source.Count; i++)
            {
                if (!result.Contains(source[i]))
                {
                    result.Add(source[i]);
                }
            }

            return result;
        }

        public static List<TSource> Distinct<TSource>(
            this List<TSource> source,
            IEqualityComparer<TSource> comparer)
        {
            EvaluateNull(source);
            List<TSource> result = new List<TSource>();

            for (int i = 0; i < source.Count; i++)
            {
                if (!result.Contains(source[i], comparer))
                {
                    result.Add(source[i]);
                }
            }

            return result;
        }
    }
}
