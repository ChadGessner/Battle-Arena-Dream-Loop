public class Hero
{
    public string name { get; set; }
    public int stamina { get; set; } = 10;
    public int panic { get; set; } = 10;

    public Hero(string name)
    {
        this.name = name;
    }

    public string Status()
    {
        if(stamina <= 0)
        {
            return $"{name} has run out of stamina...";
        }
        if(panic >= 20)
        {
            return $"{name} panic level is to high and totally freaked out and died...";
        }
        return "";
            
        
    }

}
