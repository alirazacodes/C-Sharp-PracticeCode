using System.IO;

namespace InterfacesAndExtensibility
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
            using (var streamWriter = new StreamWriter(_path, true))
            {
                Log(message, "ERROR");
                //streamWriter.Dispose();
            }
        }

        public void LogInfo(string message)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                Log(message, "ERROR");
                //streamWriter.Dispose();
            }
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
                //streamWriter.Dispose();
            }
        }
    }
}