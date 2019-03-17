using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public static partial class Forq
    {
        public static List<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(
            this List<TOuter> outer,
            List<TInner> inner,
            Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector,
            Func<TOuter, List<TInner>, TResult> resultSelector,
            IEqualityComparer<TKey> comparer)
        {
            EvaluateNull(comparer);

            return _GroupJoin(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
        }

        public static List<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(
            this List<TOuter> outer,
            List<TInner> inner,
            Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector,
            Func<TOuter, List<TInner>, TResult> resultSelector)
        {
            return _GroupJoin(outer, inner, outerKeySelector, innerKeySelector, resultSelector);
        }

        private static List<TResult> _GroupJoin<TOuter, TInner, TKey, TResult>(
            List<TOuter> outer,
            List<TInner> inner,
            Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector,
            Func<TOuter, List<TInner>, TResult> resultSelector,
            IEqualityComparer<TKey> comparer = null)
        {
            //TODO: Improve performance: use less iterations

            EvaluateNull(outer, inner, outerKeySelector, innerKeySelector, resultSelector);

            List<TResult> result = new List<TResult>();
            List<TInner> innerGroup = new List<TInner>();
            TOuter outerElement;
            TInner innerElement;
            var equalityPredicate = GetEqualityPredicate(comparer);

            for(int i = 0; i < outer.Count; i++)
            {
                outerElement = outer[i];
                for (int j = 0; j < inner.Count; j++)
                {
                    innerElement = inner[j];
                    if( equalityPredicate(
                        outerKeySelector(outerElement),
                        innerKeySelector(innerElement)) )
                    {
                        innerGroup.Add(innerElement);
                    }
                }
                result.Add(resultSelector(outerElement, innerGroup));

                innerGroup.Clear();
            }

            return result;
        }
    }
}
