using Library;
// --- Spells ---
Spell fireBall = new Spell("Fireball", "Fire", 0, 10, 9);
Spell health = new Spell("Healthing", "Healing", 16, 12, 0);

// --- Weapons ---
Weapon spellbook = new Weapon("Spellbook", "Book", 1, new List<Spell>());
spellbook.AddSpell(fireBall);
spellbook.AddSpell(health);
Weapon elvenBow = new Weapon("Shortbow", "Bow", 5, new List<Spell>());


// --- Armors ---

Armor wizardRobe = new Armor("Cloth", 4, "RObe of Wisdom");
Armor elvenArmor = new Armor("Cloth", 5, "Elven Leather Armor");


//--- Characters ---

Elf adam = new Elf("Adam", elvenBow);
adam.ChangeItem(elvenArmor);
Wizard morgin = new Wizard("Morgin", spellbook);
morgin.ChangeItem(wizardRobe);



