using System;
using System.IO;

class Test
{
    public static void Main()
    {
        //string path = @"C:\Users\nborges\Desktop\Hands on\Exceções\excecoes\MyTest.txt";
        var drive = "C:";
        var pasta = "Users";
        var pasta2 = "nborges";
        var pasta3 = "Desktop";
        var pasta4 = "Hands on";
        var pasta5 = "Exceções";
        var pasta6 = "excecoes";
        var file = "MyTest.txt";
        var path = Path.Combine(drive, pasta, pasta2, pasta3, pasta4, pasta5, pasta6, file);

        //ler todo o conteudo do arquivo de uma vez so
        // string text = System.IO.File.ReadAllText(path);
        // System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

        //ler o conteudo linha por linha
        //string [] linhas = System.IO.File.ReadAllLines(@"C:\Users\nborges\Desktop\Hands on\Exceções\excecoes\MyTest.txt");

        //ler linha a linha escrevendo no console
        // foreach ( string line in linhas)
        // {
        //     System.Console.WriteLine("\t" + line);
        // }

        // Verificando se o arquivo existe.
        if (!File.Exists(path))
        {
            // Criando um arquivo para escrita.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("bananas");
                sw.WriteLine("de");
                sw.WriteLine("pijamas");
            }

        }

        //substitui as linhas do arquivo por novas
        // string[] novoTexto = { "macacos", "me", "mordam" };
        // System.IO.File.WriteAllLines(path, novoTexto);

        //adiciona uma linha no final
        // using (System.IO.StreamWriter arquivo = new System.IO.StreamWriter(path, true))
        // {
        //     arquivo.WriteLine("eita preula");
        // }

        string[] novaLinha = System.IO.File.ReadAllLines(path);
        foreach (string line in novaLinha)
        {
            System.Console.WriteLine("\t" + line);
        }

        // Abrindo o arquivo para leitura.
        using (StreamReader sr = File.OpenText(path))
        {
            string s;

            // Lendo linha a linha do arquivo, até o seu final.
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }

        Console.ReadKey();
    }
}