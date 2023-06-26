Feature: FileManager
    In order to manage files
    As a user
    I want to be able to retrieve file information

Scenario: File exists
    Given a FileManager
    And a valid file path "TestPayloads/EmptyFileName.file"
    When I call the GetFileInfo method with the file name "TestPayloads/EmptyFileName.file"
    Then it should return a FileInfo object
    And FileCreationTime is not Null
    And FileAccessTime is not Null
    And FileLastWriteTime is not Null
    And FileSize in bytes should be 3

Scenario: File does not exist
    Given a FileManager
    And an invalid file path "nonexistent/file.txt"
    When I call the GetFileInfo method with the invalid filename "nonexistent/file.txt"
    Then it should return null

Scenario: Folder exists
    Given a FileManager
    And a valid folder path "C:/Windows/System32/drivers/etc"
    When I call the GetListOfFileInfoInFolder method with folder path "C:/Windows/System32/drivers/etc"
    Then it should return a list of FileInfo objects

Scenario: Folder does not exist
    Given a FileManager
    And an invalid folder path "nonexistent/folder"
    When I call the GetListOfFileInfoInFolder method with an invalid folder
    Then it should return an empty list
