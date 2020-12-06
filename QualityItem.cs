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
            if (Name != "Aged Brie" && Name != "Backstage passes to a TAFKAL80ETC concert")
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

            if (Name != "Sulfuras, Hand of Ragnaros")
            {
                SellIn = SellIn - 1;
            }

            if (SellIn < 0)
            {
                if (Name != "Aged Brie")
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
                        decreaseQuality(Quality);
                    }
                }
                else
                {
                    if (Quality < 50)
                    {
                        increaseQuality();
                    }
                }
            }
        }

        public void increaseQuality(int amount=1)
        {
            Quality += amount;

            if (Quality > 50)
                Quality = 50;
        }

        public void decreaseQuality(int amount=1)
        {
            Quality -= amount;

            if (Quality < 0)
                Quality = 0;
        }
    }
}
