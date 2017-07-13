namespace GildedRose.Console
{
    public class SulfurasItem : Item
    {
        private static readonly int FixedLengendaryQuality = 80;

        public override void UpdateQuality()
        {
            Quality = FixedLengendaryQuality; 
        }
    }
}