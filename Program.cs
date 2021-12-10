using System;

namespace practica20del8
{
    class Program
    {
        private int quantityMovement;
        private int totalMovement;
        static void Main(string[] args)
        {
            string password = "21518";
            string youPassword = "50371";
            var Suitcase = new Program();
            Console.WriteLine("los movimientos minimos son " + Suitcase.openSuitcase(youPassword, password));
        }
        private int openSuitcase(string youPassword, string password){
            for(int digit = 0; digit < password.Length; digit++){
                if(password[digit] == youPassword[digit]){
                    Console.WriteLine("en el digito " + (digit + 1) + "el número es correcto");
                }
                else if(password[digit] >= youPassword[digit]){
                    quantityMovement = ((int)password[digit]) % ((int)youPassword[digit]);
                    Console.WriteLine("en el digito " + (digit + 1) + " tenes ir hacia adelante " + quantityMovement + " veces");
                    totalMovement += quantityMovement;
                }
                else if(password[digit] <= youPassword[digit]){
                    quantityMovement = ((int)youPassword[digit]) % ((int)password[digit]);
                    Console.WriteLine("en el digito " + (digit + 1) + " tenes ir hacia atras " + quantityMovement + " veces");
                    totalMovement += quantityMovement;
                }
            }
            return totalMovement;
        }
    }
}
