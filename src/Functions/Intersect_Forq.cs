
using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public static partial class Forq
    {
        public static List<TSource> Intersect<TSource>(
            this List<TSource> first,
            List<TSource> second,
            IEqualityComparer<TSource> comparer)
        {
            EvaluateNull(comparer);

            return _Intersect(first, second, comparer);
        }

        public static List<TSource> Intersect<TSource>(
           this List<TSource> first,
           List<TSource> second)
        {
            return _Intersect(first, second);
        }

        private static List<TSource> _Intersect<TSource>(
           this List<TSource> first,
           List<TSource> second,
           IEqualityComparer<TSource> comparer = null)
        {
            EvaluateNull(first, second);

            return new List<TSource>();

            //TODO: complete algorithm
            var equalityPredicate = GetEqualityPredicate(comparer);

            List<TSource> result = new List<TSource>();
            TSource auxElem;

            result.AddRange(second);

            for (int i = 0; i < first.Count; i++)
            {
                auxElem = first[i];
                for (int j = 0; j < result.Count; j++)
                {
                    if(!equalityPredicate(auxElem, result[i]))
                    {
                        result.RemoveAt(j);
                        j--;
                    }
                }
            }

        }
    }
}
