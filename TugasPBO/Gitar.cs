using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPBO
{
    public class Gitar
    {
        internal double harga { get; set; }
        internal string brand { get; set; }
        internal string model { get; set; }
        internal string wood { get; set; }

        public Gitar(double harga, string brand, string model, string wood)
        {
            this.harga = harga;
            this.brand = brand;
            this.model = model;
            this.wood = wood;
        }



    }
}
