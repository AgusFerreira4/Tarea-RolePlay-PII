namespace Library;

public class Dwarf : ICharacter
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Defense { get; set; }
    public int Damage { get; set; }
    
    public Weapon Weapon { get; set; }
    
    public Armor Armor { get; set; }
    
    public Dwarf(string name, Weapon unWeapon)
        {
        this.Name = name;
        this.HP = 100;
        this.Defense = 3;
        this.Damage = 6;
        this.Weapon = unWeapon;
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
        character.HP = this.GetTotalAttack() - character.Defense;
    }
    
    public void Heal(ICharacter character)
    {
        character.HP = 100; 
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