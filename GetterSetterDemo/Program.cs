RAM mod1 = new RAM("Intel", "DDR3", 32);
Console.WriteLine("Brand: " + mod1.getBrand());
mod1.setType("DDR2");
Console.WriteLine("Type: " + mod1.getType());
mod1.setType("Hello");
Console.WriteLine("Type: " + mod1.getType());
mod1.setGB(16);
Console.WriteLine("GB: " + mod1.getGB());



class RAM
{
    // common pattern make all member variables private
    private string brand;
    private string type;
    private int GB;


    public RAM (string _brand, string _type, int _GB)
    {
        brand = _brand;
        if (_type == "DDR" || _type == "DDR2" || _type == "DDR3" || _type == "DDR4")
        {
            type = _type;
        }else 
        {
            type = "DDR";
        }
        if (_GB >= 1 && _GB <= 32)
        {
            GB = _GB;
        }
        else 
        { 
            GB = 4;
        }
    }

    // after the initial set up, they can't change the other things
    // 1. the user cannnot change the brand, but can look at it (Read only)
    // 2. the user can set the type and look at it, but is limited to only two types (read/write) but with validation 
    // 3. the user can set the GB and look at it but is limited to the range of 1 - 32 (read/write) but with validation

    //write set of methods to get and set these values 

    public string getBrand()
    {
        return brand;
    }

    public string getType()
    {
        return type;
    }

    public void setType(string _type)
    {
        if (_type == "DDR"|| _type == "DDR2" || _type == "DDR3" || _type == "DDR4")
        {
            type = _type;
        }
    }

    public int getGB()
    {
        return GB;
    }

    public void setGB(int value) // usually just use value for the thing 
    {
        if (value>=1 && value<=32)
        {
            GB = value;
        }
    }
}

