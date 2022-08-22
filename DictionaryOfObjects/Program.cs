Dictionary<string, Rectangle> rects = new Dictionary<string, Rectangle>();

rects["Fred"] = new Rectangle("Fred",3.5, 4.6);
rects["Sally"] = new Rectangle("Sally",3.5, 4.6);
rects["Sam"] = new Rectangle("Sam",3.5, 4.6);


foreach (var rect in rects)
{
    Console.WriteLine($"Key:{rect.Key}  Value:{rect.Value}");
}

//These are just too complicated and make no sense because it's all about lists babbbyyyy

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
        return $"{name}: {length}x{height}";
    }
}