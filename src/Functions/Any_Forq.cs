using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public static partial class Forq
    {
        public static bool Any<TSource>(
            this List<TSource> source,
            Func<TSource, bool> predicate)
        {
            EvaluateNull(source, predicate);

            for (int i = 0; i < source.Count; i++)
            {
                if (predicate(source[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any<TSource>(this List<TSource> source)
        {
            EvaluateNull(source);

            return source.Count > 0;
        }
    }
}
