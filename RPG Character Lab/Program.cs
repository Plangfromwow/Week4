// RPG Character Lab
List<GameCharacter> gameCharacters = new List<GameCharacter>();
gameCharacters.Add(new Warrior("Axe", "Folyore Boondiggles", 15, 3));
gameCharacters.Add(new Warrior("Spear", "Tolgrath, The Relentless", 18, 2));
gameCharacters.Add(new Wizard(15,200,"PlangTheMage",12,18));
gameCharacters.Add(new Wizard(100, 500, "Jana Proudmore", 15, 25));
gameCharacters.Add(new Wizard(1500, 9001, "Khadgar, The Guardian", 30, 30));

Console.WriteLine("Welcome to World of Dev.BuildCraft!!");
Console.WriteLine();
Console.WriteLine("Here are all the characters:");
foreach (GameCharacter character in gameCharacters)
{
    character.Play();
}

 class GameCharacter
{
    public string name; 
    public int strength { get; set; } 
    public int intelligence;    

    public GameCharacter (string _name, int _strength, int _intelligence)
    {
        name = _name;
        strength = _strength;
        intelligence = _intelligence;
    }

    public virtual void Play()
    {
        Console.WriteLine("Look mom I'm a gamer!");
    }
}


class MagicUsingCharacter:GameCharacter
{
    public int magicalEnergy;

    public MagicUsingCharacter(int _magicEnergy, string _name, int _strength, int _intelligence) 
        :base( _name,_strength,_intelligence)
    {
        magicalEnergy = _magicEnergy;
    }

    public override void Play()
    {
        Console.WriteLine("You use magic.");
    }
}


class Wizard:MagicUsingCharacter
{
    public int spellNumber;

    public Wizard (int _spellNumber, int _magicEnergy, string _name, int _strength, int _intelligence) 
        : base(_magicEnergy,_name,_strength,_intelligence)
    {
        spellNumber = _spellNumber;
    }


    public override void Play()
    {
        Console.WriteLine($"Wizard - {name} Mana: {magicalEnergy} Strength: {strength} Int: {intelligence} and has {spellNumber} spells.");
    }
}

class Warrior:GameCharacter 
{
    public string weaponType;

    public Warrior (string _weaponType, string _name, int _strength, int _intelligence)
        :base(_name, _strength, _intelligence)
    {
        weaponType = _weaponType;
    }

    public override void Play()
    {
        Console.WriteLine($"Warrior - {name} Strength: {strength} Int: {intelligence} and has a {weaponType}");
    }

}