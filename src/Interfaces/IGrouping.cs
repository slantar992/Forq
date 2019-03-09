using System.Collections.Generic;

namespace Slantar.Forq
{
    public interface IGrouping<TKey, TElement>
    {
        TKey Key { get; }
        List<TElement> Elements { get; }
    }
}

