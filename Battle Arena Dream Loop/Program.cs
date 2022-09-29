using System;


while (true)
{
    Console.WriteLine($"Welcome to Battle Arena Dream Loop! Press <s> to play! or <e> to exit. ");
    string start = Console.ReadLine();
    if (start.ToLower() != "s")
    {
        Console.WriteLine("bye...");
        break;
    }

    Console.WriteLine("Enter your hero name! ");
    string name = Console.ReadLine();
    if(name == null || name.Length == 0)
    {
        name = "Timmy";
    }
    Game game = new Game(name);
    game.GetEnemy();
    Console.WriteLine();
    Console.WriteLine($"{game.pig} {game.hero.name} wakes up in an arena with a crowd of aliens or monsters or something cheering for blood. Press any key to continue {game.pig}");
    Console.WriteLine();
    Console.ReadKey();
    Console.WriteLine($"the next thing {game.hero.name} knows a snarling {game.enemy.name} appears, press <r> to roll the die and see what happens next!");
    Console.WriteLine();
    while (true)
    {
        
        string roll = Console.ReadLine();
        if (roll != "r")
        {
            continue;
        }
        Console.WriteLine(game.Roll());
        Console.WriteLine();
        string heroStatus = game.hero.Status();
        if(heroStatus != string.Empty)
        {
            Console.WriteLine(heroStatus);
            break;
        }
        Console.WriteLine(game.CheckEnemyStatus());
        Console.WriteLine();
    }
    
}

