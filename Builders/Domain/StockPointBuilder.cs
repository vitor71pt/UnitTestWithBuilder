using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builders.Domain
{
    public class StockPointBuilder
    {
        private StockPoints stockPoint;

        public StockPointBuilder()
        {
            this.stockPoint = new StockPoints();
        }

        public StockPointBuilder WithId(int id)
        {
            this.stockPoint.StockPointId = id;
            return this;
        }

        public StockPointBuilder WithStoreId(int id)
        {
            this.stockPoint.StockPointId = id;
            return this;
        }

        public StockPointBuilder WithQuantity(decimal quantity)
        {
            this.stockPoint.Quatity= quantity;
            return this;
        }

        public StockPointBuilder WithCountry(Country country)
        {
            this.stockPoint.Country = country;
            return this;
        }

        public StockPoints Build()
        {
            return this.stockPoint;
        }
        /*
        
        public int StockPointId { get; set; }
        public Guid Uuid { get; set; }
        public int StoreId { get; set; }
        public decimal Quatity { get; set; }

        public Country Country { get; set; }

         */
    }
}
