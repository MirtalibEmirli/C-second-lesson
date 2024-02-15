
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
                operat( select);

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



void operat( int secim)
{
    Console.ForegroundColor = ConsoleColor.Cyan;

    Console.Write("Enter first number ^> ");
   string num1 =(Console.ReadLine());
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;


    Console.ForegroundColor = ConsoleColor.DarkCyan;

    Console.Write("Enter second number ^> ");
    string num2 = (Console.ReadLine());
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;

    int num11;
    int num22;
    bool n1 = int.TryParse(num1, out num11);
    bool n2 = int.TryParse(num2, out num22);

    if (n1 && n2)
    {

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        switch (secim)
        {

            case 1:
                Console.WriteLine("Result => " + (num11 + num22));
                break;
            case 2:
                Console.WriteLine("Result => " + (num11 - num22));

                break;
            case 3:
                Console.WriteLine("Result => " + (num11 * num22));

                break;
            case 4:
                Console.WriteLine("Result => " + (num11 / num22));

                break;


            default:
                break;
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Wrong symbol :(");
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
var compile time isleyr
buna gore define edmek olmur
ve biz var ile bisey yaratdqda onun meselen string dise methoddlarin 
isdifade ede biirik
var strongly type ni destekleyir yeni bu o demekdir ki biz 
evvelde var da int saxlamsqsa sonadek int olur

amma dinamikde ise string idise evvel indi int de saxla bilir
dynamic run time isleyr
dynamicde ise run time olduqu ucun bunu ede bimmirik

DAta typler 2 yere bonr 
value type
reference type 
GetHashCode deyerin adressin verir


ref => datanin orginalnifunksiyay gondermek ucundur , burda deyerei deyise de bilerik deyismeyede 
out => data define olsa da isleyir cunki gonderiliydiyi yerde mutleq assign edmeliyik
ve orginala gore isleyir yeni colden gelen bir deyeri doldrub deysir
int a;
changeout(out a);
Console.WriteLine(a);
void changeout(out int num)
{
    num = 13;

}

in=> bu keyword bize bir datani yalniz readonly olaraq funksiyay gondermek ucundr
yalniz isdifade edmek olar deyismek olmazhhhhh
clasin obyektn deyse bilmerem amma onun fieldn deyse bilerik



floatdan int e down casting edsek data itkisi olacaq amma 
intden double up casing edsek data itkisi olmayacaq
up casting balacadan boyuye
down casting kicik hecmli den boyuk hecmlihe
default olaraq biz int a = 14.45 ; deye bilmerik yeni down casting default yoxdu

string b = "asd";
int ass = int.Parse(b);
Console.WriteLine(ass);
belede typecast edmek olur 
amma gorunduyu kimi ugurlu olmayacaqdir
herfi reqeme cevrmek olmr
ve error atr


yalniz int a = (int )15.36;
ve ya Convert.to methodu ile
 ama biz up casting ede  bilirik qeyri askar meselen double a = 12;
 int den doubleye

 
 */
