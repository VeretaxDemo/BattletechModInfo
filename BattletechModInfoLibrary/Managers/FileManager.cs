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

    public List<FileInfo> GetListOfFileInfoInFolder(string folderPath)
    {
        List<FileInfo> fileInfos = new List<FileInfo>();

        if (Directory.Exists(folderPath))
        {
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                fileInfos.Add(fileInfo);
            }
        }

        return fileInfos;
    }
}