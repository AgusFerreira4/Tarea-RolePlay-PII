namespace Library;

public class Dwarf : ICharacter
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int BaseDefense { get; set; }
    public int TotalDefense
    {
        get
        {
            return this.BaseDefense + this.Armor.Defense + this.Weapon.Defense;
        }
    }
    public int BaseDamage { get; set; }
    public int TotalDamage
    {
        get
        {
            return this.BaseDamage + this.Armor.Damage + this.Weapon.Damage;
        }
    }
    
    public Weapon Weapon { get; set; }
    
    public Armor Armor { get; set; }
    
    public Dwarf(string name, Weapon unWeapon)
        {
        this.Name = name;
        this.HP = 100;
        this.BaseDefense = 3;
        this.BaseDamage = 6;
        this.Weapon = unWeapon;
        }
    
    public void Attack(ICharacter character)
    {
        int totalDamage = BaseDamage;
        if (Weapon != null)
        {
            totalDamage += Weapon.Damage;
        }
        character.HP = totalDamage - character.BaseDefense;
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