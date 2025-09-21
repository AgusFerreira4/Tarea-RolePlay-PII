namespace Library;   

public class Wizard : ICharacter
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

    public Armor Armor { get; set; }
    public int BaseDamage { get; set; }
    public int TotalDamage
    {
        get
        {
            return this.BaseDamage + this.Armor.Damage + this.Weapon.Damage;
        }
    }
    public int Mana { get; set; }
    public Weapon Weapon { get; set; }

    public Wizard(string name, Weapon weapon)
    {
        this.Name = name;
        this.Weapon = weapon;
        this.Mana = 100;
        this.HP = 100;
        this.BaseDamage = 2;
        this.BaseDefense = 2;
    }

    public void Attack(ICharacter character)
    {
        character.HP = (BaseDamage + Weapon.Damage) - character.BaseDefense;
    }

    public void ThrowSpell(Spell spell)
    {
        if (Weapon.Type == "Book of spells")
        {
            bool spellInBook = Weapon.Spells.Contains(spell);
            if (spellInBook)
            {
                this.Mana = Mana - spell.ManaCost;
            }

        }
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
