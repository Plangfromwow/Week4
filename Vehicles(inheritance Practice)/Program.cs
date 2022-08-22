Sedan myCar = new Sedan(4, "blue", true, 4);
myCar.Drive();
RaceCar myRaceCar = new RaceCar(400, 4, "Red");
myRaceCar.Drive();
RaceCar secondRacecar = new RaceCar(4000, 3, "yellow");
Console.WriteLine();
Console.WriteLine("Everybody Drive!");
List<Vehicle> cars = new List<Vehicle>();
cars.Add(myCar);
cars.Add(myRaceCar);
cars.Add(secondRacecar);

foreach (Vehicle car in cars)
{
    car.Drive();
}


Console.WriteLine();


Vehicle something;
something = myCar;
something.Drive(); // this calls the correct one 

something = myRaceCar;
something.Drive(); // Again, this calls the right one

// This is called Polymorphism 

class Vehicle
{
    public int wheelCount;
    public string color;


    public Vehicle (int _wheelCount, string _color)
    {
        wheelCount = _wheelCount;
        color = _color;
    }

    public virtual void Drive()
    {
        Console.WriteLine("I am driving.");
    }
}


class Sedan:Vehicle
{

    public bool isHatchback;
    public int doorCount;

    public Sedan (int _sedanWheelCount, string _sedanColor, bool _isHatchback, int _doorCount) 
        : base(_sedanWheelCount,_sedanColor)
    {
        isHatchback = _isHatchback;
        doorCount = _doorCount;
    }

    public override void Drive()
    {
        Console.WriteLine("I am driving the speed limit!");
    }

}

class RaceCar:Vehicle
{
    public int engineSize;

    public RaceCar (int _engineSize, int _wheelCount, string _color)
        :base (_wheelCount, _color)
    {
        engineSize = _engineSize;
    }


    public override void Drive()
    {
        Console.WriteLine("I am driving over the speed limit!");
    }
}