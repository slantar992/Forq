using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static List<TResult> Select<TSource, TResult>(this List<TSource> source, Func<TSource, int, TResult> selector)
        {
            EvaluateNull(source, selector);

            List<TResult> result = new List<TResult>();

            for (int i = 0; i < source.Count; i++)
            {
                result.Add(selector(source[i], i));
            }

            return result;
        }

        public static List<TResult> Select<TSource, TResult>(this List<TSource> source, Func<TSource, TResult> selector)
        {
            EvaluateNull(source, selector);

            List<TResult> result = new List<TResult>();

            for (int i = 0; i < source.Count; i++)
            {
                result.Add(selector(source[i]));
            }

            return result;
        }
    }
}

