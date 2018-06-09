using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Variants
    {
        public int variantId { get; set; }

        public Guid variantGuid { get; set; }

        public List<StockPoints> stockPoints { get; set; }

        public List<Country> availlableCountries { get; set; }
    }
}
