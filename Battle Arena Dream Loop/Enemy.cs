public class Enemy
{
    public string name { get; set; }
    public int Stamina { get; set; } = 10;
    public Enemy(string name)
    {
        this.name = name;
    }
}
