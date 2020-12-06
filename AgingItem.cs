using System;
namespace csharpcore
{
    public class AgingItem : QualityItem
    {
        public AgingItem()
            : base()
        {
        }

        public override void UpdateQuality()
        {
            SellIn--;

            if (SellIn >= 0)
                increaseQuality();
            else
                increaseQuality(2);
        }
    }
}
