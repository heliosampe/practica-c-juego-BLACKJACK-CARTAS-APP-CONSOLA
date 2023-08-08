// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


////PROGRAMA QPARA CALCULAR EL ÁREA DE UN RECTÁNGULO.

//double ladoA;
//double ladoB;
//double resultado;

//Console.WriteLine("Calcula el área de un rectángulo");
//Console.WriteLine("Ingrese el valor del lado A:");
//ladoA = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Ingrese el valor del lado B:");
//ladoB = Convert.ToDouble(Console.ReadLine());


//resultado = ladoA * ladoB;
//Console.WriteLine( "EL AREA DEL RECTANGULO ES: " + resultado);

//----------------------------------------------------------------------------------

//BlackJack, juntar 21 puntos solicitando cartas, en caso de pasarte de 21 pierdes
//en caso de tener menos de 21 y tener mayor puntos que el dealer ganas
//

string message = "";
string switchControl = "menu";
int num = 0;
string controlOtraCarta ="";
System.Random random = new System.Random();

while (true){

int totalJugador = 0;
int totalDealer = 0;

switch (switchControl)
{

    case "menu":
        Console.WriteLine("welcome al  c a s i n o ");
        Console.WriteLine("Escriba 21 para jugar al 21 ");
        switchControl = Console.ReadLine();
        break;

case "21":
do
    {
                
        num = random.Next(1, 12);
        totalJugador = totalJugador + num;
        Console.WriteLine("toma tu carta, jugador");
        Console.WriteLine($"TE SALIO EL NUMERO: {num}");
        Console.WriteLine(totalJugador);
        Console.WriteLine("¿Deseas otra carta?");
        controlOtraCarta = Console.ReadLine();  

    } while (controlOtraCarta == "si" || controlOtraCarta == "SI" ||
    controlOtraCarta == "YES" || controlOtraCarta == "yes");

    totalDealer = random.Next(12, 23);
    Console.WriteLine($"EL DEALER TIENE {totalDealer}");

    if (totalJugador > totalDealer && totalJugador < 22)
    {
        message = "venciste al dealer, felicidades";
        switchControl = "menu";
    }
    else if (totalJugador >= 22)
    {
        message = "PERDISTE VS EL DEALER, TE PASASTE DE 21";
        switchControl = "menu";
    }
    else if (totalJugador <=totalDealer)
    {
        message = "PERDISTE VS EL DEALER, LOSIENTO";
        switchControl = "menu";
    }

    else
    {
                message = "condicion no valida";
    }

        Console.WriteLine(message);
        break;

        default:
        Console.WriteLine("valor ingresado no valido ");
        switchControl = "menu";
        break;
}
}