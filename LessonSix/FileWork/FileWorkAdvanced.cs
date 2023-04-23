using System.IO;

namespace LessonSix.FileWork
{
    // Isn't it easier?)
    public class FileWorkAdvanced
    {
        public string ReadFile(string readFilePath)
        {
            var result = File.ReadAllText(readFilePath);

            return result;
        }

        public void WriteFile(string writeFilePath, string contents)
        {
            File.WriteAllText(writeFilePath, contents);
        }
    }
}
