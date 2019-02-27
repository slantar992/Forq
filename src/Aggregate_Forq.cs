using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this List<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
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
    }
}
