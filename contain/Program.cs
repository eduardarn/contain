using System;

namespace contain
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "vamos testar o codigo";
            string ndois = "testar";
            string ntres = "codigo";

            Console.WriteLine("A frase não estará correta, pois falta a palavra testar :{0} ", num.Contains(ndois));

            Console.WriteLine("A frase estará correta, pois há a palavra codigo :{0} ", num.Contains(ntres));
        }
    }
}
