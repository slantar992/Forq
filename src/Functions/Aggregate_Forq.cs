using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {

        public static TSource Aggregate<TSource>(
            this List<TSource> source,
            Func<TSource, TSource, TSource> func)
        {
            EvaluateNull(source);
            EvaluateEmptyList(source);

            return _IterateAggregation(source, source[0], func, 1);
        }

        public static TAccumulate Aggregate<TSource, TAccumulate>(
            this List<TSource> source,
            TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func)
        {
            EvaluateNull(source);
            EvaluateEmptyList(source);

            return _IterateAggregation(source, seed, func);
        }

        public static TResult Aggregate<TSource, TAccumulate, TResult>(
            this List<TSource> source,
            TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func,
            Func<TAccumulate, TResult> resultSelector)
        {
            EvaluateNull(source, resultSelector);
            EvaluateEmptyList(source);

            return resultSelector(_IterateAggregation(source, seed, func));
        }

        private static TAccumulate _IterateAggregation<TSource, TAccumulate>(
            List<TSource> source,
            TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func,
            int firstIndex = 0)
        {
            EvaluateNull(func);

            TAccumulate result = seed;
            for (int i = firstIndex; i < source.Count; i++)
            {
                result = func(result, source[i]);
            }

            return result;
        }
    }
}
