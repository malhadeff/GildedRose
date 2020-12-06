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
            if (Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Quality > 0)
                {
                    if (Name != "Sulfuras, Hand of Ragnaros")
                    {
                        decreaseQuality();
                    }
                }
            }
            else
            {
                if (Quality < 50)
                {
                    increaseQuality();

                    if (Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (SellIn < 11)
                        {
                            if (Quality < 50)
                            {
                                increaseQuality();
                            }
                        }

                        if (SellIn < 6)
                        {
                            if (Quality < 50)
                            {
                                increaseQuality();
                            }
                        }
                    }
                }
            }

            SellIn = SellIn - 1;
            
            if (SellIn < 0)
            {
                if (Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Quality > 0)
                    {
                        if (Name != "Sulfuras, Hand of Ragnaros")
                        {
                            decreaseQuality();
                        }
                    }
                }
                else
                {
                    Quality = 0;
                }
            }
        }

        public void increaseQuality()
        {
            if (SellIn >= 0)
                Quality++;
            else
                Quality += 2;

            if (Quality > 50)
                Quality = 50;
        }

        public void decreaseQuality()
        {
            Quality --;

            if (Quality < 0)
                Quality = 0;
        }
    }
}
