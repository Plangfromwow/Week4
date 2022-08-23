using System.Diagnostics;
using System.IO;
//Always start by building classes, "Model First Programming". 
//start with instance of each as you go to test it out 
// get app working for one time around 
// then finally add the repetition 
// Create Read Update Delete > functions of an application 
List<MediaType> allMedia = new List<MediaType>();
initList(allMedia);
while (true)
{
    // Main App
    string choice = listMediaMenu(allMedia);
    if (choice.ToLower() == "a")
    {
        addMedia(allMedia);
    }
    else if (choice.ToLower() == "q")
    {
        Console.WriteLine("Thanks for shopping!");
        break;
    }
    else
    {
        int index = int.Parse(choice);
        index--;
        buyMedia(allMedia, index);
    }
}

static void buyMedia(List<MediaType> _list,int _index)
{
    Console.WriteLine($"Do you want to purchase {_list[_index]} ?");
    Console.Write("(Y/N): ");
    string yesno = Console.ReadLine();
    if (yesno.ToLower() == "y" || yesno.ToLower() == "yes")
    {
        _list.RemoveAt(_index);
        Console.WriteLine("Item Purchased!");
    }
    else
    {
        Console.WriteLine("Thanks anyway!");
    }
}

static void addMedia(List<MediaType> _list)
{
    Console.WriteLine("What type of Media would you like to add?");
    Console.Write("Video / Digital / Vynl: ");
    string type = Console.ReadLine().ToLower();
    // Ask for title and genre before media specific questions
    Console.Write("Title: ");
    string title = Console.ReadLine();
    Console.Write("Genre: ");
    string genre = Console.ReadLine();
    if (type == "video")
    {
        Console.Write("Director: ");
        string director = Console.ReadLine();
        Console.Write("Rating: ");
        string rating = Console.ReadLine();

        _list.Add(new Video(title, genre, director, rating));

    }
    else if (type == "digital")
    {
        Console.Write("Artist: ");
        string artist = Console.ReadLine();
        Console.Write("Duration: ");
        string duration = Console.ReadLine();
        Console.Write("Platform: ");
        string platform = Console.ReadLine();

        _list.Add(new Digital(title, genre, artist, int.Parse(duration), platform));

    }
    else if (type == "vynl")
    {
        Console.Write("Artist: ");
        string artist = Console.ReadLine();
        Console.Write("Duration: ");
        string duration = Console.ReadLine();
        Console.Write("Count: ");
        string count = Console.ReadLine();

        _list.Add(new Vinyl(title, genre, artist, int.Parse(duration), int.Parse(count)));
    }
}

static void initList(List<MediaType> _list)
{
    Video video1 = new Video("TheShining", "horror", "Kubrik", "r");
    Digital song1 = new Digital("Toxic", "pop", "Brittany Spears", 190, "Apple Music");
    _list.Add(video1);
    _list.Add(song1);
    _list.Add(new Digital("The White Album", "Rock", "The Beatles", 45, "Itunes"));
    _list.Add(new Digital("Party Rock", "Opera", "Black Eyed Peas", 45, "Itunes"));
}

static string listMediaMenu(List<MediaType> _list)
{
    Console.WriteLine("Choose a Media or another option: ");
    for (int i = 0; i < _list.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {_list[i]}");
    }

    Console.WriteLine("(A)dd new Media");
    Console.WriteLine("(Q)uit");
    Console.Write("Youre Choice: ");
    string entry = Console.ReadLine();
    return entry;
}

class MediaType
{
    public string title;
    public string genre;

    public MediaType (string _title, string _genre)
    {
        title = _title;
        genre = _genre;
    }

    public virtual void Play()
    {
        Console.WriteLine("The media is playing");
    }
}

class Video:MediaType
{
    public string director;
    public string rating;

    public Video (string _title,string _genre, string _director,string _rating) 
        :base (_title,_genre)
    {
        director = _director;
        rating = _rating;
    }


    public override void Play()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Video:{title} ({genre}) Directed By: {director} Rated: {rating}" ;
    }

}

class Music:MediaType 
{
    public string artist;
    public int duration;

    public Music (string _title, string _genre, string _artist, int _duration)
        :base(_title,_genre)
    {
        artist = _artist;
        duration = _duration;
    }

    public override void Play()
    {
        Console.WriteLine("Music");
    }
}

class Digital:Music
{
    public string platform;

    public Digital (string _title, string _genre, string _artist, int _duration,string _platform)
        :base(_title,_genre,_artist, _duration)
    {
        platform = _platform;
    }
    public override void Play()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Song:{title} ({genre}) Created By: {artist} Duration: {duration}sec on {platform}";
    }
}

class Vinyl:Music
{
    public int count;
    
    public Vinyl (string _title, string _genre, string _artist, int _duration, int _count)
        :base (_title, _genre, _artist, _duration)
    {
        count = _count;
    }

    public override void Play()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Song:{title} ({genre}) Created By: {artist} Duration: {duration}sec with a count of {count}";
    }

}