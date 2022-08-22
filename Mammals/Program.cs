
Dog first = new Dog() {name="Fido",barkVolume = 8, hairColor= "Black",legCount=4 };
Dog second = new Dog() { name = "Nelly",barkVolume = 5,hairColor = "gold", legCount=4 };

Orangutan third = new Orangutan() { name = "Fred", hairColor = "Orange", legCount = 2 , thumbLength = 3};

// adding the created animals to the list of mammals
List<Mammal> pets = new List<Mammal>();
pets.Add(first);
pets.Add(second);
pets.Add(third);

foreach (Mammal animal in pets)
{
    string info = animal.ToString(); // C# is grabbing the most specific ToString 
    Console.WriteLine(info);
}




class Mammal
{
    public string name;
    public string hairColor;
    public int legCount; // how many legs

    public void walk()
    {
        Console.WriteLine("I am walking");
    }
    // we are overriding what is called a "virtual function". ToString is a virtual function
    // i.e a virtual function is one you can override
    public override string ToString()
    {
        return "This is a mamal";
    }

}

class Dog : Mammal
{
    public int barkVolume; // how loud it barks

    
    public override string ToString()
    {
        return $"Dog {name} hair color: {hairColor} {legCount} legs. And barks at volume {barkVolume}";
    }
}

class Orangutan : Mammal
{
    public int thumbLength;


    public override string ToString()
    {
        return $"Orangutan {name} hair color: {hairColor} {legCount} legs. And thumb length is {thumbLength}";
    }
}