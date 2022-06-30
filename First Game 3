// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int counter = 0;
//do
//{
//    Console.WriteLine($"Hello World! The counter is {counter}");
//    counter++;
//} while (counter < 10);

//int counter = 0;
//do
//{
//  Console.WriteLine($"{counter}");
//  counter++;
//}
//while ((counter % 3 == 0); < 20);

//int sum = 0;
//for (int index = 1; index <= 20; index++)
//{
//    Console.WriteLine($"index is {index}");
// if (index % 3 == 0)
//{
//  sum += index;
//}
// Console.WriteLine($"sum is {sum}");
//}

//int maxWarriorHP = 100;
//var random = new Random();
//int warriorHP = random.Next(1, maxWarriorHP + 1);
//Console.WriteLine($"Warrior's HP is {warriorHP}");

//if (warriorHP < 50)
//{
//  Console.WriteLine($"Cast the regeneration spell!");

//while (warriorHP < 50)
//{
//  warriorHP += 10;
//Console.WriteLine($"Warrior's HP is {warriorHP}");

// }
// Console.WriteLine($"The regeneration spell has run its course.");
//}

//int sum = 0
//{ 
//  sum += index;
//}
// Console.WriteLine($"sum is {sum}");
//}

//if ((dice1 == 6))
//{
// Console.WriteLine($"Total score: ");
//}

//else
//{ Console.WriteLine($"The player rolls: {dice1}"); }


//Console.WriteLine($"The player rolls:");
//Console.WriteLine($"Total score: {total}");


//for (int row = 1; row < 11; row++)
//{
// for (char column = 'a'; column < 'k'; column++)
//  {
//        Console.WriteLine($"The cell is ({row}, {column})");
//}
//}


//var random = new Random();
//int score = 0;
//int dice1;
//do
//{
//    dice1 = random.Next(1, 7);
//    Console.WriteLine($"The player rolls: {dice1}");
//    score += dice1;

//} while (dice1 < 6);

//Console.WriteLine($"Total Score: {score}");

//var random = new Random();
//int d10 = random.Next(1, 11);
//int cubeHP = d10r1 + d10r2 + d10r3 + d10r4 + d10r5 + d10r6 + d10r7 + d10r8 + d10r9 + d10r10 + d10r11 + d10r12 + d10r13 + d10r14 + d10r15 + d10r16 + d10r17 + d10r18 + d10r19 + d10r20 + 40;
//Console.WriteLine($"Created a character with {d6r1+d6r2+d6r3} strength points!");
//Console.WriteLine($"A gelantinous cube with {cubeHP} amount of hp appears!");
//Console.WriteLine($"Holy fuzzbonnets, an army of 100 cubes totalling {cubeHP * 100} appears in the distance. Better start running!");

//decimal lightYear = 9460730472580800.0M;
//decimal parsec = 3085700000000000.0M;
//decimal lDividedbyp;
//Console.WriteLine(lightYear/parsec);

//Create a random number generator.
var random = new Random();

//Generate Character HP
int charaHP = 0;

for (int index = 0; index < 3; index++)
{
    int d6r = random.Next(1, 7);
    charaHP += d6r;
}

Console.WriteLine($"Created a character with {charaHP} strength points!");

//Generate CubeHP
int cubeHP = 0;

for (int index = 0; index < 8; index++)
{
    int d10r = random.Next(1, 11);
    cubeHP += d10r;
}

cubeHP += 40;

Console.WriteLine($"A gelantinous cube with {cubeHP} amount of hp appears!");

//Generate Cube Hoard HP

int cubehoard = 0;

//Create 100 Cubes and add them to the hoard.

for (int index = 0; index < 100; index++)
{

    //Create 1 out of 100 Cubes
    cubeHP = 0;
    for (int index2 = 0; index2 < 8; index2++)
    {
        int d10r = random.Next(1, 11);
        cubeHP += d10r;
    }

    cubeHP += 40;

    //Add created cube to the hoard.
    cubehoard += cubeHP;
}

Console.WriteLine($"Holy fuzzbonnets, an army of 100 cubes totalling {cubehoard} appears in the distance. Better start running!");
