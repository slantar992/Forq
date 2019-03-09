using System.Collections.Generic;

namespace Slantar.Forq
{
    public partial class Forq
    {
        public static List<TResult> Cast<TResult>(this List<object> list)
        {
            EvaluateNull(list);
            List<TResult> result = new List<TResult>(list.Count);

            for(int i = 0; i < list.Count; i++)
            {
                result[i] = (TResult) list[i];
            }

            return result;
        }
    }
}
