using System;
namespace csharpcore
{
    public class QualityItem : Item
    {
        public QualityItem()
            : base()
        {
        }

        public virtual void UpdateQuality()
        {
            SellIn--;

            if (SellIn >= 0)
                decreaseQuality();
            else
                decreaseQuality(2);
        }

        public void increaseQuality(int amount=1)
        {
            Quality += amount;

            if (Quality > 50)
                Quality = 50;
        }

        public void decreaseQuality(int amount=1)
        {
            Quality-=amount;

            if (Quality < 0)
                Quality = 0;
        }
    }
}
