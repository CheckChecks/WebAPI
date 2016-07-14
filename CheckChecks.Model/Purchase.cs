using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckChecks.Model
{
    public class Purchase
    {
        public int Id { get; set; }
        [JsonIgnore]
        public int ItemId { get; set; }
        [JsonIgnore]
        public int CheckId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual Check Check { get; set; }
        public virtual Item Item { get; set; }
    }
}
