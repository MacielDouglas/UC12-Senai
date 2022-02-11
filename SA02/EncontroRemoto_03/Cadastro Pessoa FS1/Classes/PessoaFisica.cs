using Cadastro_Pessoa_FS1.Interfaces;

namespace Cadastro_Pessoa_FS1.Classes
{ //Classe base vem antes de interface
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        //Atributos pessoaFisica:
        public string ?cpf { get; set; }

        public string ?dataNascimento { get; set; }
        
        
        //Metodos pessoaFisica:
        public bool ValidarDataNascimento(DateTime dataNasc) //recebendo um DateTime
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }

            return false;
            
        }


        public bool ValidarDataNascimento(string dataNasc) //Recebendo uma string
        {
            DateTime dataConvertida;

            if (DateTime.TryParse (dataNasc, out dataConvertida)) // converter uma string em data
            {
                Console.WriteLine($"{dataConvertida}");
                

                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }

                return false;
                
            }

            return false;

        }

        public override float PagarImposto(float rendimento) //override é pq ele é sob-escrito.
        { 
            throw new NotImplementedException();
        }
    }
}