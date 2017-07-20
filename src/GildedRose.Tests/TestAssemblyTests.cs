using System;
using System.Collections.Generic;
using System.Diagnostics;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        [Fact]
        public void Harness()
        {
            var program = new Program
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                }
            };

            var expectedItems = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 9, Quality = 19},
                new Item {Name = "Aged Brie", SellIn = 1, Quality = 1},
                new Item {Name = "Elixir of the Mongoose", SellIn = 4, Quality = 6},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 14,
                    Quality = 21
                },
                new Item {Name = "Conjured Mana Cake", SellIn = 2, Quality = 5}
            };

            program.UpdateQuality();
            
            Assert.Equal(expectedItems, program.Items);
        }

        [Fact]
        public void HarnessWithFactory()
        {
            // Arrange
            var factory = new ItemFactory();

            var program = new Program
            {
                Items = new List<Item>
                {
                    factory.CreateItem("+5 Dexterity Vest", 10, 20),
                    factory.CreateItem("Aged Brie", 2, 0),
                    factory.CreateItem("Elixir of the Mongoose", 5, 7),
                    factory.CreateItem("Sulfuras, Hand of Ragnaros", 0, 80),
                    factory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                    factory.CreateItem("Conjured Mana Cake", 3, 6)
                }
            };

            var expectedItems = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 9, Quality = 19},
                new Item {Name = "Aged Brie", SellIn = 1, Quality = 1},
                new Item {Name = "Elixir of the Mongoose", SellIn = 4, Quality = 6},
                new SulfurasItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 14,
                    Quality = 21
                },
                new Item {Name = "Conjured Mana Cake", SellIn = 2, Quality = 5}
            };

            // Act
            program.UpdateQuality();

            // Assert
            Assert.Equal(expectedItems, program.Items);
        }
    }
}