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
            increaseQuality();
        }
    }
}
