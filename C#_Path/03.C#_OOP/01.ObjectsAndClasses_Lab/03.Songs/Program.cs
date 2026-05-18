class Program
{
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }

    static void Main()
    {
        List<Song> songs = new List<Song>();
        int numSongs = int.Parse(Console.ReadLine());

        for (int i = 0; i < numSongs; i++)
        {
            string[] data = Console.ReadLine().Split('_');
            Song newSong = new Song(data[0], data[1], data[2]);

            songs.Add(newSong);
        }

        string typeList = Console.ReadLine();

        foreach (var song in songs)
        {
            if (typeList == "all" || song.TypeList == typeList) Console.WriteLine(song.Name);
        }
    }
}