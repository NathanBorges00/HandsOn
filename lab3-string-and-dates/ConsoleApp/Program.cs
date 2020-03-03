using System;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Problema 1:");
            String texto = "treinamento de dot net na cit";
            texto = texto.ToUpper();
            System.Console.WriteLine(texto);

            string novoTexto = texto.ToUpper().Replace("DOT NET", ".NET");
            System.Console.WriteLine(novoTexto);

            System.Console.WriteLine("\n\n");



            System.Console.WriteLine("Problema 2:");
            var sb = new StringBuilder("1,");

            for(int i = 2; i<=10; i++)
            {
                sb.Append(i);
                if(i != 10)
                {
                    sb.Append(",");
                }
            }
            System.Console.WriteLine(sb);

            System.Console.WriteLine("\n\n");



            System.Console.WriteLine("Problema 3:");
            System.Console.WriteLine("Digite no formato DD/MM/AA e o horario em HH:MM:SS:");
            var Data1 = DateTime.Parse(Console.ReadLine());

            var Calendario = Data1.ToString("dd/MM/yyyy HH:mm dddd, dd 'de' MMMM 'de' yyy");
            System.Console.WriteLine(Calendario);

            System.Console.WriteLine("\n\n");



            /*System.Console.WriteLine("Problema 4:");
            System.Console.WriteLine("Digite no formato DD/MM/AA e o horario em HH:MM:SS: ");
            var prob4 = DateTime.Parse(Console.ReadLine());

            var Calendario4 = prob4.ToString("dd/MM/aa ");*/
            Console.ReadKey();
        }
    }
}
