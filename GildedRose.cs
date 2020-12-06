using System;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        public IList<QualityItem> Items { get; private set; }

        public GildedRose()
        {
            Items = new List<QualityItem>();
        }

        public GildedRose(IList<QualityItem> items)
        {
            Items = items ?? throw new ArgumentNullException("items");
        }

        public void UpdateQuality()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].UpdateSellIn();
                Items[i].UpdateQuality();
            }
        }

        public void AddItem(QualityItem item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            else
                Items.Add(item);
        }
    }
}
