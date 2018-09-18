using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LinqEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros={1,5,4,7,6,3,5,9,8,11};
            IEnumerable<int> pares = numeros.Where(n => n % 2 == 0);
            foreach(int num in pares)
                Console.WriteLine(num);
            Console.WriteLine("-------");
            string[] postres={"pay de manzana","pastel de chocolate","manzana caramelizada","fresas con crema"};
            IEnumerable<string> encontrados = postres.Where(p => p.Contains("manzana"));
            foreach(string postre in encontrados)
                Console.WriteLine(postre);
            Console.WriteLine("------");
        }
    }
}
