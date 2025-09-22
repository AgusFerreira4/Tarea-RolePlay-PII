using System.Text.Json.Serialization;
using Library;
// --- Spells ---
Spell fireBall = new Spell("Fireball", "Fire", 0, 10, 9);
Spell health = new Spell("Healthing", "Healing", 16, 12, 0);

// --- Weapons ---
Weapon spellbook = new Weapon("Spellbook", "Book of spells", 1, new List<Spell>());
spellbook.AddSpell(fireBall);
spellbook.AddSpell(health);
Weapon elvenBow = new Weapon("Shortbow", "Bow", 5, new List<Spell>());
Weapon MiniSword = new Weapon("Sword of dwarfs", "Short distance weapon", 7,  new List<Spell>());
Weapon OldKatana = new Weapon("ProKatana", "Long range sword", 10, new List<Spell>());


// --- Armors ---

Armor wizardRobe = new Armor("Cloth", 4, "RObe of Wisdom");
Armor elvenArmor = new Armor("Cloth", 5, "Elven Leather Armor");
Armor dwarfArmor = new Armor("Cloth", 6, "Mini Armor");
Armor TheArmor = new Armor("Cloth", 10, "The Armor");


//--- Characters ---

Elf adam = new Elf("Adam", elvenBow);
adam.ChangeItem(elvenArmor);
adam.Heal(adam);
Wizard morgin = new Wizard("Morgin", spellbook);
morgin.ChangeItem(wizardRobe);
morgin.Heal(morgin);
morgin.Attack(adam);
morgin.ThrowSpell(fireBall);
Dwarf José = new Dwarf("José", MiniSword);
José.ChangeItem((dwarfArmor));
José.GetTotalAttack();
José.GetTotalDefense();
Dwarf DwarfGod = new Dwarf("DwarfGod", OldKatana);
DwarfGod.ChangeItem((TheArmor));
DwarfGod.Heal(DwarfGod);
DwarfGod.Attack(José);




