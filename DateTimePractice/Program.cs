// Date Time Practice 

DateTime time1 = new DateTime(2022,07,31);
Console.WriteLine(time1);
Console.WriteLine(time1.ToString("yyyy/MM/dd"));
DateTime time2 = DateTime.Now;
Console.WriteLine(time2);

DateTime time3 = DateTime.Parse("08/21/2022");
Console.WriteLine(time3);