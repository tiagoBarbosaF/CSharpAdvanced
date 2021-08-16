using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegates.Lib
{
    class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public static PhotoFilterHandler filters;
        public static void Processor(Photo photo)
        {
            filters(photo);
            //var filter = new PhotoFilter();
            //filter.Color(photo);
            //filter.BlackWhite(photo);
            //filter.GenerateThumb(photo);
            //filter.ResizeMedium(photo);
        }
    }
}
