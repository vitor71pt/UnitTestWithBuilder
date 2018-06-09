using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builders.Domain
{
    public class VariantsBuilder
    {
        public Variants variants { get; set; }

        public VariantsBuilder()
        {
            variants = new Variants();
            variants.stockPoints = new List<StockPoints>();
            variants.availlableCountries = new List<Country>();
        }

        public VariantsBuilder WithId(int id)
        {
            this.variants.variantId = id;
            return this;
        }

        public VariantsBuilder WithStockPoint(StockPoints stockPoint)
        {
            this.variants.stockPoints.Add(stockPoint);
            return this;
        }

        public VariantsBuilder AvaillableIn(Country country)
        {
            this.variants.availlableCountries.Add(country);
            return this;
        }

        public Variants Build()
        {
            return this.variants;
        }


        /*
                public int variantId { get; set; }

        public Guid variantGuid { get; set; }

        public List<StockPoints> stockPoints { get; set; }

        public List<Country> availlableCountries { get; set; }
         
         */
    }
}
