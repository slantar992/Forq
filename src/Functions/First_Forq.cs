using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static TSource First<TSource>(this List<TSource> source)
        {
            EvaluateNull(source);
            EvaluateEmptyList(source);

            return source[0];
        }

        public static TSource First<TSource>(this List<TSource> source, Func<TSource, bool> predicate)
        {
            EvaluateNull(source);
            EvaluateEmptyList(source);

            for(int i = 0; i < source.Count; i++)
            {
                if (predicate(source[i]))
                {
                    return source[i];
                }
            }

            throw new InvalidOperationException("No element satisfies the condition in predicate.");
        }
    }
}

