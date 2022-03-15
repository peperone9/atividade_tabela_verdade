using System;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            //=============== OBJETIVO -> EU NÃO QUERO FICAR SOZINHO NA FESTA ================
            bool paula;
            bool quesia;
            //EU SÓ VOU A FESTA SE *PELO MENOS UMA* DAS DUAS VIR A FESTA  || (OU)

                            //1ª situação: AS DUAS VEIO \0/
            paula = true;
            quesia = true;
            if(paula == true || quesia == true);
                Console.WriteLine("Vou pra festa com AS DUAS =D");
                            //2ª situação: PAULA VEIO, QUESIA ME DEU UM BOLO (TE ODEIO QUESIA)
            paula = true;
            quesia = false;
            if(paula == true || quesia == false)
                Console.WriteLine("PAU NO CU DA QUESIA, vou com a paulinha <3");
                           //3ª situação: PAULA NÃO VEIO (MAGOOU MEU CORAÇÃO), Quesia veio, vou com ela
            paula = false;
            quesia = true;
            if(paula == false || quesia == true)
                Console.WriteLine("Quesia, NINGUÉM É PERFEITO, EU TAMBÉM ESCOLHI A PAULINHA, MAS AGORA EU TO COM VOCE");
                           //3ª situação: Paula não veio .. quesia não veio..
            paula = false;
            quesia = false;
            if(paula == false || quesia == false)
                Console.WriteLine("DEPRESSÃO E SUICIDIO");
            //EU SÓ VOU A FESTA SE *AS DUAS* VIREM && (E)




        }
    }
}
