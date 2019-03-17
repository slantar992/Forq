using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static List<TResult> GroupBy<TSource, TKey, TElement, TResult>(
            this List<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector,
            Func<TKey, List<TElement>, TResult> resultSelector)
        {
            return _GroupBy(source, keySelector, elementSelector, resultSelector);
        }

        public static List<TResult> GroupBy<TSource, TKey, TElement, TResult>(
            this List<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector,
            Func<TKey, List<TElement>, TResult> resultSelector,
            IEqualityComparer<TKey> comparer)
        {
            EvaluateNull(comparer);

            return _GroupBy(source, keySelector, elementSelector, resultSelector, comparer);
        }

        public static List<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
            this List<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector)
        {
            return _GroupBy(source, keySelector, elementSelector);
        }

        public static List<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
           this List<TSource> source,
           Func<TSource, TKey> keySelector,
           Func<TSource, TElement> elementSelector,
           IEqualityComparer<TKey> comparer)
        {
            EvaluateNull(comparer);

            return _GroupBy(source, keySelector, elementSelector, comparer);
        }

        public static List<TResult> GroupBy<TSource, TKey, TResult>(
            this List<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TKey, List<TSource>, TResult> resultSelector)
        {
            return _GroupBy(source, keySelector, 
                (element) => element,
                resultSelector);
        }

        public static List<TResult> GroupBy<TSource, TKey, TResult>(
            this List<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TKey, List<TSource>, TResult> resultSelector,
            IEqualityComparer<TKey> comparer)
        {
            EvaluateNull(comparer);

            return _GroupBy(source, keySelector,
                (element) => element,
                resultSelector, comparer);
        }

        public static List<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(
            this List<TSource> source,
            Func<TSource, TKey> keySelector)
        {

            return _GroupBy(source, keySelector,
                (element) => element);
        }

        public static List<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(
            this List<TSource> source,
            Func<TSource, TKey> keySelector,
            IEqualityComparer<TKey> comparer)
        {
            EvaluateNull(comparer);

            return _GroupBy(source, keySelector,
                (element) => element,
                comparer);
        }

        private static List<TResult> _GroupBy<TSource, TKey, TElement, TResult>(
            List<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector,
            Func<TKey, List<TElement>, TResult> resultSelector,
            IEqualityComparer<TKey> comparer = null)
        {
            EvaluateNull(source, keySelector, elementSelector, resultSelector);
            
            List<IGrouping<TKey, TElement>> groups = _GroupBy(source, keySelector, elementSelector, comparer);

            List<TResult> result = new List<TResult>();

            for (int i = 0; i < groups.Count; i++)
            {
                result.Add(resultSelector(groups[i].Key, groups[i].Elements));
            }

            return result;
        }

        private static List<IGrouping<TKey,TElement>> _GroupBy<TSource, TKey, TElement>(
            List<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector,
            IEqualityComparer<TKey> comparer = null)
        {
            List<IGrouping<TKey, TElement>> groups = new List<IGrouping<TKey, TElement>>();
            Func<TKey, TKey, bool> keyPredicate = GetEqualityPredicate(comparer);
            TKey key;
            TSource sourceElement;
            int index;

            for (int i = 0; i < source.Count; i++)
            {
                sourceElement = source[i];
                key = keySelector(sourceElement);
                index = groups.FindIndex(group => keyPredicate(key, group.Key));

                if (index < 0)
                {
                    groups.Add(new Group<TKey, TElement>(key));
                    groups[groups.Count - 1].Elements.Add(elementSelector(sourceElement));
                }
                else
                {
                    groups[index].Elements.Add(elementSelector(sourceElement));
                }
            }
            return groups;
        }
    }
}

