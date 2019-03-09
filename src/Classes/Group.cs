using System.Collections.Generic;

namespace Slantar.Forq
{
    public class Group<TKey, TElement> : IGrouping<TKey, TElement>
    {
        private TKey key = default(TKey);
        private List<TElement> elements = new List<TElement>();

        public TKey Key { get { return key; } }
        public List<TElement> Elements { get { return elements; } }

        public Group(TKey key)
        {
            this.key = key;
        }

        public Group(TKey key, List<TElement> elements = null) : this(key)
        {
            if (elements != null)
            {
                elements.AddRange(elements);
            }
        }
    }
}
