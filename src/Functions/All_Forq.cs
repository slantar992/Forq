using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static bool All<TSource>(
            this List<TSource> source,
            Func<TSource, bool> predicate)
        {
            EvaluateNull(source, predicate);

            for (int i = 0; i < source.Count; i++)
            {
                if (!predicate(source[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}