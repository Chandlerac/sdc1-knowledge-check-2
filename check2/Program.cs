
using check2;

Console.WriteLine("How many music artist do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Artist>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var artist = new Artist();

    Console.WriteLine("Enter the artist name: ");
    artist.Name = Console.ReadLine();

    Console.WriteLine("Enter genre: ");
    artist.Genre = Console.ReadLine();

    recordList.Add(artist);
}

// Print out the list of records using Console.WriteLine()

foreach (var artist in recordList)
{
    Console.WriteLine($"Artist name:  {artist.Name}  Genre:  {artist.Genre}");
}