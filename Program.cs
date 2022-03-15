using System;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            //=============== OBJETIVO -> EU NÃO QUERO FICAR SOZINHO NA FESTA ================
            

            // -------> true -> veio, false -> não veio 

            //EU SÓ VOU A FESTA SE *PELO MENOS UMA* DAS DUAS VIR A FESTA  || (OU)

                            //1ª situação: AS DUAS VEIO \0/
            /*p = true; 
            q = true;
            if(p == true || q == true);
                Console.WriteLine("Vou pra festa com Paula e Quesia");
                            //2ª situação: PAULA VEIO, Quesia não veio
            p = true;
            q = false;
            if(p == true || q == false)
                Console.WriteLine("Vou pra festa com Paula <3");
                           //3ª situação: PAULA NÃO VEIO, Quesia veio
            p = false;
            q = true;
            if(p == false || q == true)
                Console.WriteLine("Vou pra festa com quesia");
                           //3ª situação: Paula não veio .. quesia não veio..
            p = false;
            q = false;
            if(p == false || q == false)
                Console.WriteLine("Não vou a festa");*/
                
            //EU SÓ VOU A FESTA SE *AS DUAS* VIREM && (E)

             // -------> true -> veio, false -> não veio 

            bool p = true; //paula
            bool q = false; //quesia
            bool veio = true;

            if(p == veio &&q == veio)
                Console.WriteLine("Eu vou pra festa");
            else
                Console.WriteLine("Eu não vou"); 
    
        }
    }
}
