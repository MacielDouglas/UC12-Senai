// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_FS1.Classes;

Console.WriteLine(@$"
=================================================
|       Bem vindo ao sistema de cadasto de      |
|           Pessoas Físicas e Juridícas         |
=================================================
");

BarraCarregamento("Carregando..", 500);

// Console.WriteLine($"Sem Cor!"); Para testar o Reset Color

string? opcao;
do
{
    Console.Clear();

    Console.WriteLine(@$"
=================================================
|         Escolha uma das opções abaixo         |
|-----------------------------------------------|
|              1 - Pessoa Física                |
|              2 - Pessa Jurídica               |
|                                               |
|              0 - Sair                         |
=================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica metodoPf = new PessoaFisica();

            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            novaPf.nome = "Douglas";
            novaPf.dataNascimento = "01/01/2000";
            novaPf.cpf = "123.456.789-00";
            novaPf.rendimento = 8990.21f;

            novoEnd.logradouro = "Avenida Brasil";
            novoEnd.numero = 2093;
            novoEnd.complemento = "casa 02";
            novoEnd.endComercial = true;

            novaPf.endereco = novoEnd;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento) ? "Sim" : "Não")}
Taxa de imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")}
");
// ToString converte para padrao moeda e corta as casas decimais
// ?:  if else

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            break;

        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome Pj";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaoSocial = "Pessoa Juridica Comercial Ltda";
            novaPj.rendimento = 100000.9f;

            novaPj.endereco = novoEndPj;
            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ Válido: {(metodoPj.ValidarCnpj(novaPj.cnpj) ? "Sim" : "Não")}
Taxa de imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
");
            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            break;

        case "0":
            Console.Clear();
            BarraCarregamento("Finalizando..", 300);

            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
            Thread.Sleep(2000);
            break;
    }

} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.ForegroundColor = ConsoleColor.Black;

    Console.Write($"{texto}");

    for (var contador = 0; contador < 10; contador++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);
    }

    Console.ResetColor();
}



/*
PessoaFisica metodoPf = new PessoaFisica();

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

novaPf.nome = "Douglas";
novaPf.dataNascimento = "01/01/2000";
novaPf.cpf = "123.456.789-00";
novaPf.rendimento = 8990.21f;

novoEnd.logradouro = "Avenida Brasil";
novoEnd.numero = 2093;
novoEnd.complemento = "casa 02";
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

// bool dataValida = metodoPf.ValidarDataNascimento(novaPf.dataNascimento);
// Console.WriteLine($"Nome: {novaPf.nome}");
// Console.WriteLine($"Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");


// bool dataValida = metodoPf.ValidarDataNascimento(novaPf.dataNascimento);

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
");
*/

//Metodo validar cnpj. obs (Faz validação em dois formatos)
// PessoaJuridica metodoPj = new PessoaJuridica();

// PessoaJuridica novaPj = new PessoaJuridica();
// Endereco novoEndPj = new Endereco();

// novaPj.nome = "Nome Pj";
// novaPj.cnpj = "00.000.000/0001-00";
// novaPj.razaoSocial = "Pessoa Juridica Comercial Ltda";
// novaPj.rendimento = 100000.9f;

// novaPj.endereco = novoEndPj;

// Console.WriteLine(@$"
// Nome: {novaPj.nome}
// Razão Social: {novaPj.razaoSocial}
// CNPJ: {novaPj.cnpj}
// CNPJ Válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}
// ");

// Console.WriteLine($"{metodoPj.ValidarCnpj("11.222.333/0000-09")}");
// Console.WriteLine($"{metodoPj.ValidarCnpj("11222333000109")}");




