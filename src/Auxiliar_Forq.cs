using System;
using System.Collections.Generic;

namespace Slantar.Forq
{
    public static partial class Forq 
    {
        private static void EvaluateNull(params object[] objects)
        {
            for(int i = 0; i < objects.Length; i++)
            {
                if(objects[i] == null) throw new ArgumentNullException();
            }
        }

        private static void EvaluateEmptyList<T>(List<T> list)
        {
            if (list.Count < 1) throw new InvalidOperationException("list contains no elements.");
        }
    }
} 
