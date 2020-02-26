using GildedRoseRefactoring;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTests.UnitTests
{
    [TestClass]
    public class AgedBrieTest
    {
        [TestMethod]
        public void AgedBrie_QualityIncresesByOne()
        {
            int originalQuality = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality + 1, alteredItem.Quality);
        }

        [TestMethod]
        public void AgedBrie_QualityIncresesByTwo()
        {
            int originalQuality = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality + 2, alteredItem.Quality);
        }

        [TestMethod]
        public void AgedBrie_QualityNotMoreThen50()
        {
            int originalQuality = 49;
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(50, alteredItem.Quality);
        }

        [TestMethod]
        public void AgedBrie_SellInCantBeLessThenZero()
        {
            int originalSellIn = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = originalSellIn, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(0, alteredItem.SellIn);
        }
    }
}
