using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static TSource FirstOrDefault<TSource>(this List<TSource> source, Func<TSource, bool> predicate)
        {
            EvaluateNull(source);

            for (int i = 0; i < source.Count; i++)
            {
                if (predicate(source[i]))
                {
                    return source[i];
                }
            }

            return default(TSource);
        }

        public static TSource FirstOrDefault<TSource>(this List<TSource> source)
        {
            EvaluateNull(source);

            return 
                source.Count == 0 ?
                default(TSource) :
                source[0];
        }
    }
}

