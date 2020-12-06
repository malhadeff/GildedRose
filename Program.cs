using System;
using System.Collections.Generic;

namespace csharpcore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new GildedRose();
            app.AddItem(new QualityItem { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 });
            app.AddItem(new AgingItem { Name = "Aged Brie", SellIn = 2, Quality = 0 });
            app.AddItem(new QualityItem { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 });
            app.AddItem(new LegendaryItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 });
            app.AddItem(new LegendaryItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 });
            app.AddItem(new BackstagePassItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            });
            app.AddItem(new BackstagePassItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 49
            });
            app.AddItem(new BackstagePassItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 49
            });
            app.AddItem(new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 });

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < app.Items.Count; j++)
                {
                    Console.WriteLine(app.Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
