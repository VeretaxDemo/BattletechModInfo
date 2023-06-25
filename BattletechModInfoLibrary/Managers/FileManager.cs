namespace BattletechModInfo.Library.Managers;

public class FileManager
{
    public string CurrentFilePath { get; set; }

    public FileInfo GetFileInfo(string filePath)
    {
        if (File.Exists(filePath))
        {
            return new FileInfo(filePath);
        }
        else
        {
            return null;
        }
    }
}