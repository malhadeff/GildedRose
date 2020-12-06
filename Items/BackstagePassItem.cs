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
            if (SellIn >= 10)
            {
                IncreaseQuality();
            }
            else if (SellIn >= 5)
            {
                IncreaseQuality(2);
            }
            else if (SellIn >= 0)
            {
                IncreaseQuality(3);
            }
            else
            {
                Quality = 0;
            }
        }
    }
}
