using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static List<TSource> Concat<TSource>(this List<TSource> first, List<TSource> second)
        {
            EvaluateNull(first, second);

            first.AddRange(second);

            return first;
        }
    }
}
