using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builders.Domain
{
    public class CountriesBuilder
    {
        private Country countryContext;
        public CountriesBuilder()
        {
            this.countryContext = new Country();
        }
        
        public CountriesBuilder WithId(int id)
        {
            this.countryContext.Id = id;
            return this;
        }

        public CountriesBuilder WithName(string name)
        {
            this.countryContext.Name = name;
            return this;
        }

        public Country Build()
        {
            return this.countryContext;
        }

        /*
         
        public int Id { get; set; }

        public string Name { get; set; }

        public string Iso2Code { get; set; }

        public string Iso3Code { get; set; }

         
         */
    }
}
