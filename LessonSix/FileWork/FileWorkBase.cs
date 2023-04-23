using System;
using System.IO;
using System.Text;

namespace LessonSix.FileWork
{
    public class FileWorkBase
    {
        public string BinaryRead(string readFilePath)
        {
            var fileBytes = new byte[byte.MaxValue];
            var bytesCount = default(int);
            var stringResult = default(string);
            var stringBuilder = new StringBuilder();
            // var strResult = string.Empty;
            using (var stream = new FileStream(readFilePath, FileMode.Open))
            {
                while ((bytesCount = stream.Read(fileBytes, 0, fileBytes.Length)) > 0)
                {
                    // strResult += Encoding.UTF8.GetString(fileBytes);
                    stringResult = Encoding.UTF8.GetString(fileBytes);
                    stringBuilder.Append(stringResult);
                }
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Write data
        /// <paramref name="inputData"/>
        /// to the file specified by the filepath
        /// <paramref name="outputFilePath"/>
        /// </summary>
        /// <param name="outputFilePath"></param>
        /// <param name="inputData"></param>
        public void BinaryWrite(string outputFilePath, string inputData)
        {
            // Get bytes of data to be stored
            var bytesData = Encoding.UTF8.GetBytes(inputData);

            // Write bytes to the file and save
            using (var stream = new FileStream(outputFilePath, FileMode.OpenOrCreate))
            {
                stream.Write(bytesData, 0, bytesData.Length);
            }
        }
    }
}
