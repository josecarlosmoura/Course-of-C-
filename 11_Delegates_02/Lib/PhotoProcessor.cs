using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Delegates_02.Lib
{
    public class PhotoProcessor
    {
        public delegate void PhotFilterHandler(Photo photo);

        public static PhotFilterHandler filters;

        public static void Processor(Photo photo)
        {
            filters(photo);
            //var filter = new PhotoFilter();
            //filter.ToColor(photo);
            //filter.BackWhite(photo);
            //filter.CreateThumb(photo);
            //filter.ResizeMedium(photo);
        }
    }
}
