using BattletechModInfo.Library.Managers;

namespace BattletechModInfo.Library.Specs.StepDefinitions;

[Binding]
public class FileManagerStepDefinitions
{
    private ScenarioContext _scenarioContext;
    private FileManager _fileManager;
    private string _fileName = "";
    private string _filePath = "";
    private string _invalidFilePath = "";
    private FileInfo? _fileInfoResult;

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

    [Given(@"an invalid file path ""(.*)""")]
    public void GivenAnInvalidFilePath(string invalidFilePath)
    {
        _invalidFilePath = invalidFilePath;
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

}