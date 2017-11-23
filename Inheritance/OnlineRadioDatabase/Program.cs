using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());
		var songs = new List<Song>();

		for (int i = 0; i < n; i++)
		{
			string[] songInfo = Console.ReadLine().Split(';');

			try
			{
				string[] time = songInfo[2].Split(':').ToArray();
				int digit1;
				int digit2;
				if (int.TryParse(time[0], out digit1) && int.TryParse(time[1], out digit2))
				{
					var song = new Song(songInfo[0], songInfo[1], digit1, digit2);
					songs.Add(song);
					Console.WriteLine("Song added.");
				}
				else
				{
					throw new InvalidSongLengthException();
				}

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

		}

		int totalDuration = 0;
		foreach (var song in songs)
		{
			totalDuration += song.Minutes * 60 + song.Seconds;
		}
		int hours = totalDuration / 3600;
		totalDuration -= hours * 3600;
		int minutes = totalDuration / 60;
		totalDuration -= minutes * 60;
		int seconds = totalDuration;

		Console.WriteLine($"Songs added: {songs.Count}");
		Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
	}
}

