Feature: FileManager

A file manager for getting file information and managing their attributes


@FileManager
Scenario: Empty File still has file info
	Given A path to a folder
	And the file name is
	When the combined path is checked
	Then the file info name should exist