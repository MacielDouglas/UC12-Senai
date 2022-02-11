// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_FS1.Classes;

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





