using Bank_switch.Helper;

string name = "Ruslan";
int cardNum = 123456789;
int password = 1111;
int balans = 500;
int limitC = 200;
int limitD = 500;


basha:
Console.WriteLine("Kart nomrenizi daxil edin:");
var currentCard = Console.ReadLine();

Console.WriteLine("PİN kodu daxil edin:");
var currentPas = Console.ReadLine();



if (cardNum == Convert.ToInt32(currentCard) && password == Convert.ToInt32(currentPas))   
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine(name + "Bey" +  "Xosh geldiniz");
   Console.BackgroundColor = ConsoleColor.Black;
}
else
{
    //(cardNum != Convert.ToInt32(currentCard) && password != Convert.ToInt32(currentPas));
    Console.WriteLine("Login ve ya PIN yalnishdi");
    goto basha;
}


evvele:
Console.WriteLine(" Bir Emeliyyat Secin:");
Console.WriteLine("1. Negd pulun daxil edilmesi");
Console.WriteLine("2. Negd pulun cixarilmasi");
Console.WriteLine("3. Balansi gostermek");
Console.WriteLine("4. Karti qeri almaq");
var action = Console.ReadLine();

operation opr = new operation();    

switch (action)
{
    case "1":
        opr.PulDaxili(limitD);
        goto evvele;
        break;
    case "2":
        opr.PulCixarilishi(limitC);
        goto evvele;
        break;
    case "3":
        Console.WriteLine("Balansiniz:" + balans + "AZN");
        goto evvele;
        break;
    case "4":
        goto basha;
        break;
    default:
        break;
}