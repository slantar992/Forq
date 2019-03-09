using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static int Count<TSource>(this List<TSource> source)
        {
            EvaluateNull(source);

            return source.Count;
        }

        public static int Count<TSource>(this List<TSource> source, Func<TSource, bool> predicate)
        {
            EvaluateNull(source, predicate);

            int result = 0;

            for(int i = 0; i < source.Count; i++)
            {
                if (predicate(source[i]))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
