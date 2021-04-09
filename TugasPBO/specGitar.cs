using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPBO
{
    class specGitar
    {
        internal string brand { get; }
        internal string model { get; }
        internal string wood { get; }

        public specGitar(string brand, string model, string wood)
        {
            this.brand = brand;
            this.model = model;
            this.wood = wood;
        }
        private bool cekstring(string data1, string data2)
        {
            if (!string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2) && string.Compare(data1, data2) == 0)
            {
                return true;
            }
            return false;
        }
        public bool Cek(specGitar spec)
        {
            if (brand != spec.brand)
            {
                return false;
            }
            if (!cekstring(model, spec.model))
            {
                return false;
            }
            if (wood != spec.wood)
            {
                return false;
            }
            return true;
        }
    }
}
