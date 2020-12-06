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
            Quality -= 2;
        }
    }
}
