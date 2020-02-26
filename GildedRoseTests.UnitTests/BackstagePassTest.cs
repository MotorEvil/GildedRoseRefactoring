using GildedRoseRefactoring;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GildedRoseTests.UnitTests
{
    [TestClass]
    public class BackstagePassTest
    {
        [TestMethod]
        public void BackStagePass_QualityIncreasesByOne_SellInMoreThenTen()
        {
            int originalQality = 20;
            int originalSellIn = 15;
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = originalSellIn, Quality = originalQality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQality + 1, alteredItem.Quality);
        }

        [TestMethod]
        public void BackStagePass_QualityIncreasesByTwo_SellInLessThenTen()
        {
            int originalQality = 20;
            int originalSellIn = 10;
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = originalSellIn, Quality = originalQality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQality + 2, alteredItem.Quality);
        }

        [TestMethod]
        public void BackStagePass_QualityIncreasesByThree_SellInLessThenFive()
        {
            int originalQality = 20;
            int originalSellIn = 5;
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = originalSellIn, Quality = originalQality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(originalQality + 3, alteredItem.Quality);
        }

        [TestMethod]
        public void BackStagePass_QualityZeroWhenSellInZero()
        {
            int originalQality = 20;
            int originalSellIn = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = originalSellIn, Quality = originalQality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(0, alteredItem.Quality);
        }

        [TestMethod]
        public void BackStagePass_QualityLessThenFifty()
        {
            int originalQality = 49;
            int originalSellIn = 10;
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = originalSellIn, Quality = originalQality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(50, alteredItem.Quality);
        }

        [TestMethod]
        public void BackStagePass_SellInCantBeLessThenZero()
        {
            int originalSellIn = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = originalSellIn, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Item alteredItem = Items[0];
            Assert.AreEqual(0, alteredItem.SellIn);
        }
    }
}
