using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace TugasPBO
{
    class Data
    {
        private List<Gitar> guitar;

        public Data()
        {
            guitar = new List<Gitar>;
        }
        internal string brand { get; }
        internal string model { get; }
        internal string wood { get; }
        internal double harga { get; }
        public void addGitar(double harga, string brand, string model, string wood)
        {
            Gitar gitars = new Gitar(harga, brand, model, wood);
            guitar.Add(gitars);
        }

        public overide List<String> gitars()
        private static void writeinven()
        public Gitar search(Gitar searchGitar)
        {
            for (int i = 0; i < guitar.Count; i++)
            {
                Gitar gitars = guitar[i];

                if (!sama(searchGitar.brand, guitar.brand))
                {
                    continue;
                }
                if (!sama(searchGitar.model, guitar.model))
                {
                    continue;
                }
                if (!sama(searchGitar.wood, guitar.wood))
                {
                    continue;
                }
            }
            return null;
        }
        private bool sama(string data1, string data2)
        {
            if (!string.IsNullOrEmpty(data1)) && !string.IsNullOrEmpty(data2) && string.Compare(data1, data2) == 0)
            {
                return true;
            }
            return false;
        }


    }
}
