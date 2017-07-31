using System;

namespace GildedRose.Console
{
    public class ItemFactory
    {
        public Item CreateItem(string itemName, int sellIn, int quality)
        {
            if (string.Compare(itemName, "Sulfuras, Hand of Ragnaros", StringComparison.InvariantCultureIgnoreCase) == 0)
            {
                return new SulfurasItem { Name = itemName, SellIn = sellIn, Quality = quality };
            }

            if (string.Compare(itemName, "Backstage passes to a TAFKAL80ETC concert", StringComparison.InvariantCultureIgnoreCase) == 0)
            {
                return new BackstagePassItem { Name = itemName, SellIn = sellIn, Quality = quality };
            }
            return new Item { Name = itemName, SellIn = sellIn, Quality = quality };
        }
    }
}