// See https://aka.ms/new-console-template for more information
Console.WriteLine("The battlefield is thick with fog. A brave tank commander takes a drag of an un-lighted cigarette, hoping desperately to smoke it by the end of the day. Little does he suspect the Germans of rolling their own tank into his view. Panic erupts; there are only five shells left. It’s up to the commander to save the day, and smoke his cigarette in peace.");

var rand = new Random();

int tankPosition = rand.Next(40, 70);
int artillery = 5;
int victory = 0;
Console.WriteLine(tankPosition);

int counter = 0;

Console.Write("_/");
do
{

    if (counter == tankPosition)
    {
        Console.Write("T");
        counter++;

    }
    else
    {
        Console.Write("_");
        counter++;
    }


} while (counter < 80);
Console.WriteLine(" ");
Console.WriteLine("Name this brave commander.");
string commanderName = Console.ReadLine();

Console.WriteLine("Our brave and once foolhardy commander, " + commanderName + " regrets joining up.");
Console.WriteLine("There are not enough girls nor parties to make up for the hellfire on the Western Front.");
Console.WriteLine(" ");
Console.WriteLine("But, the show must go on.");
Console.WriteLine(" ");

do
{

    Console.WriteLine(commanderName + " aims a shot.");
    Console.WriteLine(" ");
    Console.Write("Input distance: ");
    int artilleryShot = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("2");
    for (int counter2 = 0; counter2 < artilleryShot; counter2++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("*");
 

    if (artilleryShot == tankPosition)
    {
        Console.WriteLine("The German tank sputters for a moment. The turret explodes in a cloud of smoke.");
        Console.WriteLine("Congratulations!" + commanderName + " lights a cigarillo, pleased with himself.");
        victory = 1;
        break;
    }

    if (artilleryShot > tankPosition)
    {
        artillery--;
        Console.WriteLine("The shot flies over the tank, landing with a dissapointing bang a few feet behind it. The Germans cheer.");
        Console.WriteLine($"{artillery} shells remaining");
    }
    else
    {
        artillery--;
        Console.WriteLine("The shot lands in front of the tank with a flare that burns your periscope.");
        Console.WriteLine($"{artillery} shells remaining");
    }
} while (artillery > 0 && victory == 0);

if (victory == 1)
{
    Console.WriteLine("Conglaturation!!! You have completed a great game. Now go rest our heroes.");
}
else
{
    Console.WriteLine($"Time to head for the hills and retreat, no time for cigarettes.");
    Console.WriteLine("GAME OVER");
}
