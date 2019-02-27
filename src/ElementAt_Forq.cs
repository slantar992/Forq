using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static TSource ElementAt<TSource>(this List<TSource> source, int index)
        {
            EvaluateNull(source);

            return source[index];
        }
    }
}
