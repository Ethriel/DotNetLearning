using System;
using System.IO;
using System.Text;

namespace LessonSix.FileWork
{
    public class FileWorkBase
    {
        public string BinaryRead()
        {
            var bytes = new byte[byte.MaxValue];
            var bytesCount = default(int);
            var stringResult = default(string);
            var stringBuilder = new StringBuilder();
            using (var stream = new FileStream("test_text_v1.txt", FileMode.Open))
            {
                while ((bytesCount = stream.Read(bytes, 0, bytes.Length)) > 0)
                {
                    stringResult = Encoding.UTF8.GetString(bytes);
                    stringBuilder.Append(stringResult);
                }
            }

            return stringBuilder.ToString();
        }

        public void BinaryWrite(string inputFilePath, string inputData)
        {
            var bytesData = Encoding.UTF8.GetBytes(inputData);
            using (var stream = new FileStream(inputFilePath, FileMode.Open))
            {
                stream.Write(bytesData, 0, bytesData.Length);
            }

            Console.WriteLine(Encoding.UTF8.GetString(bytesData));
        }
    }
}
