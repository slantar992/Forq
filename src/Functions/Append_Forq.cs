using System.Collections.Generic;

namespace Slantar.Forq
{

    public static partial class Forq
    {
        public static List<TSource> Append<TSource>(
            this List<TSource> source,
            TSource element)
        {
            EvaluateNull(source);

            source.Add(element);

            return source;
        }
    }
}