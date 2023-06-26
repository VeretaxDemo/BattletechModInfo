using BattletechModInfo.Library.Managers;

namespace BattletechModInfo.Library.Specs.StepDefinitions;

[Binding]
public class FileManagerStepDefinitions
{
    private ScenarioContext _scenarioContext;
    private FileManager _fileManager;
    private string _fileName = "";
    private string _filePath = "";
    private string _folderPath = "";
    private string _invalidFilePath = "";
    private string _invalidFolderPath = "";
    private FileInfo? _fileInfoResult;
    private List<FileInfo> _listOfFileInfosResult;

    public FileManagerStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given(@"a FileManager")]
    public void GivenAFileManager()
    {
        _fileManager = new FileManager();
    }

    [Given(@"a valid file path ""(.*)""")]
    public void GivenAValidFilePath(string filePath)
    {
        _filePath = filePath;
        _fileManager.CurrentFilePath = _filePath;
    }

    [Given(@"a valid folder path ""(.*)""")]
    public void GivenAValidFolderPath(string folderPath)
    {
        _folderPath = folderPath;
    }

    [Given(@"an invalid file path ""(.*)""")]
    public void GivenAnInvalidFilePath(string invalidFilePath)
    {
        _invalidFilePath = invalidFilePath;
    }

    [Given(@"an invalid folder path ""(.*)""")]
    public void GivenAnInvalidFolderPath(string invalidFolderPath)
    {
        _invalidFolderPath = invalidFolderPath;
    }

    [When(@"I call the GetFileInfo method with the file name ""(.*)""")]
    public void WhenICallTheGetFileInfoMethodWith(string filename)
    {
        _fileInfoResult = _fileManager.GetFileInfo(filename);
    }

    [When(@"I call the GetFileInfo method with the invalid filename ""(.*)""")]
    public void WhenICallTheGetFileInfoMethodWithTheInvalidFilename(string invalidFilePath)
    {
        _fileManager.GetFileInfo(invalidFilePath);
    }

    [When(@"I call the GetListOfFileInfoInFolder method with folder path ""([^""]*)""")]
    public void WhenICallTheGetListOfFileInfoInFolderMethodWithFolderPath(string folderPath)
    {
        _listOfFileInfosResult = _fileManager.GetListOfFileInfoInFolder(folderPath);
    }


    [When(@"I call the GetListOfFileInfoInFolder method with an invalid folder")]
    public void WhenICallTheGetListOfFileInfoInFolderMethodWithAnInvalidFolder()
    {
        _listOfFileInfosResult = _fileManager.GetListOfFileInfoInFolder(_invalidFolderPath);
    }

    [Then(@"it should return a FileInfo object")]
    public void ThenItShouldReturnAFileInfoObject()
    {
        _fileInfoResult.Should().NotBeNull();
        _fileInfoResult.Should().BeOfType<FileInfo>();
    }

    [Then(@"it should return null")]
    public void ThenItShouldReturnNull()
    {
        _fileInfoResult.Should().BeNull();
    }

    [Then(@"FileCreationTime is not Null")]
    public void ThenFileCreationTimeIsNotNull()
    {
        _fileInfoResult.CreationTime.Ticks.Should().BeGreaterThanOrEqualTo(DateTime.MinValue.Ticks);
    }

    [Then(@"FileAccessTime is not Null")]
    public void ThenFileAccessTimeIsNotNull()
    {
        _fileInfoResult.LastAccessTime.Ticks.Should().BeGreaterThanOrEqualTo(DateTime.MinValue.Ticks);
    }

    [Then(@"FileLastWriteTime is not Null")]
    public void ThenFileLastWriteTimeIsNotNull()
    {
        _fileInfoResult.LastWriteTime.Ticks.Should().BeGreaterThanOrEqualTo(DateTime.MinValue.Ticks);
    }

    [Then(@"FileSize in bytes should be (.*)")]
    public void ThenFileSizeInBytesShouldBe(int fileSize)
    {
        _fileInfoResult.Length.Should().Be(fileSize);
    }

    [Then(@"it should return a list of FileInfo objects")]
    public void ThenItShouldReturnAListOfFileInfoObjects()
    {
        _listOfFileInfosResult.Should().NotBeNull();
        _listOfFileInfosResult.Should().BeOfType<List<FileInfo>>();
        _listOfFileInfosResult.Count.Should().BeGreaterThan(1);
    }

    [Then(@"it should return an empty list")]
    public void ThenItShouldReturnAnEmptyList()
    {
        _listOfFileInfosResult.Should().BeEmpty();
    }
}