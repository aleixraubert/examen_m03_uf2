namespace MenuProgram
{
    public static class MenuProg
    {
        public static bool OptionA()
        {
            const string Msg_Input = "Introdueix un nombre natural, per a saber si és senar o no:";
            const string Msg_Error = "El nombre ha de ser natural, torna a provar:";
        
            Console.WriteLine(Msg_Input);
        
            int num = Convert.ToInt32(Console.ReadLine());
        
            while (num < 0)
            {
                Console.WriteLine(Msg_Error);
                num = Convert.ToInt32(Console.ReadLine());
            }
        
            return num % 2 != 0;
        }

        public static int OptionB()
        {
            const string Msg_Input = "Introdueix la base i la potencia, per a calcularla:";
            const string Msg_Error = "La base i la potencia han de ser naturals, torna a provar:";
        
            Console.WriteLine(Msg_Input);
        
            int baseNum = Convert.ToInt32(Console.ReadLine());
        
            while (baseNum < 0)
            {
                Console.WriteLine(Msg_Error);
                baseNum = Convert.ToInt32(Console.ReadLine());
            }
        
            int power = Convert.ToInt32(Console.ReadLine());
        
            while (power < 0)
            {
                Console.WriteLine(Msg_Error);
                power = Convert.ToInt32(Console.ReadLine());
            }
        
            int result = 1;
        
            for(int i=0; i < power; i++)
            {
                result *= baseNum;
            }
        
            return result;
        }

        public static int OptionC()
        {
        }

        public static void OptionD()
        {
        }
    }
}
