using System;

namespace _11_Delegates_02.Lib
{
    public class PhotoFilter
    {
        public void ToColor(Photo photo) => Console.WriteLine($"Photofilter => ToColor: {photo.Name}");

        public void CreateThumb(Photo photo) => Console.WriteLine($"PhotoFilter => Create Thumb: {photo.Name}");

        public void BackWhite(Photo photo) => Console.WriteLine($"PhotFilter => Black White: {photo.Name}");

        public void ResizeMedium(Photo photo) => Console.WriteLine($"PhotoFilter => Resize Medium: {photo.Name}");
    }
}
