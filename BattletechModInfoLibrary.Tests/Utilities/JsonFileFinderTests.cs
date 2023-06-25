using NUnit.Framework;
using System;
using BattletechModInfo.Library.Utilities;
using FluentAssertions;

namespace BattletechModInfoLibrary.Tests.Utilities
{
    [TestFixture]
    public class JsonFileFinderTests
    {
        private static readonly string _battletechDataDirectoryPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH";

        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH", "chassisdef_atlas_AS7-D.json", true)]
        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH", "mechdef_atlas_AS7-D.json", true)]
        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH", "movedef_atlas_AS7-D.json", true)]
        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH", "argo.json", true)]
        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH", "MechStatisticsConstants.json", true)]
        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH", "vehiclechassisdef_MANTICORE.json", true)]
        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH", "vehicledef_DEMOLISHER.json", true)]
        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH", "SimGameConstants.json", true)]
        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH", "SimGameSubstitutionConstants.json", true)]
        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH", "pilot_backer_Brown.json", true)]
        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH", "Weapon_Laser_SmallLaserER_0-STOCK.json", true)]
        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH", "Gear_Cockpit_StarCorps_Dalban.json", true)]
        [TestCase("C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH\\Mods\\BT_Extended_3050\\mech", "mechdef_starslayer_STY-3D.json", false)]
        public void FindJsonFiles_ShouldFindSpecificFile(string directoryPath, string expectedFileName, bool searchSubdirectories)
        {
            // Arrange
            JsonFileFinder fileFinder = new JsonFileFinder();

            // Act
            var jsonFiles = fileFinder.FindJsonFiles(directoryPath, searchSubdirectories);

            // Assert
                bool fileExists = jsonFiles.Exists(filePath =>
                Path.GetFileName(filePath) == expectedFileName);
            fileExists.Should().BeTrue();
        }
    }
}
