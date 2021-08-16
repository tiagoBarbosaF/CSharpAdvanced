using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Delegates.Lib;

namespace _01_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Screen - User registration: Thumb (profile picture)
            var photo = new Photo { Name = "profile.jpg", SizeX = 1920, SizeY = 1080 };
            PhotoProcessor.filters = new PhotoFilter().GenerateThumb;
            PhotoProcessor.Processor(photo);

            // Screen - Product registration: Color + ResizeMedium
            var photo2 = new Photo { Name = "product.jpg", SizeX = 1920, SizeY = 1080 };
            PhotoProcessor.filters = new PhotoFilter().Color;
            PhotoProcessor.filters += new PhotoFilter().ResizeMedium;
            PhotoProcessor.Processor(photo2);

            // Screen - User album registration - Retro Black and white
            var photo3 = new Photo { Name = "album.jpg", SizeX = 1920, SizeY = 1080 };
            PhotoProcessor.filters = new PhotoFilter().BlackWhite;
            PhotoProcessor.Processor(photo3);

            Console.WriteLine();
        }
    }
}
