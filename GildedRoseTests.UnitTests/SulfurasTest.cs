using GildedRoseRefactoring;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GildedRoseTests.UnitTests
{
    [TestClass]
    public class SulfurasTest
    {
        [TestMethod]
        public void Sulfuras_QualityDoesntChange_PositiveSellIn()
        {
            int originalQuality = 80;
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality, alteredItem.Quality);
        }

        [TestMethod]
        public void Sulfuras_SellInDoesntChange_PositiveSellIn()
        {
            int originalSellIn = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = originalSellIn, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalSellIn, alteredItem.SellIn);
        }

        [TestMethod]
        public void Sulfuras_QualityDoesntChange_NegativeSellIn()
        {
            int originalQuality = 80;
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality, alteredItem.Quality);
        }

        [TestMethod]
        public void Sulfuras_SellInDoesntChange_NegativeSellIn()
        {
            int originalSellIn = -1;
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = originalSellIn, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalSellIn, alteredItem.SellIn);
        }

    }
}
