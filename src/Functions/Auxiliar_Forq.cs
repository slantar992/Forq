using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public static partial class Forq 
    {
        private static Func<TKey, TKey, bool> GetEqualityPredicate<TKey>(
            IEqualityComparer<TKey> comparer)
        {
            return (comparer == null) ?
                (Func<TKey, TKey, bool>)((key, keyElement) => key.Equals(keyElement)) :
                                         (key, keyElement) => comparer.Equals(key, keyElement);
        }

        private static void EvaluateNull(params object[] objects)
        {
            for(int i = 0; i < objects.Length; i++)
            {
                if(objects[i] == null) throw new ArgumentNullException();
            }
        }

        private static void EvaluateEmptyList<T>(List<T> list)
        {
            if (list.Count < 1) throw new InvalidOperationException("The source list is empty.");
        }
    }
} 
