
Polygon inst = new Polygon("abc","def","ghi");
inst.addTwo("jkl", "mno");
foreach(string name in inst.names)
{
    Console.WriteLine(name);
}


class Polygon
{
    public List<string> names;

    public Polygon(string name1, string name2,string name3)
    {
        names = new List<string>();
        names.Add(name1);
        names.Add(name2);
        names.Add(name3);
    }


    public void addTwo(string name1,string name2)
    {
        names.Add(name1);
        names.Add(name2);
    }
}
