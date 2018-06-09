namespace UnitTest
{
    using Builders.Domain;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    [TestClass]
    public class Variants
    {

        [TestMethod]
        public void TestEmployee()
        {
            var builder = new VariantsBuilder();

            var variantBuilder = builder
                .WithId(10)
                .WithStockPoint(new StockPointBuilder().WithId(1).Build())
                .WithStockPoint(new StockPointBuilder()
                                .WithId(2)
                                .WithCountry(new CountriesBuilder()
                                    .WithId(2)
                                    .WithName("Portugal")
                                    .Build()
                                ).Build())
                .AvaillableIn(new CountriesBuilder()
                                .WithId(1)
                                .WithName("france")
                                .Build());

            var variant = variantBuilder.Build();

            Assert.AreEqual(10, variant.variantId);
            Assert.AreEqual(2, variant.stockPoints.Count());
            Assert.AreEqual(1, variant.stockPoints[0].StockPointId);
            Assert.AreEqual(2, variant.stockPoints[1].StockPointId = 2);
            Assert.AreEqual(2, variant.stockPoints[1].Country.Id);
            Assert.AreEqual("Portugal", variant.stockPoints[1].Country.Name);
            Assert.AreEqual(1, variant.availlableCountries.Count());
            Assert.AreEqual(1, variant.availlableCountries[0].Id);
            Assert.AreEqual("france", variant.availlableCountries[0].Name);
        }
    }
}
