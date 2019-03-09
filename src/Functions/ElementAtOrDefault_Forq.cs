using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static TSource ElementAtOrDefault<TSource> (this List<TSource> source, int index)
        {
            EvaluateNull(source);

            return 
                index >= 0 && index < source.Count ?
                source[index] : 
                default(TSource);
        }
    }
}

