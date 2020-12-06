using System;
namespace csharpcore
{
    public class BackstagePassItem : QualityItem
    {
        public BackstagePassItem()
            : base()
        {
        }

        public override void UpdateQuality()
        {
            SellIn--;

            if (SellIn >= 10)
                increaseQuality();
            else if (SellIn >= 5)
                increaseQuality(2);
            else if (SellIn >= 0)
                increaseQuality(3);
            else
                Quality = 0;
        }
    }
}
