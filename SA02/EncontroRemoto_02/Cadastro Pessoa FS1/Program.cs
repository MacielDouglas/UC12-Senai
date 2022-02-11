// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_FS1.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Douglas";

Console.WriteLine("Nome: " + novaPf.nome);

Console.WriteLine($"Nome: {novaPf.nome}");
