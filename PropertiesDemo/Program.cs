RAM mod1 = new RAM("Intel", "DDR3", 32);

Console.WriteLine(mod1.Brand);
mod1.Type = "DDR4";
Console.WriteLine(mod1.Stock);
mod1.Vendor = "Twinkle Toes";
Console.WriteLine(mod1.Vendor);


class RAM
{
    private string pBrand;
    private string pType;
    private int pGB;
    private int pStock;
    public string Vendor { get; set; }

    public RAM(string _brand, string _type, int _GB)
    {
        pBrand = _brand;
        if (_type == "DDR" || _type == "DDR2" || _type == "DDR3" || _type == "DDR4")
        {
            pType = _type;
        }
        else
        {
            pType = "DDR";
        }
        if (_GB >= 1 && _GB <= 32)
        {
            pGB = _GB;
        }
        else
        {
            pGB = 4;
        }

        pStock = 10;
        Vendor = "Amazon";
    }

    public string Brand
    {
        get
        {
            return pBrand;
        }
    }

    public string Type 
    { 
        get 
        { 
            return pType; 
        } 
        set 
        {
            if (value == "DDR" || value == "DDR2" || value == "DDR3" || value == "DDR4")
            {
                pType = value;
            }
        } 
    }



    public int Stock
    {
        get
        {
            return pStock;
        }
        set
        {
            pStock = value;
        }
    }

}