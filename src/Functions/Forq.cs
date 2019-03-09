using System;
using System.Collections.Generic;

namespace Slantar.Forq
{

    public static partial class Forq 
    {

        // "Aggregate" functions
        public static TResult Aggregate<TSource, TAccumulate, TResult> (this List<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            EvaluateNull(resultSelector);

            return resultSelector(Aggregate(source, seed, func));
        }

        public static TAccumulate Aggregate<TSource, TAccumulate>(this List<TSource> source, Func<TAccumulate, TSource, TAccumulate> func)
        {

            return Aggregate(source, default(TAccumulate), func);
        }

        public static TAccumulate Aggregate<TSource, TAccumulate>(this List<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
        {
            EvaluateNull(source, func);

            TAccumulate result = seed;
            for (int i = 0; i < source.Count; i++)
            {
                result = func(result, source[i]);
            }

            return result;
        }

        //"All" function
        public static bool All<TSource>(this List<TSource> source, Func<TSource, bool> predicate)
        {
            EvaluateNull(source, predicate);

            for(int i = 0; i < source.Count; i++)
            {
                if (!predicate(source[i]))
                {
                    return false;
                }
            }

            return true;
        }

        //"Any" functions
        public static bool Any<TSource>(this List<TSource> source, Func<TSource, bool> predicate)
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

        //"Append" function
        public static List<TSource> Append<TSource>(this List<TSource> source, TSource element)
        {
            EvaluateNull(source);
            source.Add(element);
            return source;
        }

        //"AsEnumerable" function
        public static IEnumerable<TSource> AsEnumerable<TSource>(this List<TSource> source)
        {
            return source;
        }

        // AUX FUNCTIONS
        private static void EvaluateNull(params object[] objects)
        {
            for(int i = 0; i < objects.Length; i++)
            {
                if(objects[i] == null) throw new ArgumentNullException();
            }
        }

        private static void EvaluateEmptyList<T>(List<T> list)
        {
            if (list.Count < 1) throw new InvalidOperationException("list contains no elements.");
        }
    }
} 
