using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class SulfurasItemShould
    {
        [Fact]
        public void NotUpdateSellinValue()
        {
            var sulfurasItem = new SulfurasItem{Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80};
            //act
            sulfurasItem.UpdateQuality();
                
            //assert
            Assert.Equal(0, sulfurasItem.SellIn);
        }

        [Fact]
        public void NotDecreaseInQuality()
        {
            var sulfurasItem = new SulfurasItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 };
            //act
            sulfurasItem.UpdateQuality();

            //assert
            Assert.Equal(80, sulfurasItem.Quality);
        }

     
        [Fact]
        public void NotChangeItsQuality()
        {
            var sulfurasItem = new SulfurasItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 79 };

            sulfurasItem.UpdateQuality();

            Assert.Equal(80, sulfurasItem.Quality);
        }
    }
}
