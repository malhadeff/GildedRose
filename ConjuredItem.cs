using System;
namespace csharpcore
{
    public class ConjuredItem : QualityItem
    {
        public ConjuredItem()
            : base()
        {
        }

        public override void UpdateQuality()
        {
            SellIn--;
            Quality -= 2;
        }
    }
}
