using System.Net.NetworkInformation;
List<Car> cars = new List<Car>();
initList(cars);
Console.WriteLine("Welcome to the Car App!");
while (true)
{
    Console.WriteLine("The current car selection is this:");
    
    for (int i = 0; i < cars.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {cars[i]}");
    }
    Console.WriteLine("What would you like to do?");
    Console.Write("(P)urchase / (A)dd / (Q)uit: ");
    string userInput = Console.ReadLine().ToLower();

    if (userInput == "add" || userInput == "a")
    {
        addCar(cars);
    }
    else if (userInput == "p" || userInput == "purchase")
    {
        purchaseCar(cars);
    }
    else if (userInput == "q" || userInput == "quit")
    {
        break;
    }
    else
    {
        Console.WriteLine("Please try again.");
    }
}

static void purchaseCar(List<Car> _list)
{
    
    Console.Clear();
    for (int i = 0; i < _list.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {_list[i]}");
    }
    Console.Write("Which car would you like to purchase?: ");
    int userChoice = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine($"Enjoy your {_list[userChoice].make} {_list[userChoice].model}!");
    _list.RemoveAt(userChoice);

}

static void addCar(List<Car> _list)
{
    Console.Clear();
    Console.WriteLine("Is this a (n)ew or (u)sed car?");
    string newOrUsed = Console.ReadLine().ToLower();
    Console.Write("Make: ");
    string userMake = Console.ReadLine();
    Console.Write("Model: ");
    string userModel = Console.ReadLine();
    Console.Write("Year: ");
    int userYear = int.Parse(Console.ReadLine());
    Console.Write("Price: ");
    decimal userPrice = decimal.Parse(Console.ReadLine());

    if (newOrUsed == "new" || newOrUsed == "n")
    {
        _list.Add(new Car(userMake, userModel, userYear, userPrice));
    }
    else if (newOrUsed == "used" || newOrUsed == "u")
    {
        Console.Write("Miles: ");
        double userMileage = double.Parse(Console.ReadLine());

        _list.Add(new UsedCar(userMake, userModel, userYear, userPrice, userMileage));
    }
}

static void initList(List<Car> _list)
{
    _list.Add(new UsedCar("Honda","Civic",1992,13000m,33000));
    _list.Add(new UsedCar("Chevy", "Blazer", 2012, 130000m, 23000));
    _list.Add(new UsedCar("Chevy", "Bolt", 2002, 13000m, 330000));
    _list.Add(new Car("Ford", "F-150", 2022, 53000m));
    _list.Add(new Car("Honda", "Civic", 2022, 23000m));
    _list.Add(new Car("Honda", "CRV", 2022, 33000m));

}

class Car
{
    public string make;
    public string model;
    public int year;
    public decimal price;

    public Car (string _make, string _model, int _year, decimal _price)
    {
        make = _make;
        model = _model;
        year = _year;
        price = _price;
    }

    public override string ToString()
    {
        return $"{year} {make} {model} ${price}";
    }
    

}

class UsedCar:Car
{

    public double mileage;

    public UsedCar (string _make, string _model, int _year, decimal _price, double _mileage)
        :base (_make,_model,_year,_price)
    {
        mileage = _mileage;
    }

    public override string ToString()
    {
        return $"{year} {make} {model} with {mileage} Miles. ${price}";
    }
}