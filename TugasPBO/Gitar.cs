using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPBO
{
    public class Gitar
    {
        internal double harga { get; set; }
        internal string brand { get; }
        internal string model { get; }
        internal string wood { get; }

        public Gitar(double harga, string brand, string model, string wood)
        {
            this.harga = harga;
            this.brand = brand;
            this.model = model;
            this.wood = wood;
        }


    }
}
