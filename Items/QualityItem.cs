namespace csharpcore
{
    public class QualityItem : Item
    {
        public QualityItem()
            : base()
        {
        }

        public virtual void UpdateSellIn()
        {
            SellIn--;
        }

        public virtual void UpdateQuality()
        {
            if (SellIn >= 0)
            {
                DecreaseQuality();
            }
            else
            {
                DecreaseQuality(2);
            }
        }

        public void IncreaseQuality(int amount = 1)
        {
            Quality += amount;

            if (Quality > 50)
            {
                Quality = 50;
            }
        }

        public void DecreaseQuality(int amount = 1)
        {
            Quality-=amount;

            if (Quality < 0)
            {
                Quality = 0;
            }
        }

        public override string ToString()
        {
            return $"{Name}, {SellIn}, {Quality}";
        }
    }
}
