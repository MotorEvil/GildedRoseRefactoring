using System.Collections.Generic;

namespace GildedRoseRefactoring
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item i in Items)
            {
                if (i.Name == "+5 Dexterity Vest" || i.Name == "Elixir of the Mongoose")
                {
                    i.SellIn -= 1; 

                    if (i.Quality > 0)
                    {
                        i.Quality -= 1;
                    }

                    if (i.SellIn < 0)
                    {
                        i.SellIn = 0;

                        if (i.Quality > 0)
                        {
                            i.Quality -= 1;
                        }
                    }
                }

                if (i.Name == "Aged Brie")
                {
                    i.SellIn -= 1;

                    if (i.Quality < 50)
                    {
                        i.Quality += 1;
                    }

                    if (i.SellIn < 0)
                    {
                        i.SellIn = 0;

                        if (i.Quality < 50)
                        {
                            i.Quality += 1;
                        }
                    }
                }

                if (i.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    i.SellIn -= 1;

                    if (i.SellIn > 0)
                    {
                        if (i.Quality < 50)
                        {
                            i.Quality += 1;
                        }
                    }

                    if (i.SellIn < 6)
                    {
                        if (i.Quality < 50)
                        {
                            i.Quality += 1;
                        }
                    }

                    if (i.SellIn < 11)
                    {
                        if (i.Quality < 50)
                        {
                            i.Quality += 1;
                        }
                    }

                    if (i.SellIn < 0)
                    {
                        i.SellIn = 0; 
                        i.Quality = 0;
                    }
                }

                if (i.Name == "Conjured Mana Cake")
                {
                    i.SellIn -= 1;

                    if (i.Quality > 0)
                    {
                        i.Quality -= 2;
                    }

                    if (i.SellIn < 0)
                    {
                        i.SellIn = 0;

                        if (i.Quality > 0)
                        {
                            i.Quality -= 2;
                        }
                    }
                }
            }
        }
    }
}
