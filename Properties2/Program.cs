Rectangle r1 = new Rectangle(10.5m, 3.6m);
Console.WriteLine(r1);
r1.height = -5;
Console.WriteLine(r1);


class Rectangle
{
    // lets keep length with the ez shortcut, going to validate height
    public decimal length { get; set; } // shortcut is really needed for databases and API's 
    private decimal pHeight;
    
    public decimal height 
    {
        get
        {
            return pHeight;
        }
        set
        {
            if (value > 0)
            {
                pHeight = value;
            }else
            {
                pHeight = 1;
            }
            
        } 
    }


    public Rectangle (decimal length, decimal height)
    {
        this.length = length;
        this.height = height;
    }


    public override string ToString()
    {
        return $"{length} {height} Area: {length * height}";
    }
}