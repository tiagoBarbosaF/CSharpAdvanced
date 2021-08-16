using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegates.Lib
{
    class PhotoFilter
    {
        public void Color(Photo photo)
        {
            Console.WriteLine("PhotoFilter => Color " + photo.Name);
        }

        public void GenerateThumb(Photo photo)
        {
            Console.WriteLine("PhotoFilter => GenerateThumb " + photo.Name);
        }

        public void BlackWhite(Photo photo)
        {
            Console.WriteLine("PhotoFilter => BlackWhite " + photo.Name);
        }

        public void ResizeMedium(Photo photo)
        {
            Console.WriteLine("PhotoFilter => ResizeMedium " + photo.Name);
        }
    }
}
