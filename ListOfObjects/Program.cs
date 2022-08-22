List<Rectangle> rects = new List<Rectangle>();
Rectangle rect1 = new Rectangle("Fred", 3.5, 4.2);
rects.Add(rect1);
Rectangle rect2 = new Rectangle("Sally", 4.6, 5.5);
rects.Add(rect2);

Console.WriteLine("Which rectangle?");
string entry = Console.ReadLine();

Rectangle found = null;

foreach (Rectangle rect in rects)
{
    if (rect.name == entry)
    {
        found = rect;
        break;
    }
}

if (found != null)
{
    Console.WriteLine(found);
}
else
{
    Console.WriteLine("Sorry not found. :(");
}

class Rectangle
{
    public string name;
    public double length;
    public double height;

    public Rectangle(string _name, double _lenght, double _height)
    {
        name = _name;
        length = _lenght;
        height = _height;
    }


    public override string ToString()
    {

        return $"{name}: {length}x{height}, Area = {length * height}";


    }
}