using _11_Delegates_02.Lib;
using System;

namespace _11_Delegates_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo photoZero = new Photo { Name = "profile.png", SizeX = 1920, SizeY = 1080 };
            PhotoProcessor.filters = new PhotoFilter().CreateThumb;
            PhotoProcessor.Processor(photoZero);

            Photo photoOne = new Photo { Name = "products.png", SizeX = 1920, SizeY = 1080 };
            PhotoProcessor.filters = new PhotoFilter().ToColor;
            PhotoProcessor.filters += new PhotoFilter().ResizeMedium;
            PhotoProcessor.Processor(photoOne);

            Photo photoTwo = new Photo { Name = "album.png", SizeX = 1920, SizeY = 1080 };
            PhotoProcessor.filters = new PhotoFilter().BackWhite;
            PhotoProcessor.Processor(photoTwo);

            Console.ReadKey();
        }
    }
}
