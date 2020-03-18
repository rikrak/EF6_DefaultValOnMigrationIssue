using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef6._1.Model
{
    public class MyEntity
    {
        public int Id { get; set; }

        public decimal MyDecimal { get; set; }

        // added after the first migration
        public decimal MySecondDecimal { get; set; }
    }
}
