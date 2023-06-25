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

Scenario: File does not exist
    Given a FileManager
    And an invalid file path "nonexistent/file.txt"
    When I call the GetFileInfo method with the invalid filename "nonexistent/file.txt"
    Then it should return null
