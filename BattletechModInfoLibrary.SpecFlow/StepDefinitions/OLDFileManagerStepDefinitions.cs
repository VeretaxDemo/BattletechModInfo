//using BattletechModInfo.Library.Managers;

//namespace BattletechModInfo.Library.Specs.StepDefinitions;

//public class FileManagerStepDefinitions
//{
//    private ScenarioContext _scenarioContext;
//    private FileManager _fileManager;
//    private string _fileName = "";
//    private string _filePath = "";
//    private string _invalidFilePath = "";
//    private FileInfo? _fileInfoResult;

//    public OLDFileManagerStepDefinitions(ScenarioContext scenarioContext)
//    {
//        _scenarioContext = scenarioContext;
//    }

//    [Given(@"a FileManager")]
//    public void GivenAFileManager()
//    {
//        _fileManager = new FileManager();
//    }

//    [Given(@"a valid file path ""(.*)""")]
//    public void GivenAValidFilePath(string filePath)
//    {
//        _filePath = filePath;
//        _fileManager.CurrentFilePath = _filePath;
//    }

//    [Given(@"an invalid file path ""(.*)""")]
//    public void GivenAnInvalidFilePath(string _invalidFilePath)
//    {
//        _invalidFilePath = _invalidFilePath;
//    }

//    [When(@"I call the GetFileInfo method")]
//    public void WhenICallTheGetFileInfoMethod(string fileName)
//    {
//        _fileInfoResult = _fileManager.GetFileInfo(fileName);
//    }

//    [Then(@"it should return a FileInfo object")]
//    public void ThenItShouldReturnAFileInfoObject()
//    {
//        _fileInfoResult.Should().NotBeNull();
//        _fileInfoResult.Should().BeOfType<FileInfo>();
//    }

//    [Then(@"it should return null")]
//    public void ThenItShouldReturnNull()
//    {
//        _fileInfoResult.Should().BeNull();
//    }
//}