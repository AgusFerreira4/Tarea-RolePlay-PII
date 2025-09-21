namespace Library;   

public class Wizard : ICharacter
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Defense { get; set; }
    public Armor Armor { get; set; }
    public int Damage { get; set; }
    public int Magic { get; set; }
    public Weapon Weapon { get; set; }

    public Wizard(string name, Weapon weapon)
    {
        this.Name = name;
        this.Weapon = Weapon;
        this.Magic = 100;
        this.HP = 100;
        this.Damage = 2;
    }

    public void Attack(ICharacter character)
    {
        character.HP = (Damage + Weapon.Damage) - character.Defense;
    }

    public void ThrowSpell()
    {
        
    }

    public void Heal()
    {
        this.HP = 100;
    }
    public void ChangeItem(IItem item)
    {
        if (item is Weapon weapon)
        {
            Weapon = weapon;
        }
        else if (item is Armor armor)
        {
            Armor = armor;   
        }
    }

    public void DropItem(IItem item)
    {
        if (item is Weapon weapon)
        {
            Weapon = null; 
        }
        else if (item is Armor armor)
        {
            Armor = null;    
        }
    }
}
