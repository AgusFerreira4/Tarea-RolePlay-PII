namespace Library;

public interface IItem
{
    string Name { get; set; }
    int Defense { get; set; }
    int Damage { get; set; }
    int Healing { get; set; }
}