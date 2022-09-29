public class Game
{
    public Random dice { get; set; }
    public string? name { get; set; }
    public Hero hero { get; set; }
    public Enemy enemy { get; set; }
    public Enemy[] enemies { get; set; }
    public bool isEnemy = false;
    public string pig = "ヽ( ˋ(00)´ )ノ";

    public Game(string hero)
    {
        dice = new Random();
        this.hero = new Hero(hero);
        enemies = new Enemy[]
        {
            new("Bizaro Mr. Miyagi"),
            new("The Nightman"),
            new("Krombopulus Michael"),
            new("Dr. Claw"),
            new("The man on the oatmeal box with the scary hat"),
            new("Jean Claude Van Dam with a spear")
        };
        
    }

    public Enemy GetEnemy()
    {
        return this.enemy = enemies[dice.Next(1, 7) - 1];
    }

    public string Roll()
    {
        switch(dice.Next(1, 7))
        {
            case 1:
                hero.panic += 2;
                return $"{hero.name} was hit!";
                
            case 2:
                hero.stamina--;
                return $"{hero.name} dodged {enemy.name}'s attack!";

            case 3:
                return $"{hero.name} deflected {enemy.name}'s attack!";

            case 4:
                hero.stamina--;
                return $"{enemy.name} dodged {hero.name}'s attack!";

            case 5:
                enemy.Stamina--;
                return $"{hero.name} struck {enemy.name} with a Glancing Blow";
            case 6:
                enemy.Stamina -= 6;
                return $"{hero.name} struck {enemy.name} with a Critical Hit! {pig}";
            default:
                return "";
        }

    }

    public string CheckEnemyStatus()
    {
        if( enemy.Stamina <= 0)
        {
            string status = $"{pig} {hero.name} has vanquished the {enemy.name} {pig}";
            GetEnemy();
            return $"{status} a snarling {enemy.name} enters the arena! Press <r> to see what happens next!";
            
        }
        hero.stamina--;
        return $"The {enemy.name} remains, press <r> to see what happens next!";
        
    }

}
