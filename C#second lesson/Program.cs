
Console.WriteLine();
int select = 1;

do
{

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine(@"        
                               ==================
                                 ^^Calculator^^     ");
    Console.ForegroundColor = ConsoleColor.White;










    Console.WriteLine();

    switch (select)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[1] => cem ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[2] => ferq ");
            Console.WriteLine("[3] => hasil ");
            Console.WriteLine("[4] => bolme ");
            Console.WriteLine("[5] => exit ");


            break;




        case 2:


            Console.WriteLine("[1] => cem ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[2] => ferq ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("[3] => hasil ");
            Console.WriteLine("[4] => bolme ");
            Console.WriteLine("[5] => exit ");

            break;
        case 3:

            Console.WriteLine("[1] => cem ");
            Console.WriteLine("[2] => ferq ");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("[3] => hasil ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("[4] => bolme ");
            Console.WriteLine("[5] => exit ");


            break;
        case 4:
            Console.WriteLine("[1] => cem ");
            Console.WriteLine("[2] => ferq ");
            Console.WriteLine("[3] => hasil ");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("[4] => bolme ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("[5] => exit ");
            break;



        case 5:
            Console.WriteLine("[1] => cem ");
            Console.WriteLine("[2] => ferq ");
            Console.WriteLine("[3] => hasil ");

            Console.WriteLine("[4] => bolme ");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("[5] => exit ");
            Console.ForegroundColor = ConsoleColor.White;

            break;



        default:
            break;
    }

    ConsoleKeyInfo info = Console.ReadKey(true);

    switch (info.Key)
    {

        case ConsoleKey.UpArrow:
            if (select == 1)
                select = 5;
            else
                select--;

            break;




        case ConsoleKey.DownArrow:
            if (select == 5)
                select = 1;
            else
                select++;
            break;






        default:
            break;
    }






    if (info.Key == ConsoleKey.Enter)
    {

        switch (select)
        {

            case 1:
                operat(1);

                stops();

                break;

            case 2:

                operat(2);

                stops();

                break;

            case 3:
                operat(3);

                stops();

                break;



            case 4:
                operat(4);

                stops();

                break;

            case 5:
                exitingg();

                return;

            default:

                break;
        }


    }

}

while (true);





void exitingg()
{

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Goodbye");
    Thread.Sleep(300);
    Console.WriteLine("."); Thread.Sleep(300);
    Console.WriteLine("."); Thread.Sleep(300);
    Console.WriteLine("."); Thread.Sleep(300);
    Console.WriteLine(".");

    Console.ForegroundColor = ConsoleColor.White;

}



void operat(int secim)
{
    Console.ForegroundColor = ConsoleColor.Cyan;

    Console.Write("Enter first number ^> ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;


    Console.ForegroundColor = ConsoleColor.DarkCyan;

    Console.Write("Enter second number ^> ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;



    Console.ForegroundColor = ConsoleColor.DarkGreen;
    switch (secim)
    {

        case 1:
            Console.WriteLine("Result => " + (num1 + num2));
            break;
        case 2:
            Console.WriteLine("Result => " + (num1 - num2));

            break;
        case 3:
            Console.WriteLine("Result => " + (num1 * num2));

            break;
        case 4:
            Console.WriteLine("Result => " + (num1 / num2));

            break;


        default:
            break;
    }
    Console.ForegroundColor = ConsoleColor.White;

}
void stops()
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;


    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("Press ESc for return ");

    Console.ForegroundColor = ConsoleColor.White;

    ConsoleKeyInfo exit4 = Console.ReadKey();

    if (exit4.Key == ConsoleKey.Escape)
    {
        Console.WriteLine("f"); Thread.Sleep(100);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("L"); Thread.Sleep(150);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("O"); Thread.Sleep(120);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("A"); Thread.Sleep(130);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("D"); Thread.Sleep(170);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("I"); Thread.Sleep(160);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("N"); Thread.Sleep(180);

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("G"); Thread.Sleep(200);
    }
}




/*QEYDLER  */

/*int sym;
sym = Console.Read(); //konsoldan oxumaq yalnz ilk simvolu oxuya bilir
Console.WriteLine(sym);// ve yalnz daxil edilen simvolun ascii qarslqn verir
*/
//amma bele edsek
/*sym = Console.Read();
Console.WriteLine(sym); */
//ikisin ve ya tekrarlayaraqbir necesin oxuya blr


/*
ConsoleKeyInfo infos = Console.ReadKey(true); //true olanda aftomatik gostermir hansi na basdn
Console.WriteLine();

Console.WriteLine(infos.Key); //basdqm duyme

Console.WriteLine(infos.KeyChar); //simvol daxil ediymiz*/


/*Console.ForegroundColor = ConsoleColor.Magenta;//bu ise yazinin rengin deysr
//yeni oznden sora gelenler artq o rengde olr

Console.WriteLine(@"        
                                ============
                                 Calculator     ");
Console.ForegroundColor = ConsoleColor.White;

Console.BackgroundColor = ConsoleColor.Red;//bu consolun rengin deysr*/




//Interpolation

/*Console.ForegroundColor = ConsoleColor.Green;
var name = "Miri";
Console.WriteLine($"Birincisi salam {"Salam" + 5} ikincisi M?en {name}"); 
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();*/

/*
 Consolda yazdigmz ve consoldan alnan her sey stringdir
Butun data tpler in en esasi object classi dir butun type lar ondan torenib
Ve object classindan diger butun field ler Tostring methodu kecib buttun her sey stringe cevrle blir

 Console.BackgroundColor = ConsoleColor.Red; bu consolun rengin deysr

 Console.ForegroundColor = ConsoleColor.Magenta; //bu ise yazinin rengin deysr
yeni oznden sora gelenler artq o rengde olr

Console.Title = "Salam"; // Consolun adini deysmek
//lakin biz bunu gormrk cunki cox suretle isdeyb baglanr consoler
//but We are workingin developer mood up to Visual  Studio give us own console for seeing reuslts
If you want to see Title's change you must use Thread.Sleep
in this method 1000 msecond is 1 second ^^
Thread.Sleep(5000);    //bu ise bize Sleep funksiyasn gorur



 Verbatim => multiline strig @"" isarei ie yazlr
 
 HEmcinin $@"" da ederek formatdan isdifade edmek olar


switch case de while ni biz return ile durdurq


 */