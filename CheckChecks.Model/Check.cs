using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckChecks.Model
{
    public class Check
    {
        public int Id { get; set; }
        public string Shop { get; set; }
        public decimal Total { get; set; }

        public virtual List<Purchase> Purcheses { get; set; }
    }
}
