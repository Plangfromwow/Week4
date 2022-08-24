Digital music1 = new Digital("Itunes","TitleSong","Artist Song");
Vinyl vinyl1 = new Vinyl(10,"SongTitle","SongArtist");

List<Music> list = new List<Music>();
list.Add(music1);
list.Add(vinyl1);

foreach (Music song in list)
{
    Console.WriteLine(song);
}

// by adding abstract, we are blocking anyone from creating an instance of music 
// you can still derrive classes from music of course, and can be called in list types
abstract class Music
{
    public string title;
    public string artist;

    public Music(string title, string artist)
    {
        this.title = title;
        this.artist = artist;
    }

    public abstract void Print();
}

class Digital : Music
{
    public string platform;

    public Digital(string platform, string title,string artist) :base (title,artist)
    {
        this.platform = platform;
    }

    public override void Print()
    {
        Console.WriteLine("This is digital"); 
    }

}

sealed class Vinyl:Music
{
    public int count;

    public Vinyl(int count,string title, string artist) :base(title,artist)
    {
        this.count = count;
    }

    public override void Print()
    {
        Console.WriteLine("This is vinyl record");
    }
}