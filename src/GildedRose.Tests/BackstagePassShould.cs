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

        [Fact]
        public void IncreaseQualityByOneWhenSellInGreaterThanTen()
        {
            // Arrange
            var actual = new BackstagePassItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 2 };

            // Act
            actual.UpdateQuality();

            // Assert
            Assert.Equal(3, actual.Quality);
        }

        [Fact]
        public void DecreaseSellInByOneWhenQualityIsUpdated()
        {
            var actual = new BackstagePassItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 2 };

            actual.UpdateQuality();

            Assert.Equal(11, actual.SellIn);
        }

        [Fact]
        public void NotChangeSellInWhenSellInEqualsZero()
        {
            var actual = new BackstagePassItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 2 };

            actual.UpdateQuality();

            Assert.Equal(0, actual.SellIn);
        }
    }
}
