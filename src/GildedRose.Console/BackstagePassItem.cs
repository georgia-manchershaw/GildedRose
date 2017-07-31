namespace GildedRose.Console
{
    public class BackstagePassItem : Item
    {
        public override void UpdateQuality()
        {
            IncreaseByTwoWhenSellinIsGreaterThanFiveAndLessThanOrEqualToTen();

            IncreaseByThreeWhenSellInGreaterThanZeroAndLessThanOrEqualToFive();

            IsZeroWhenSellInIsZero();

            IncreaseByOneWhenSellInIsGreaterThanTen();

            ReduceSellInByOneUnlessSellInIsZero();
        }

        private void ReduceSellInByOneUnlessSellInIsZero()
        {
            if (SellIn != 0)
            {
                SellIn = SellIn - 1;
            }
        }

        private void IncreaseByOneWhenSellInIsGreaterThanTen()
        {
            if (SellIn > 10)
            {
                Quality = Quality + 1;
            }
        }

        private void IsZeroWhenSellInIsZero()
        {
            if (SellIn == 0)
            {
                Quality = 0;
            }
        }

        private void IncreaseByThreeWhenSellInGreaterThanZeroAndLessThanOrEqualToFive()
        {
            if (SellIn > 0 && SellIn <= 5)
            {
                Quality = Quality + 3;
            }
        }

        private void IncreaseByTwoWhenSellinIsGreaterThanFiveAndLessThanOrEqualToTen()
        {
            if (SellIn > 5 && SellIn <= 10)
            {
                Quality = Quality + 2;
            }
        }
    }
}