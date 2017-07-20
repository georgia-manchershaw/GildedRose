using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    
    public class BackstagePassShould
    {
        [Fact]
        public void IncreaseQualityByTwoWhenSellInValueIsGreaterThanFiveAndLessThanOrEqualToTen()
        {
            // Arrange
            var actual = new BackstagePassItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 2 };

            // Act
            actual.UpdateQuality();
            
            // Assert
            Assert.Equal(4, actual.Quality);
        }

        [Fact]
        public void IncreaseQualityByThreeWhenSellInValueIsGreaterThanZeroAndLessThaFive()
        {
            // arrange
            var actual = new BackstagePassItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 2 };

            // Act
            actual.UpdateQuality();

            // Assert
            Assert.Equal(5, actual.Quality);
        }

        [Fact]
        public void HaveQualityZeroWhenSellInIsZero()
        {
            // arrange
            var actual = new BackstagePassItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 2 };

            // Act
            actual.UpdateQuality();

            // Assert
            Assert.Equal(0, actual.Quality);
        }
    }

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
