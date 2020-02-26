using GildedRoseRefactoring;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GildedRoseTests.UnitTests
{
    [TestClass]
    public class ConjuredTest
    {
        [TestMethod]
        public void ConjuredItem_QualityDegradesByTwo()
        {
            int originalQuality = 6;
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality - 2, alteredItem.Quality);
        }

        [TestMethod]
        public void ConjuredItem_QualityDegradesByFour()
        {
            int originalQuality = 6;
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality - 4, alteredItem.Quality);
        }

        [TestMethod]
        public void ConjuredItem_SellInDegradesByOne()
        {
            int originalSellIn = 3;
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = originalSellIn, Quality = 6 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalSellIn - 1, alteredItem.SellIn);
        }

        [TestMethod]
        public void ConjuredItem_QualityPositive()
        {
            int originalQuality = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality, alteredItem.Quality);
        }

        [TestMethod]
        public void ConjuredItem_SellInCantBeLessThenZero()
        {
            int originalSellIn = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = originalSellIn, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(0, alteredItem.SellIn);
        }
    }
}
