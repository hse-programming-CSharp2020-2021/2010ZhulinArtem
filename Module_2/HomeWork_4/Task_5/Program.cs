using System;
using System.Linq;

namespace Task_5
{
    internal class VideoFile
    {
        private readonly string _name;
        private readonly int _duration;
        private readonly int _quality;

        public int Size => _duration * _quality;

        public VideoFile(string name, int duration, int quality)
        {
            _name = name;
            _duration = duration;
            _quality = quality;
        }

        public override string ToString()
        {
            return $"Name: {_name}; Duration: {_duration}; " +
                   $"Quality: {_quality}; Size: {Size}";
        }
    }

    internal static class Program
    {
        private static readonly Random Random = new Random();

        private static void Main(string[] args)
        {
            var videoFiles = GenerateVideoFile();

            var videoFile = new VideoFile("AAA", 200, 750);

            foreach (var file in videoFiles.Where(file => file.Size>videoFile.Size))
            {
                Console.WriteLine(file);
            }
        }

        private static VideoFile[] GenerateVideoFile()
        {
            var videoFiles = new VideoFile[Random.Next(5, 16)];

            for (var i = 0; i < videoFiles.Length; i++)
            {
                var nameLength = Random.Next(2, 10);
                var name = string.Empty;
                for (var j = 0; j < nameLength; j++)
                {
                    name += (char)Random.Next('A', 'z');
                }

                videoFiles[i] = new VideoFile(name, Random.Next(60, 361), Random.Next(100, 1001));
            }

            return videoFiles;
        }
    }
}