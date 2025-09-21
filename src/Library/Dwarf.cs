namespace Library;

public class Dwarf: ICharacter
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Defense { get; set; }
    public int Damage { get; set; }
    
    public Weapon Weapon { get; set; }
    
    public Armor Armor { get; set; }
    
    public Dwarf(string name, Weapon weapon)
        {
        Name = name;
        HP = 100;
        Defense = 3;
        Damage = 6;
        Weapon = weapon;

        }
    public int GetTotalAttack()
    {
        return Damage + Weapon.Damage + Armor.Damage;
    }

    public int GetTotalDefense()
    {
        return Defense + Weapon.Defense + Armor.Defense;
    }

    public void Attack(ICharacter character)
    {
        int totalDamage = Damage;
        if (Weapon != null)
        {
            totalDamage += Weapon.Damage;
        }
        character.HP = totalDamage - character.Defense;
    }
    
    public void Heal(ICharacter character)
    {
        character.HP = 100; 
    }
    
    public void ChangeItem(IItem item)
    {
        if (item is Weapon weapon)
            Weapon = weapon;
        else if (item is Armor armor)
            Armor = armor;
    }
    
    public void DropItem(IItem item)
    {
        if (item is Weapon && Weapon == item)
            Weapon = null;
        else if (item is Armor && Armor == item)
            Armor = null;
    }

    
}