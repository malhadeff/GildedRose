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
            if (SellIn >= 0)
            {
                IncreaseQuality();
            }
            else
            {
                IncreaseQuality(2);
            }
        }
    }
}
