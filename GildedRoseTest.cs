using Xunit;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void endOfDay()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(9, Items[0].SellIn);
            Assert.Equal(19, Items[0].Quality);
        }

        [Fact]
        public void passedArticlesQualityDecreaseFaster()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 20 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(18, Items[0].Quality);
        }

        [Fact]
        public void qualtiyMustAlwaysBePositive()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void agedBrieQualityMustIncrease()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(11, Items[0].Quality);
        }

        [Fact]
        public void qualityMustBeLowerThanOrEqualToFifty()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        public void legendaryProductsNeverChange()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 25 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(5, Items[0].SellIn);
            Assert.Equal(25, Items[0].Quality);
        }

        [Fact]
        public void backstagePassesQualityMustIncrease()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(1, Items[0].Quality);
        }

        [Fact]
        public void backstagePassesQualityMustIncreaseFaster()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(2, Items[0].Quality);
        }

        [Fact]
        public void backstagePassesQualityMustIncreaseEvenFaster()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(3, Items[0].Quality);
        }

        [Fact]
        public void passedBackstagePassesQualityMustBeZero()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void conjuredItemsQualityDecreaseFaster()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(18, Items[0].Quality);
        }
    }
}