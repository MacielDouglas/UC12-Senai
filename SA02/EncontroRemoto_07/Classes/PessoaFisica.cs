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

                if (anos >= 18 && anos < 125)
                {
                    return true;
                }

                return false;
                
            }

            return false;

        }

        public override float PagarImposto(float rendimento) //override é pq ele é sob-escrito.
        { 
            // throw new NotImplementedException(); comando para não dar erro, pq ainda não tem método criado
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                return (rendimento / 100) *2;
            }
            else if (rendimento > 3500 && rendimento < 6000)
            {
                return(rendimento / 100) * 3.5f;
            }else
            {
                return (rendimento / 100) * 5;
            }

        }
    }
}