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



//Declaracion de los personajes
        string Bobeponga1 = @"
        
    | o  |    \_      \     |     -.   .-.
    |.-.  \     `--..-'   O |     `.`-' .'
  _.'  .' |     `-.-'      /-.__   ' .-'
.' `-.` '.|='=.='=.='=.='=|._/_ `-'.'
`-._  `.  |________/\_____|    `-.'
   .'   ).| '=' '='\/ '=' |
   `._.`  '---------------'
           //___\   //___\
             ||       ||
    LGB      ||_.-.   ||_.-.
            (_.--__) (_.--__)
        ";

        string Bobeponga2 = @"
        
      .--..--..--..--..--..--.
    .' \  (`._   (_)     _   \
  .'    |  '._)         (_)  |
  \ _.')\      .----..---.   /
  |(_.'  |    /    .-\-.  \  |
  \     0|    |   ( O| O) | o|
   |  _  |  .--.____.'._.-.  |
   \ (_) | o         -` .-`  |

        ";

        string Bobeponga3 = @"
        
    .--..--..--..--..--..--.
    .' \  (`._   (_)     _   \
  .'    |  '._)         (_)  |
  \ _.')\      .----..---.   /
  |(_.'  |    /    .-\-.  \  |
  \     0|    |   ( O| O) | o|
   |  _  |  .--.____.'._.-.  |
   \ (_) | o         -` .-`  |
    |    \   |`-._ _ _ _ _\ /
    \    |   |  `. |_||_|   |
    | o  |    \_      \     |     -.   .-.
    |.-.  \     `--..-'   O |     `.`-' .'
  _.'  .' |     `-.-'      /-.__   ' .-'
.' `-.` '.|='=.='=.='=.='=|._/_ `-'.'
`-._  `.  |________/\_____|    `-.'
   .'   ).| '=' '='\/ '=' |
   `._.`  '---------------'
           //___\   //___\
             ||       ||
    LGB      ||_.-.   ||_.-.
            (_.--__) (_.--__)

        ";

        string Correcamino1 = @"

           \_____ :-'~~~~~'-' ;
           /____;``-.         :
          <____(     `.       ;
            \___\     ;     .'
               /``--'~___.-'
              /\___/^/__/
             /   /' /`/'
             \  \   `\ \
              `\ \    \ \
                \ \    \ \
                 \ \    \ \
                  \ \    \ \     ______
                   \ \ ___\ \'~``______)>
              jgs   \ \___ _______ __)>
                _____\ \'~``______)>
              <(_______.._______)>

        ";

        string Correcamino2 = @"
        
                             __
                            /  \      __
.---.                  _   /   /   _.~  \
\    `.               / \ /   /.-~    __/
 `\    \              |  |   |/    .-~ __
   \    \             |  |   |   .'--~~  \
    \    \            |  |   `  ' _______/
     \    \           |  `        /
 .--. \    \          |    `     /
 \   `.\    \          \        /
  `\   \     \          `\     (
    \   \     \           > ,-.-.
     \   `.    \         /  |  \ \
      \    .    \       /___| O |O\     ,
   .-. \    ;    |    /`    `^-.\.-'`--'/
   \  `;         |   |                 /
    `\  \        |   `.     `--..____,'
      \  `.      |     `._     _.-'^
       \   .     /         `|`|`
     .-.\       /           | |
     \  `\     /            | |

        ";

        string Correcamino3 = @"
        
                                     __
                            /  \      __
.---.                  _   /   /   _.~  \
\    `.               / \ /   /.-~    __/
 `\    \              |  |   |/    .-~ __
   \    \             |  |   |   .'--~~  \
    \    \            |  |   `  ' _______/
     \    \           |  `        /
 .--. \    \          |    `     /
 \   `.\    \          \        /
  `\   \     \          `\     (
    \   \     \           > ,-.-.
     \   `.    \         /  |  \ \
      \    .    \       /___| O |O\     ,
   .-. \    ;    |    /`    `^-.\.-'`--'/
   \  `;         |   |                 /
    `\  \        |   `.     `--..____,'
      \  `.      |     `._     _.-'^
       \   .     /         `|`|`
     .-.\       /           | |
     \  `\     /            | |
      `\  `   |             | |
        \     |             | |
       .-.    |             | |
       \  `.   \            | |
        `\      \           | |
          \      \          | |
           \_____ :-'~~~~~'-' ;
           /____;``-.         :
          <____(     `.       ;
            \___\     ;     .'
               /``--'~___.-'
              /\___/^/__/
             /   /' /`/'
             \  \   `\ \
              `\ \    \ \
                \ \    \ \
                 \ \    \ \
                  \ \    \ \     ______
                   \ \ ___\ \'~``______)>
              jgs   \ \___ _______ __)>
                _____\ \'~``______)>
              <(_______.._______)>
        ";
        
        
        string oso1 = @"
             /'   _        _   `\
    /     0}      {0     \
   
 
 
     '._ \.' \__/ './ _.'
jgs  /  ``'._-''-_.'``  \
        ";

        string oso2 = @"
     .--.              .--.
   : (\ ''. _......_ .'' /) :
    '.    `        `    .'
     /'   _        _   `\
    /     0}      {0     \
   
 
 
     '._ \.' \__/ './ _.'
jgs  /  ``'._-''-_.'``  \
        ";
        

        string oso3 = @"
     .--.              .--.
   : (\ ''. _......_ .'' /) :
    '.    `        `    .'
     /'   _        _   `\
    /     0}      {0     \
   |       /      \       |
   |     /'        `\     |
    \   | .  .==.  . |   /
     '._ \.' \__/ './ _.'

jgs  /  ``'._-''-_.'``  \
        ";
        
        
        string calamardo1 = @"
             .'      .---.      '.
    /    .-----------.    \
   /        .-----.        \
   |       .-.   .-.       |
   |      /   \ /   \      |
    \    | .-. | .-. |    /
 
 
 
 
 
             _| |_
            /\( )/\
           /  ` '  \
          | |     | |
          '-'     '-'
          | |     | |
          | |     | |
          | |-----| |
       .`/  |     | |/`.
       |    |     |    |
       '._.'| .-. |'._.'
             \ | /
             | | |
             | | |
             | | |
            /| | |\
        ";


        string calamardo2 = @"
            .--'''''''''--.
     .'      .---.      '.
    /    .-----------.    \
   /        .-----.        \
   |       .-.   .-.       |
   |      /   \ /   \      |
    \    | .-. | .-. |    /
 
 
 
 
 
             _| |_
            /\( )/\
           /  ` '  \
          | |     | |
          '-'     '-'
          | |     | |
          | |     | |
          | |-----| |
       .`/  |     | |/`.
       |    |     |    |
       '._.'| .-. |'._.'
             \ | /
             | | |
             | | |
             | | |
            /| | |\
 
 
.
      /o`.-'  / \  `-.`o\
     /o  o\ .'   `. /o  o\
     `.___.'       `.___.'
        ";


        string calamardo3 = @"
            .--'''''''''--.
     .'      .---.      '.
    /    .-----------.    \
   /        .-----.        \
   |       .-.   .-.       |
   |      /   \ /   \      |
    \    | .-. | .-. |    /
     '-._| | | | | | |_.-'
         | '-' | '-' |
          \___/ \___/
       _.-'  /   \  `-._
     .' _.--|     |--._ '.
     ' _...-|     |-..._ '
            |     |
            '.___.'
              | |
             _| |_
            /\( )/\
           /  ` '  \
          | |     | |
          '-'     '-'
          | |     | |
          | |     | |
          | |-----| |
       .`/  |     | |/`.
       |    |     |    |
       '._.'| .-. |'._.'
             \ | /
             | | |
             | | |
             | | |
            /| | |\
          .'_| | |_`.
LGB       `. | | | .'
       .    /  |  \    .
      /o`.-'  / \  `-.`o\
     /o  o\ .'   `. /o  o\
     `.___.'       `.___.'
        ";



        //--------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------
        //Configuraciones iniciales
        
        Console.WriteLine("Bienvenido al juego de adivinanzas de logotipos");
        Console.WriteLine("Cada respuesta correcta vale 4 puntos en el primer intento, de lo contrario ganarás 2 puntos.");

        // Console.WriteLine("Ingrese el nombre Jugador 1");
        // string jugador1 = Console.ReadLine();
        Console.WriteLine("Presione cualquier boton para continuar");
        Console.WriteLine();
        Console.ReadKey();

        int puntos = 0;

        //---------------------------------------------------------------------------------------------------------------------
        //Crear aletoriedad
        
        Random rnd = new Random();
        int seleccion, x=0,a=0,b=0,d=0,e=0,c=0,f=0;

        while (x < 7)
        {

            seleccion = rnd.Next(1,7);

            while (seleccion == a || seleccion == b || seleccion == c || seleccion == d || seleccion == e || seleccion == f)
            {
            seleccion = rnd.Next(1,7);
            }        
        
        if(x == 0)
        {
            a = seleccion;
        }
        else if(x == 1)
        {
            b = seleccion;
        }
        else if(x == 2)
        {
            c = seleccion;
        }
        else if(x == 3)
        {
            d = seleccion;
        }
        else if(x == 4)
        {
            e = seleccion;
        }
        else if(x == 5)
        {
            f = seleccion;
        }

        // if(x == 1)
        // {
        //     b = seleccion;
        // }
        
        x += 1;


            //---------------------------------------------------------------------------------------------------------------
            //Inicio del juego

            switch (seleccion)
            {

                case 1:

                    Console.WriteLine("Adivina el logotipo:");
                    Console.WriteLine(playBoy1);
                    string respuesta = Console.ReadLine()!;

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
                        respuesta = Console.ReadLine()!;

                        if (respuesta == "Play boy")
                        {
                            puntos += 2;
                            Console.WriteLine("¡Respuesta correcta! Has ganado 2 puntos.");
                            Console.WriteLine(playBoy3);
                        }
                        else
                        {

                            Console.WriteLine("Respuesta incorrecta.");
                            Console.WriteLine(playBoy3);
                            Console.WriteLine("La respuesta correcta es 'Play Boy'");
                        }
                    }

                    Console.ReadKey();
                    break;


                case 2:

                    Console.WriteLine();
                    Console.WriteLine("Adivina el segundo logotipo:");
                    Console.WriteLine(jamesBond);
                    respuesta = Console.ReadLine()!;

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
                        respuesta = Console.ReadLine()!;

                        if (respuesta == "James Bond")
                        {
                            puntos += 2;
                            Console.WriteLine("¡Respuesta correcta! Has ganado 2 puntos.");
                            Console.WriteLine(jamesBond3);
                        }
                        else
                        {

                            Console.WriteLine("Respuesta incorrecta.");
                            Console.WriteLine(playBoy3);
                            Console.WriteLine("La respuesta correcta es 'James Bond'");
                        }
                    }

                    Console.ReadKey();
                    break;


                case 3:

                    Console.WriteLine();
                    Console.WriteLine("Adivina el personaje de caricatura:");
                    Console.WriteLine(calamardo1);
                    respuesta = Console.ReadLine()!;

                    if (respuesta == "Calamardo")
                    {
                        puntos += 4;
                        Console.WriteLine("¡Respuesta correcta! Has ganado 4 puntos.");
                        Console.WriteLine(calamardo3);
                    }
                    else
                    {
                        Console.WriteLine("Respuesta incorrecta. Inténtalo nuevamente.");
                        Console.WriteLine(calamardo2);
                        respuesta = Console.ReadLine()!;

                        if (respuesta == "Calamardo")
                        {
                            puntos += 2;
                            Console.WriteLine("¡Respuesta correcta! Has ganado 2 puntos.");
                            Console.WriteLine(calamardo3);
                        }
                        else
                        {

                            Console.WriteLine("Respuesta incorrecta.");
                            Console.WriteLine(calamardo3);
                            Console.WriteLine("La respuesta correcta es 'Calamardo'");
                        }
                    }

                    Console.ReadKey();
                    break;


                case 4:

                    Console.WriteLine();
                    Console.WriteLine("Adivina el animal:");
                    Console.WriteLine(oso1);
                    respuesta = Console.ReadLine()!;

                    if (respuesta == "Oso")
                    {
                        puntos += 4;
                        Console.WriteLine("¡Respuesta correcta! Has ganado 4 puntos.");
                        Console.WriteLine(oso3);
                    }
                    else
                    {
                        Console.WriteLine("Respuesta incorrecta. Inténtalo nuevamente.");
                        Console.WriteLine(oso2);
                        respuesta = Console.ReadLine()!;

                        if (respuesta == "Oso")
                        {
                            puntos += 2;
                            Console.WriteLine("¡Respuesta correcta! Has ganado 2 puntos.");
                            Console.WriteLine(oso3);
                        }
                        else
                        {

                            Console.WriteLine("Respuesta incorrecta.");
                            Console.WriteLine(oso3);
                            Console.WriteLine("La respuesta correcta es 'Oso'");
                        }

                    }
                    Console.ReadKey();
                    break;

                case 5:

                    Console.WriteLine();
                    Console.WriteLine("Adivina la personaje:");
                    Console.WriteLine();
                    respuesta = Console.ReadLine()!;

                    if (respuesta == "Correcaminos")
                    {
                        puntos += 4;
                        Console.WriteLine("¡Respuesta correcta! Has ganado 4 puntos.");
                        Console.WriteLine(Correcamino1);
                    }
                    else
                    {
                        Console.WriteLine("Respuesta incorrecta. Inténtalo nuevamente.");
                        Console.WriteLine(Correcamino2);
                        respuesta = Console.ReadLine()!;

                        if (respuesta == "Correcaminos")
                        {
                            puntos += 2;
                            Console.WriteLine("¡Respuesta correcta! Has ganado 2 puntos.");
                            Console.WriteLine(Correcamino3);
                        }
                        else
                        {

                            Console.WriteLine("Respuesta incorrecta.");
                            Console.WriteLine(Correcamino3);
                            Console.WriteLine("La respuesta correcta es 'Oso'");
                        }
                    }
                    Console.ReadKey();
                    break;

                case 6:

                    Console.WriteLine();
                    Console.WriteLine("Adivina el Personaje:");
                    Console.WriteLine(Bobeponga1);
                    respuesta = Console.ReadLine()!;

                    if (respuesta == "Bob esponja")
                    {
                        puntos += 4;
                        Console.WriteLine("¡Respuesta correcta! Has ganado 4 puntos.");
                        Console.WriteLine(Bobeponga1);
                    }
                    else
                    {
                        Console.WriteLine("Respuesta incorrecta. Inténtalo nuevamente.");
                        Console.WriteLine(Bobeponga2);
                        respuesta = Console.ReadLine()!;

                        if (respuesta == "Bob esponja")
                        {
                            puntos += 2;
                            Console.WriteLine("¡Respuesta correcta! Has ganado 2 puntos.");
                            Console.WriteLine(Bobeponga3);
                        }
                        else
                        {

                            Console.WriteLine("Respuesta incorrecta.");
                            Console.WriteLine(Bobeponga3);
                            Console.WriteLine("La respuesta correcta es 'Bob esponja");
                        }
                    }

                    Console.ReadKey();
                    break;



            }

        }

        Console.WriteLine();
        Console.WriteLine("Puntos totales: " + puntos);
        Console.WriteLine();
        Console.WriteLine("¡Gracias por jugar!");

    }
}
