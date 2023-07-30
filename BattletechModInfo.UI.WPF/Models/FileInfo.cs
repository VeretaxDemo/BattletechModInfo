namespace BattletechModInfo.UI.WPF.Models;

public class FileInfo
{
    public string FileName { get; set; }
    public string FileSize { get; set; }

    public string FullFilePath { get; set; }
    public string BaseFilePath { get; set; }


    public string FilePath
    {
        get
        {
            // Check if the FullFilePath starts with the BaseFilePath
            if (FullFilePath.StartsWith(BaseFilePath))
            {
                // Get the part of FullFilePath after the BaseFilePath
                string relativePath = FullFilePath.Substring(BaseFilePath.Length);

                // Remove the leading directory separator character (if any)
                if (relativePath.StartsWith("\\") || relativePath.StartsWith("/"))
                {
                    relativePath = relativePath.Substring(1);
                }

                return relativePath;
            }
            else
            {
                // If FullFilePath doesn't start with BaseFilePath, return the FullFilePath as is
                return FullFilePath;
            }
        }
    }

    public string RelativeFilePath
    {
        get
        {
            char separator = System.IO.Path.DirectorySeparatorChar;
            string basePath = FilePath.TrimEnd(separator);
            string fileName = System.IO.Path.GetFileName(basePath);
            int fileNameIndex = basePath.LastIndexOf(fileName);
            if (fileNameIndex >= 0)
            {
                return basePath.Remove(fileNameIndex).TrimEnd(separator);
            }

            // If the FilePath does not contain the filename, return the basePath as is
            return basePath;

        }
    }

}