namespace Library;

public class Spell
{
    public string Name { get; set; }
    public string Type{ get; set; }
    public int Healing{ get; set; }
    public int ManaCost{ get; set; }
    public int Damage{ get; set; }

    public Spell(string name, string type, int healing, int manaCost, int damage)
    {
        Name = name;
        Type = type;
        Healing = healing;
        ManaCost = manaCost;
        Damage = damage;
    }

}