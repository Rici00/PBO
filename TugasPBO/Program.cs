using System;

namespace TugasPBO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Rekomendasi Gitar");
            Data data = new Data();
            specGitar cust = new specGitar(brand, model, wood);

            List<Gitar> guitar = data.search(cust);
            if (guitar.Count > 0)
            {
                specGitar spec = guitar.spec;
                string berhasil += "kita mendapat" spec.brand + spec.model + spec.wood";
                Console.WriteLine("Pilihan gitar:");
                Console.WriteLine(berhasil);
                Console.ReadKey();         
            }
            else
            {
                string gagal = "tidak menemukan gitar yang dicari"
                Console.WriteLine(gagal);
                Console.ReadKey();
            }

            



        }
    }
}
