// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_FS1.Classes;
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
PessoaJuridica metodoPj = new PessoaJuridica();

PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "Nome Pj";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.razaoSocial = "Pessoa Juridica Comercial Ltda";
novaPj.rendimento = 100000.9f;

novaPj.endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ Válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}
");

// Console.WriteLine($"{metodoPj.ValidarCnpj("11.222.333/0000-09")}");
// Console.WriteLine($"{metodoPj.ValidarCnpj("11222333000109")}");




