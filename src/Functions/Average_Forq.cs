
using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public static partial class Forq
    {
        //float "Average" functions
        public static float Average(
            this List<float> source)
        {
            EvaluateNull(source);
            EvaluateEmptyList(source);

            return Sum(source) / source.Count;
        }
        
        public static float? Average(
            this List<float?> source)
        {
            EvaluateNull(source);
            EvaluateEmptyList(source);

            return Sum(source) / source.Count;
        }

        public static float Average<TSource>(
            this List<TSource> source,
            Func<TSource, float> selector)
        {
            EvaluateNull(source, selector);
            EvaluateEmptyList(source);

            return Sum(source, selector) / source.Count;
        }

        public static float? Average<TSource>(
            this List<TSource> source,
            Func<TSource, float?> selector)
        {
            EvaluateNull(source, selector);
            EvaluateEmptyList(source);

            return Sum(source, selector) / source.Count;
        }

        //double "Average" functions
        public static double? Average(
            this List<double?> source)
        {
            EvaluateNull(source);
            EvaluateEmptyList(source);

            return Sum(source) / source.Count;
        }

        public static double Average(
            this List<double> source)
        {
            EvaluateNull(source);
            EvaluateEmptyList(source);

            return Sum(source) / source.Count;
        }
        
        public static double Average(
            this List<int> source)
        {
            EvaluateNull(source);
            EvaluateEmptyList(source);

            return Sum(source) / source.Count;
        }

        public static double Average(
            this List<long> source)
        {
            EvaluateNull(source);
            EvaluateEmptyList(source);

            return Sum(source) / source.Count;
        }

        public static double Average<TSource> (
            this List<TSource> source,
            Func<TSource, int?> selector)
        {
            EvaluateNull(source, selector);
            EvaluateEmptyList(source);

            return (double) Sum(source, selector) / source.Count;
        }

        public static double? Average<TSource>(
            this List<TSource> source,
            Func<TSource, long?> selector)
        {
            EvaluateNull(source, selector);
            EvaluateEmptyList(source);

            return Sum(source, selector) / source.Count;
        }

        public static double? Average<TSource>(
            this List<TSource> source,
            Func<TSource, double?> selector)
        {
            EvaluateNull(source, selector);
            EvaluateEmptyList(source);

            return Sum(source, selector) / source.Count;
        }

        public static double Average<TSource>(
            this List<TSource> source,
            Func<TSource, long> selector)
        {
            EvaluateNull(source, selector);
            EvaluateEmptyList(source);

            return Sum(source, selector) / source.Count;
        }

        public static double Average<TSource>(
            this List<TSource> source,
            Func<TSource, int> selector)
        {
            EvaluateNull(source, selector);
            EvaluateEmptyList(source);

            return Sum(source, selector) / source.Count;
        }

        public static double Average<TSource>(
            this List<TSource> source,
            Func<TSource, double> selector)
        {
            EvaluateNull(source, selector);
            EvaluateEmptyList(source);

            return Sum(source, selector) / source.Count;
        }

        //decimal "Average" function
        public static decimal Average(
            this List<decimal> source)
        {
            EvaluateNull(source);
            EvaluateEmptyList(source);

            return Sum(source) / source.Count;
        }

        public static decimal? Average(
            this List<decimal?> source)
        {
            EvaluateNull(source);
            EvaluateEmptyList(source);

            return Sum(source) / source.Count;
        }

        public static decimal? Average<TSource>(
            this List<TSource> source,
            Func<TSource, decimal?> selector)
        {
            EvaluateNull(source, selector);
            EvaluateEmptyList(source);

            return Sum(source, selector) / source.Count;
        }

        public static decimal Average<TSource>(
            this List<TSource> source,
            Func<TSource, decimal> selector)
        {
            EvaluateNull(source, selector);
            EvaluateEmptyList(source);

            return Sum(source, selector) / source.Count;
        }
    }
}
