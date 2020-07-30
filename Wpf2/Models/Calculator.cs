using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2.Models
{
    class Calculator
    {
        public double Lhs { get; set; }

        public double Rhs { get; set; }

        public double Result { get; private set; }

        public void ExeuteDiv()
        {
            this.Result = this.Lhs / this.Rhs;
        }
    }
}
