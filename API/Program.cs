using System;
using xtpo;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            Batima batima = new Batima();
            Miranha miranha = new Miranha();
            Heroi h = new Heroi();

            batima.Poder = "dinheiro";
            batima.Qg = "batima-caverna";
            batima.TrilhaSonora = "nananananam";
            batima.Uniforme = "morcegao";

            miranha.poder = "habilidades de uma aranha comum";
            miranha.qg = "casa da tia May";
            miranha.trilhaSonora = "spider-man, spider-man";
            miranha.uniforme = "crochê da tia May";

            System.Console.WriteLine(batima.Escrever());
            System.Console.WriteLine(miranha.Escrever());
        }
    }
}
