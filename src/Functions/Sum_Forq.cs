using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public static partial class Forq
    {

        //int "Sum" functions
        public static int? Sum(this List<int?> source)
        {
            EvaluateNull(source);

            int? result = 0;
            int? element;

            for (int i = 0; i < source.Count; i++)
            {
                element = source[i];
                result += element == null ? 0 : element;
            }

            return result;
        }

        public static int Sum(this List<int> source)
        {
            EvaluateNull(source);

            int result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += source[i];
            }

            return result;
        }

        public static int Sum<TSource>(this List<TSource> source, Func<TSource, int> selector)
        {
            EvaluateNull(source);

            int result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += selector(source[i]);
            }

            return result;
        }

        public static int? Sum<TSource>(this List<TSource> source, Func<TSource, int?> selector)
        {
            EvaluateNull(source);

            int? result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += selector(source[i]);
            }

            return result;
        }

        //float "Sum" functions
        public static float? Sum(this List<float?> source)
        {
            EvaluateNull(source);

            float? result = 0;
            float? element;

            for (int i = 0; i < source.Count; i++)
            {
                element = source[i];
                result += element == null ? 0 : element;
            }

            return result;
        }

        public static float Sum(this List<float> source)
        {
            EvaluateNull(source);

            float result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += source[i];
            }

            return result;
        }

        public static float Sum<TSource>(this List<TSource> source, Func<TSource, float> selector)
        {
            EvaluateNull(source, selector);

            float result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += selector(source[i]);
            }

            return result;
        }

        public static float? Sum<TSource>(this List<TSource> source, Func<TSource, float?> selector)
        {
            EvaluateNull(source);

            float? result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += selector(source[i]);
            }

            return result;
        }

        //long "Sum" functions
        public static long? Sum(this List<long?> source)
        {
            EvaluateNull(source);

            long? result = 0;
            long? element;

            for (int i = 0; i < source.Count; i++)
            {
                element = source[i];
                result += element == null ? 0 : element;
            }

            return result;
        }

        public static long Sum(this List<long> source)
        {
            EvaluateNull(source);

            long result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += source[i];
            }

            return result;
        }

        public static long Sum<TSource>(this List<TSource> source, Func<TSource, long> selector)
        {
            EvaluateNull(source);

            long result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += selector(source[i]);
            }

            return result;
        }

        public static long? Sum<TSource>(this List<TSource> source, Func<TSource, long?> selector)
        {
            EvaluateNull(source);

            long? result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += selector(source[i]);
            }

            return result;
        }

        //double "Sum" functions
        public static double? Sum(this List<double?> source)
        {
            EvaluateNull(source);

            double? result = 0;
            double? element;

            for (int i = 0; i < source.Count; i++)
            {
                element = source[i];
                result += element == null ? 0 : element;
            }

            return result;
        }

        public static double Sum(this List<double> source)
        {
            EvaluateNull(source);

            double result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += source[i];
            }

            return result;
        }

        public static double? Sum<TSource>(this List<TSource> source, Func<TSource, double?> selector)
        {
            EvaluateNull(source);

            double? result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += selector(source[i]);
            }

            return result;
        }

        public static double Sum<TSource>(this List<TSource> source, Func<TSource, double> selector)
        {
            EvaluateNull(source);

            double result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += selector(source[i]);
            }


            return result;
        }

        //decimal "Sum" functions
        public static decimal Sum(this List<decimal> source)
        {
            EvaluateNull(source);

            decimal result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += source[i];
            }

            return result;
        }

        public static decimal? Sum(this List<decimal?> source)
        {
            EvaluateNull(source);

            decimal? result = 0;
            decimal? element;

            for (int i = 0; i < source.Count; i++)
            {
                element = source[i];
                result += element == null ? 0 : element;
            }

            return result;
        }
        
        public static decimal? Sum<TSource>(this List<TSource> source, Func<TSource, decimal?> selector)
        {
            EvaluateNull(source);

            decimal? result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += selector(source[i]);
            }

            return result;
        }

        public static decimal Sum<TSource>(this List<TSource> source, Func<TSource, decimal> selector)
        {
            EvaluateNull(source);

            decimal result = 0;

            for (int i = 0; i < source.Count; i++)
            {
                result += selector(source[i]);
            }

            return result;
        }
    }
}
