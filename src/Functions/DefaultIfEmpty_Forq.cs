using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static List<TSource> DefaultIfEmpty<TSource>(this List<TSource> source, TSource defaultValue)
        {
            if (source == null)
            {
                List<TSource> result = new List<TSource>();
                result.Add(defaultValue);
                return result;
            }
            else if(source.Count == 0)
            {
                source.Add(defaultValue);
                return source;
            }
            else
            {
                return source;
            }
        }

        public static List<TSource> DefaultIfEmpty<TSource>(this List<TSource> source)
        {
            EvaluateNull(source);

            if(source.Count == 0)
            {
                source.Add(default(TSource));
            }

            return source;
        }
    }
}
