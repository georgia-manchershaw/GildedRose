using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class ItemFactoryShould
    {
        [Fact]
        public void CreateNewSulfurasItem()
        {
            // Arrange
            var expected = new SulfurasItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 };

            // Act
            var factory = new ItemFactory();
            var actual = factory.CreateItem("Sulfuras, Hand of Ragnaros", 0, 80);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateNewItem()
        {
            // Arrange
            var expected = new Item { Name = "RegularItem", SellIn = 0, Quality = 81 };

            // Act
            var factory = new ItemFactory();
            var actual = factory.CreateItem("RegularItem", 0, 81);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateBackstagePassItem()
        {
            // Arrange
            var expected = new BackstagePassItem {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 14, Quality = 21 };

            // Act
            var factory = new ItemFactory();
            var actual = factory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 14, 21);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
