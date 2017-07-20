using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        public IList<Item> Items;
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var factory = new ItemFactory();

            var app = new Program()
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

            app.UpdateQuality();

            System.Console.ReadKey();

        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.UpdateQuality();
            }
        }
    }
}
