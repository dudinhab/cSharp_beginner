int heroLife = 10;
int monsterLife = 10;
Random random = new Random();
int roundAttack = 0;
do
{
    if ((heroLife == 10) && (monsterLife == 10))
    {
        Console.WriteLine($"Hero life:{heroLife}");
        Console.WriteLine($"Monster life:{monsterLife}");
        Console.WriteLine();
        Console.WriteLine("----------------------------");
    }

    Console.WriteLine("Hero attack round");
    roundAttack = random.Next(1, 11);
    monsterLife -= roundAttack;
    Console.WriteLine($"Monster was damaged and lost {roundAttack} health and now has {monsterLife} health.");
    Console.WriteLine();
    
    if (monsterLife <= 0) continue;
    
    Console.WriteLine("Monster attack round");
    roundAttack = random.Next(1, 11);
    heroLife -= roundAttack;
    Console.WriteLine($"Hero was damaged and lost {roundAttack} health and now has {heroLife} health.");

    Console.WriteLine("----------------------------");

} while (!(heroLife <= 0) && !(monsterLife <= 0));

Console.WriteLine(heroLife > monsterLife ? "********** Hero wins! **********" : "********** Monster wins! **********");