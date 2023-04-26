using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace LessonSix.FileWork
{
    public class FileWorkImages
    {
        public Bitmap ReadImageByPath(string path)
        {
            return new Bitmap(path);
        }

        public void ChangeExtension(string path, ImageFormat format)
        {
            var image = ReadImageByPath(path);
            var imageStream = GetImageStream(path);
            image.Save(imageStream, format);
        }

        private Stream GetImageStream(string path)
        {
            return new FileStream(path, FileMode.OpenOrCreate);
        }
    }
}
