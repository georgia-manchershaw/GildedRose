namespace GildedRose.Console
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public override bool Equals(object obj)
        {
            var item = obj as Item;
            if (item != null)
            {
                return item.Name == Name &&
                       item.Quality == Quality &&
                       item.SellIn == SellIn;
            }

            return base.Equals(obj);
        }
    }
}