namespace Library;   

public class Wizard : ICharacter
{
    public string Name { get; set; }
    public int HP { get; set; }

    public int Defense { get; set; }

    public Armor Armor { get; set; }
    public int Damage { get; set; }
    public int Mana { get; set; }
    public Weapon Weapon { get; set; }

    public Wizard(string name, Weapon weapon)
    {
        this.Name = name;
        this.Weapon = weapon;
        this.Mana = 100;
        this.HP = 100;
        this.Damage = 2;
        this.Defense = 2;
    }

    public void Attack(ICharacter character)
    {
        character.HP = this.GetTotalAttack() - character.Defense;
    }

    public int GetTotalAttack()
    {
        return Damage + Weapon.Damage + Armor.Damage;
    }

    public int GetTotalDefense()
    {
        return Defense + Weapon.Defense + Armor.Defense;
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

    public void Heal(ICharacter character)
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
