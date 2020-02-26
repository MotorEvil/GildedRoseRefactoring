using System.Collections.Generic;
using GildedRoseRefactoring;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRoseTests.UnitTests
{
    [TestClass]
    public class NormalItemsTest
    {
        [TestMethod]
        public void Vest_QualityDegradesByOne()
        {
            int originalQuality = 20;
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality - 1, alteredItem.Quality);
        }

        [TestMethod]
        public void Vest_SellInCantBeLessThenZero()
        {
            int originalSellIn = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = originalSellIn, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(0, alteredItem.SellIn);
        }

        [TestMethod]
        public void Vest_SellInDegradesByOne()
        {
            int originalSellIn = 10;
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = originalSellIn, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalSellIn - 1, alteredItem.SellIn);
        }

        [TestMethod]
        public void Vest_QualityDegradesByTwo()
        {
            int originalQuality = 20;
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality - 2, alteredItem.Quality);
        }

        [TestMethod]
        public void Vest_QualityPositive()
        {
            int originalQuality = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality, alteredItem.Quality);
        }

        [TestMethod]
        public void MonGoose_QualityDegradesByOne()
        {
            int originalQuality = 20;
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 10, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality - 1, alteredItem.Quality);
        }

        [TestMethod]
        public void MonGoose_SellInDegradesByOne()
        {
            int originalSellIn = 10;
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = originalSellIn, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalSellIn - 1, alteredItem.SellIn);
        }

        [TestMethod]
        public void MonGoose_SellInDegradesByTwo()
        {
            int originalQuality = 20;
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality - 2, alteredItem.Quality);
        }

        [TestMethod]
        public void MonGoose_QualityPositive()
        {
            int originalQuality = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = originalQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQuality, alteredItem.Quality);
        }

        [TestMethod]
        public void MonGoose_SellInCantBeLessThenZero()
        {
            int originalSellIn = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = originalSellIn, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(0, alteredItem.SellIn);
        }
    }
}
