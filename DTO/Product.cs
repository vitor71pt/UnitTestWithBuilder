using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Product
    {
        public string Description { get; set; }

        public List<Variants> Variants { get; set; }
    }
}
