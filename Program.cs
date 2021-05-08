using System;

namespace Exerc_cio_AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Emprestimo duplo,  parcelas , renda , porcentagem , valorParcela; 

            
            Console . WriteLine ("Analisar crédito" );
            
            Console . Write ( " Digite o valor do emprestimo ... " );
            Emprestimo = Convert.ToDouble (Console.ReadLine());

            Console . Write ( " Digite a quantidade de parcelas ... " );
            parcelas  =  Convert.ToDouble ( Console . ReadLine ());

            Console . Write ( " Digite a sua Renda ... " );
            renda  =  Convert.ToDouble ( Console . ReadLine ());

            porcentagem  =  renda  /  100  *  30;

            valorParcela  = ( Emprestimo /  parcelas);

            if ( porcentagem  >=  valorParcela )
            {
                Console . WriteLine ( " \n Emprestimo Autorizado " );
            }
            else  
            {
                 Console . WriteLine ($" \n Emprestimo Não Autorizado" );
            }
    
        } 

    }
}
        
    

