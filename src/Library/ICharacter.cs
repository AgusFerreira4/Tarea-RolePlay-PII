namespace Library;

public interface ICharacter
{
    string Name { get; set; }
    int HP { get; set; }
    int Defense { get; set; }
    int Damage { get; set; }

    Weapon Weapon { get; set; }
    Armor Armor { get; set; }

    void Attack(ICharacter character);
    void Heal(ICharacter character);

    void ChangeItem(IItem item);

    void DropItem(IItem item);

    int GetTotalAttack();

    int GetTotalDefense();
}