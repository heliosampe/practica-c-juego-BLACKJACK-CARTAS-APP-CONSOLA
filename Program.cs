
//----------------------------------------------------------------------------------

//BlackJack, juntar 21 puntos solicitando cartas, en caso de pasarte de 21 pierdes
//en caso de tener menos de 21 y tener mayor puntos que el dealer ganas
//\\\\\\\\\\\\\\\\\  crtl + k + d indenta el codigo 

// version 2 IMPLEMENTAR LA FUNCION DE APUESTA EN LA CUAL 
int totalJugador = 0;
int totalDealer = 0;
string message = "";
string switchControl = "menu";
int num = 0;
string controlOtraCarta = "";
System.Random random = new System.Random();
int platziCoins = 0;
int apuesta = 0;
bool victoria = true;

while (true) {

    Console.WriteLine("Welcome al P l a t z i n o");
    Console.WriteLine("¿Cuántos PlatziCoins deseas? \n" +
                       "Ingresa un número entero \n" +
                       "Recuerda que necesitas 1 por ronda");
    platziCoins = int.Parse(Console.ReadLine());
    Console.WriteLine($"CUENTAS CON LOS SIGUIENTES PLATZICOINS: {platziCoins}");

    Console.WriteLine("¿Cuantos platzicoins deseas apostar:");
    apuesta = int.Parse(Console.ReadLine());


    for (int i = 0; i < platziCoins; i++)
    {
        totalJugador = 0;
        totalDealer = 0;

        switch (switchControl)
        {

            case "menu":

                Console.WriteLine("Escriba ‘21’ para jugar al 21 ");
                switchControl = Console.ReadLine();
                i = i - 1;
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

                } while (controlOtraCarta == "si" ||
                    controlOtraCarta == "SI" ||
                    controlOtraCarta == "YES" ||
                    controlOtraCarta == "yes");

                totalDealer = random.Next(14, 23);
                Console.WriteLine($"EL DEALER TIENE {totalDealer}");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "venciste al dealer, felicidades";
                    victoria = true;
                    switchControl = "menu";
                    if (victoria == true)
                    {
                        platziCoins = (platziCoins + apuesta);

                        Console.WriteLine($"TU NUEVO SALDO DE PLATZICOINS ES : {platziCoins}");
                    }
                }
                else if (totalJugador >= 22)
                {
                    message = "PERDISTE VS EL DEALER, TE PASASTE DE 21";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
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

                break;
        }
       

    }
}