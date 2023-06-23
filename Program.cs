using System;

class Program
{
    static void Main()
    {
        string playBoy1 = @"
            O O
           dO Ob
          dOO OOO
         dOOO OOOb
        dOOOO OOOOb
        OOOOO OOOOO
        OOOOO OOOOO
        OOOOO OOOOO
        YOOOO OOOOO
         YOOO OOOP
   
 oOOOb dOOOOOOOOOOO
OOOOOOOOOOOOOOOOOOO




  %%%%%%%%%%%%%%
 %%%%%%OOOjgsOOO";


        string playBoy2 = @"
            O O
           dO Ob
          dOO OOO
         dOOO OOOb
        dOOOO OOOOb
        OOOOO OOOOO
        OOOOO OOOOO
        OOOOO OOOOO
        YOOOO OOOOO
         YOOO OOOP
    oOOOOOOOOOOOOb
  oOOOOOOOOOOOOOOOb
 oOOOb dOOOOOOOOOOO
OOOOOOOOOOOOOOOOOOO




  %%%%%%%%%%%%%%
 %%%%%%OOOjgsOOO";



        string playBoy3 = @"
            O O
           dO Ob
          dOO OOO
         dOOO OOOb
        dOOOO OOOOb
        OOOOO OOOOO
        OOOOO OOOOO
        OOOOO OOOOO
        YOOOO OOOOO
         YOOO OOOP
    oOOOOOOOOOOOOb
  oOOOOOOOOOOOOOOOb
 oOOOb dOOOOOOOOOOO
OOOOOOOOOOOOOOOOOOO
OOOOOOOOOOOOOOOOOOP
OOOOOOOOOOOOOOOOOP
 YOOOOOOOOOOOOOOP
   YOOOOOOOOOOOP
  %%%%%%%%%%%%%%
 %%%%%%OOOjgsOOO";


        string jamesBond = @"     
    000000           000000       7777777777777777/========___________
   00000000         00000000      7777^^^^^^^7777/ || ||   ___________
  000    000       000    000     777       7777/=========//

0000      0000   0000      0000           7777//   \\   //
0000      0000   0000      0000          7777//========//



   00000000         00000000       7777777
     0000             0000        777777777
        ";
        
        
        
        string jamesBond2 = @"     
    000000           000000       7777777777777777/========___________
   00000000         00000000      7777^^^^^^^7777/ || ||   ___________
  000    000       000    000     777       7777/=========//
 000      000     000      000             7777// ((     //
0000      0000   0000      0000           7777//   \\   //
0000      0000   0000      0000          7777//========//



   00000000         00000000       7777777
     0000             0000        777777777
        ";
        
        
        
        string jamesBond3 = @"     
    000000           000000       7777777777777777/========___________
   00000000         00000000      7777^^^^^^^7777/ || ||   ___________
  000    000       000    000     777       7777/=========//
 000      000     000      000             7777// ((     //
0000      0000   0000      0000           7777//   \\   //
0000      0000   0000      0000          7777//========//
0000      0000   0000      0000         7777
0000      0000   0000      0000        7777
 000      000     000      000        7777
  000    000       000    000       77777
   00000000         00000000       7777777
     0000             0000        777777777
        ";
        
        Console.WriteLine("Bienvenido al juego de adivinanzas de logotipos");
        Console.WriteLine("Cada respuesta correcta vale 4 puntos en el primer intento, de lo contrario ganarás 2 puntos.");
        Console.WriteLine();
        
        int puntos = 0;

        Console.WriteLine("Adivina el primer logotipo:");
        Console.WriteLine(playBoy1);
        string respuesta = Console.ReadLine();

        if (respuesta == "Play boy")
        {
            puntos += 4;
            Console.WriteLine("¡Respuesta correcta! Has ganado 4 puntos.");
            Console.WriteLine(playBoy3);
        }
        else
        {
            Console.WriteLine("Respuesta incorrecta. Inténtalo nuevamente.");
            Console.WriteLine(playBoy2);
            respuesta = Console.ReadLine();

            if (respuesta == "Play boy")
            {
                puntos += 2;
                Console.WriteLine("¡Respuesta correcta! Has ganado 2 puntos.");
                Console.WriteLine(playBoy3);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Adivina el segundo logotipo:");
        Console.WriteLine(jamesBond);
        respuesta = Console.ReadLine();

        if (respuesta == "James Bond")
        {
            puntos += 4;
            Console.WriteLine("¡Respuesta correcta! Has ganado 4 puntos.");
            Console.WriteLine(jamesBond3);
        }
        else
        {
            Console.WriteLine("Respuesta incorrecta. Inténtalo nuevamente.");
            Console.WriteLine(jamesBond2);
            respuesta = Console.ReadLine();

            if (respuesta == "James Bond")
            {
                puntos += 2;
                Console.WriteLine("¡Respuesta correcta! Has ganado 2 puntos.");
                Console.WriteLine(jamesBond3);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Puntos totales: " + puntos);
        Console.WriteLine();
        Console.WriteLine("¡Gracias por jugar!");

    }
}




