using Xunit;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void EndOfDay()
        {
            IList<QualityItem> Items = new List<QualityItem> { new QualityItem { Name = "foo", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(9, Items[0].SellIn);
            Assert.Equal(19, Items[0].Quality);
        }

        [Fact]
        public void PassedArticlesQualityDecreaseFaster()
        {
            IList<QualityItem> Items = new List<QualityItem> { new QualityItem { Name = "foo", SellIn = 0, Quality = 20 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(18, Items[0].Quality);
        }

        [Fact]
        public void QualityMustAlwaysBePositive()
        {
            IList<QualityItem> Items = new List<QualityItem> { new QualityItem { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void AgedBrieQualityMustIncrease()
        {
            IList<QualityItem> Items = new List<QualityItem> { new AgingItem { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(11, Items[0].Quality);
        }

        [Fact]
        public void QualityMustBeLowerThanOrEqualToFifty()
        {
            IList<QualityItem> Items = new List<QualityItem> { new AgingItem { Name = "Aged Brie", SellIn = 0, Quality = 50 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        public void LegendaryProductsNeverChange()
        {
            IList<QualityItem> Items = new List<QualityItem> { new LegendaryItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 25 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(5, Items[0].SellIn);
            Assert.Equal(25, Items[0].Quality);
        }

        [Fact]
        public void BackstagePassesQualityMustIncrease()
        {
            IList<QualityItem> Items = new List<QualityItem> { new BackstagePassItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(1, Items[0].Quality);
        }

        [Fact]
        public void BackstagePassesQualityMustIncreaseFaster()
        {
            IList<QualityItem> Items = new List<QualityItem> { new BackstagePassItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(2, Items[0].Quality);
        }

        [Fact]
        public void BackstagePassesQualityMustIncreaseEvenFaster()
        {
            IList<QualityItem> Items = new List<QualityItem> { new BackstagePassItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(3, Items[0].Quality);
        }

        [Fact]
        public void PassedBackstagePassesQualityMustBeZero()
        {
            IList<QualityItem> Items = new List<QualityItem> { new BackstagePassItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void ConjuredItemsQualityDecreaseFaster()
        {
            IList<QualityItem> Items = new List<QualityItem> { new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(18, Items[0].Quality);
        }
    }
}