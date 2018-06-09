using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StockPoints
    {
        public int StockPointId { get; set; }
        public Guid Uuid { get; set; }
        public int StoreId { get; set; }
        public decimal Quatity { get; set; }

        public Country Country { get; set; }
    }
}
