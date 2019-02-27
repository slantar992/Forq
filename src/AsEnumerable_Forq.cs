using System.Collections.Generic;

namespace Slantar.Forq
{
    public static partial class Forq
    {
        //"AsEnumerable" function
        public static IEnumerable<TSource> AsEnumerable<TSource>(this List<TSource> source)
        {
            EvaluateNull(source);

            return source;
        }
    }
}
