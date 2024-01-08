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
            const string Msg_Welcome = "Introdueix el rang de valors aleatoris, per a retornar-ne un:";
        
            Console.WriteLine(Msg_Welcome);
        
            int min = Convert.ToInt32(Console.ReadLine());
        
            int max = Convert.ToInt32(Console.ReadLine());
        
            Random rnd = new Random();
        
            return rnd.Next(min, max);
        }

        public static void OptionD()
        {
            const string Msg_Welcome = "Introdueix un text, per a comptar el nombre de vocals o consonants:";
            const string Msg_Error = "El text no pot estar buit, torna a provar:";
            const string Msg_Vowels = "Vocals: ";
            const string Msg_Consonants = "Consonants: ";
            const string Msg_Ask = "Que vols saber el num de consonants (c) o vocals (v)?";
        
            char option;
        
            Console.WriteLine(Msg_Welcome);
        
            string text = Console.ReadLine();
        
            while (text.Length == 0)
            {
                Console.WriteLine(Msg_Error);
                text = Console.ReadLine();
            }
        
            int vowels = 0;
            int consonants = 0;
        
            foreach (char c in text)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    vowels++;
                }
                else if(c != ' ')
                {
                    consonants++;
                }
            }
        
            Console.WriteLine(Msg_Ask);
        
            option = Convert.ToChar(Console.ReadLine());
        
            switch (option)
            {
                case 'c':
                    Console.WriteLine(Msg_Consonants + consonants);
                    break;
        
                case 'v':
                    Console.WriteLine(Msg_Vowels + vowels);
                    break;
            }
        }
    }
}
