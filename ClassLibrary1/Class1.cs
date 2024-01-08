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
            
        }

        public static int OptionC()
        {
        }

        public static void OptionD()
        {
        }
    }
}
