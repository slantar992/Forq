using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static bool Contains<TSource>(this List<TSource> source, TSource value)
        {
            EvaluateNull(source);

            return source.Contains(value);
        }

        public static bool Contains<TSource>(this List<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
        {
            EvaluateNull(source, comparer);

            for(int i = 0; i < source.Count; i++)
            {
                if(comparer.Equals(source[i], value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
