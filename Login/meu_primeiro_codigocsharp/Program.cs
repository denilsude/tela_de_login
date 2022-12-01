using System;
using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
        string UsuarioSistema = "usuario";
        string SenhaSistema = "123";

        Console.WriteLine("Usuario: " );
        string UsuarioInserido = Console.ReadLine();
        Console.WriteLine();

        Console.Write("senha: ");
        String SenhaInserida = Console.ReadLine();
        Console.WriteLine();

        if (UsuarioInserido != UsuarioSistema || SenhaInserida != SenhaSistema)
            Console.WriteLine("O usuario ou sua  senha esta incorreta");
        else
        Console.WriteLine("Bem vindo ao sistema");












              Console.ReadKey();

    }
    }

