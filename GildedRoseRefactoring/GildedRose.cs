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
                if (i.Name != "Aged Brie" && i.Name != "Backstage passes to a TAFKAL80ETC concert" && i.Name != "Sulfuras, Hand of Ragnaros")
                {
                    if (i.Quality > 0)
                    {
                        i.Quality -= 1;
                        if (i.Name == "Conjured Mana Cake")
                        {
                            i.Quality -= 1;
                        }
                        if (i.SellIn <= 0)
                        {
                            if (i.Quality > 0)
                            {
                                i.Quality -= 1;
                                if (i.Name == "Conjured Mana Cake")
                                {
                                    i.Quality -= 1;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (i.Quality < 50 && i.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        i.Quality += 1;

                        if (i.Name == "Aged Brie")
                        {
                            if (i.SellIn <= 0)
                            {
                                if (i.Quality < 50)
                                {
                                    i.Quality += 1;
                                }

                            }
                        }

                        if (i.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (i.SellIn < 11 && i.SellIn > 6)
                            {
                                if (i.Quality < 50)
                                {
                                    i.Quality += 1;
                                }
                            }

                            if (i.SellIn < 6 && i.SellIn > 1)
                            {
                                if (i.Quality < 50)
                                {
                                    i.Quality += 2;
                                }
                            }
                        }
                    }
                }

                if (i.Name != "Sulfuras, Hand of Ragnaros")
                {
                    i.SellIn -= 1;
                    if (i.SellIn < 0)
                    {
                        i.SellIn = 0;
                        if (i.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            i.Quality = 0;
                        }

                    }
                }
            }
        }
    }
}
