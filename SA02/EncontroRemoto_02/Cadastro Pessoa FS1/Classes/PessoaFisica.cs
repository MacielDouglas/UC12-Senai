using Cadastro_Pessoa_FS1.Interfaces;

namespace Cadastro_Pessoa_FS1.Classes
{ //Classe base vem antes de interface
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        //Atributos pessoaFisica:
        public string ?cpf { get; set; }

        public DateTime ?date { get; set; }
        
        
        //Metodos pessoaFisica:
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }

        public override float PagarImposto(float rendimento) //override é pq ele é sob-escrito.
        { 
            throw new NotImplementedException();
        }
    }
}