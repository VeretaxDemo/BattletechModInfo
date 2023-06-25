namespace BattletechModInfo.Library.Utilities;

public class JsonFileFinder
{

    public List<string> FindJsonFiles(string directoryPath, bool searchSubdirectories = true)
    {
        List<string> jsonFiles = new List<string>();
        if (searchSubdirectories)
        {
            FindJsonFilesRecursive(directoryPath, jsonFiles);
        }
        else
        {
            FindJsonFilesInDirectory(directoryPath, jsonFiles);
        }
        return jsonFiles;
    }

    private void FindJsonFilesInDirectory(string directoryPath, List<string> jsonFiles)
    {
        try
        {
            foreach (string filePath in Directory.GetFiles(directoryPath, "*.json"))
            {
                jsonFiles.Add(filePath);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error finding JSON files: {e.Message}");
        }
    }

    private void FindJsonFilesRecursive(string directoryPath, List<string> jsonFiles)
    {
        try
        {
            foreach (string filePath in Directory.GetFiles(directoryPath, "*.json"))
            {
                jsonFiles.Add(filePath);
            }

            foreach (string subdirectory in Directory.GetDirectories(directoryPath))
            {
                FindJsonFilesRecursive(subdirectory, jsonFiles);
            }
        }
        catch (Exception e)
        {
            // Handle any exceptions here, or remove the try-catch block if you want exceptions to propagate.
            Console.WriteLine($"Error finding JSON files: {e.Message}");
        }
    }
}
