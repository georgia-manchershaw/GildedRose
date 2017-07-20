namespace GildedRose.Console
{
    public class ItemFactory
    {
        public Item CreateItem(string itemName, int sellIn, int quality)
        {
            if (itemName == "Sulfuras, Hand of Ragnaros")
            {
                return new SulfurasItem { Name = itemName, SellIn = sellIn, Quality = quality };
            }
            return new Item { Name = itemName, SellIn = sellIn, Quality = quality };
        }
    }
}