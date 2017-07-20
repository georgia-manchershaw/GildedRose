namespace GildedRose.Console
{
    public class BackstagePassItem : Item
    {
        public override void UpdateQuality()
        {
            if (SellIn > 5 && SellIn <= 10)
            {
                Quality = Quality + 2;
            }
            if (SellIn > 0 && SellIn <= 5)
            {
                Quality = Quality + 3;
            }
            if (SellIn == 0)
            {
                Quality = 0;
            }
        }
    }
}