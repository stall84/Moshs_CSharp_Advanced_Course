using System.IO;

namespace Interfaces_Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");   
               
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)                    // To maintain DRY code principles we'll make a private method which we'll then call from the Info/Error/(specific) methods passing messageType as string.
        {
            using (var streamWriter = new StreamWriter(_path, true))            // 'using' keyword directs the compiler to explicitly close/finish the stream once it's done. Freeing up those resources
            {
                streamWriter.WriteLine($"{messageType}: {message}");
            }
        }
    }
}
