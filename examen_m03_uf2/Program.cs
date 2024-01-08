using System;
using MenuProgram;

namespace prog
{
    class Menu
    {
        public static void Main()
        {
            const string Msg_Welcome = "Que vols fer?\r\na. Validar si un nombre és senar\r\nb. Calcular la potència d'un nombre\r\nc. Retornar un valor aleatori\r\nd. Comptar el nombre de vocals o consonants en un text\r\ne. Sortir";
            const string Msg_Final = "Adeu!";
            const string Msg_Error = "Opció no vàlida";

            Console.WriteLine(Msg_Welcome);

            char option = Convert.ToChar(Console.ReadLine());

            switch(option)
            {
                case 'a':
                    Console.WriteLine(MenuProg.OptionA() ? "És senar" : "No és senar");
                    break;

                case 'b':
                    Console.WriteLine(MenuProg.OptionB());
                    break;

                case 'c':
                    Console.WriteLine(MenuProg.OptionC());
                    break;

                case 'd':
                    MenuProg.OptionD();
                    break;

                case 'e':
                    Console.WriteLine(Msg_Final);
                    break;

                default:
                    Console.WriteLine(Msg_Error);
                    break;
            }
        }


        
    }
}