using System.Security.Cryptography.X509Certificates;
RandomPlayer p1 = new RandomPlayer("Santa");
AlwaysPlayer p2 = new AlwaysPlayer("Sally", Roshambo.rock);
AlwaysPlayer p3 = new AlwaysPlayer("Sam", Roshambo.rock);
RandomPlayer p4 = new RandomPlayer("Jim");
RandomPlayer p5 = new RandomPlayer("Greg");

Play(p1, p2);
Play(p1, p2);
Play(p1, p2);

Play(p5, p4);
Play(p5, p4);
Play(p5, p4);

Play(p1, p4);
Play(p1, p4);
Play(p1, p4);
Play(p1, p4);
Play(p1, p4);
Play(p1, p4);

static void Play(Player p1,Player p2)
{
    p1.Generate();
    p2.Generate();

    if (p1.currentChoice == p2.currentChoice)
    {
        Console.WriteLine($"Players: {p1.name}: {p1.currentChoice} and {p2.name}: {p2.currentChoice}. Result: DRAW");
    }
    else if (p1.currentChoice == Roshambo.rock)
    {
        if (p2.currentChoice == Roshambo.paper)
        {
            Console.WriteLine($"Players: {p1.name}: {p1.currentChoice} and {p2.name}: {p2.currentChoice}. Result: {p2.name} WINS");
        }
        else
        {
            Console.WriteLine($"Players: {p1.name}: {p1.currentChoice} and {p2.name}: {p2.currentChoice}. Result: {p1.name} WINS");
        }
    }
    else if (p1.currentChoice == Roshambo.paper)
    {
        if(p2.currentChoice == Roshambo.rock)
        {
            Console.WriteLine($"Players: {p1.name}: {p1.currentChoice} and {p2.name}: {p2.currentChoice}. Result: {p1.name} WINS");
        }
        else 
        {
            Console.WriteLine($"Players: {p1.name}: {p1.currentChoice} and {p2.name}: {p2.currentChoice}. Result: {p2.name} WINS");
        }
    }else
    {
        if(p2.currentChoice == Roshambo.rock)
        {
            Console.WriteLine($"Players: {p1.name}: {p1.currentChoice} and {p2.name}: {p2.currentChoice}. Result: {p2.name} WINS");
        }
        else
        {
            Console.WriteLine($"Players: {p1.name}: {p1.currentChoice} and {p2.name}: {p2.currentChoice}. Result: {p1.name} WINS");
        }
    }
}

enum Roshambo
{
    rock,
    paper,
    scissors
}

abstract class Player
{
    public string name;
    public Roshambo currentChoice;


    public virtual void Generate()
    {

    }
}

class RandomPlayer : Player
{

    public RandomPlayer(string name)
    {
        this.name = name;
    }

    public override void Generate()
    {
        Random r = new Random();
        currentChoice = (Roshambo)r.Next(0,3);
    }


}

class AlwaysPlayer : Player
{
    public AlwaysPlayer(string name, Roshambo choice)
    {
        this.name = name;
        currentChoice = choice;
    }
}