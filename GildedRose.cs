using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        IList<QualityItem> Items;
        public GildedRose(IList<QualityItem> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                Items[i].UpdateQuality();
            }
        }
    }
}
