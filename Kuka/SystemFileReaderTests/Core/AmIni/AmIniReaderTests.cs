using Robot.Kuka.SystemFileReader.RootFiles;
using SystemFileReaderTests.Assertions.AmIni;

namespace SystemFileReaderTests.core.AmIni;

public class AmIniReaderTests
{

  [Fact]
  public void GetRobotNameWhenAmIniFileIsEmpty_ReturnsEmptyString() =>
      new ReadAmIni([]).GetRobotName().Should().BeEmpty();

  public static IEnumerable<object[]> RobNameData =>
    [
      ["8_2", AmIni8_2Model.RobName],
      ["8_3", AmIni8_3Model.RobName]
    ];

  [Theory]
  [MemberData(nameof(RobNameData))]
  public void GetRobotNameTest(string version, string robName) =>
    new ReadAmIni(GetAmIniContent(version))
      .GetRobotName().Should().Be(robName);


  public static IEnumerable<object[]> NameData =>
      [
        ["8_2", AmIni8_2Model.Name],
        ["8_3", AmIni8_3Model.Name]
      ];

  [Theory]
  [MemberData(nameof(NameData))]
  public void GetNameTest(string version, string name) =>
     new ReadAmIni(GetAmIniContent(version))
      .GetName().Should().Be(name);


  public static IEnumerable<object[]> ConfigData =>
      [
        ["8_2", AmIni8_2Model.Config],
        ["8_3", AmIni8_3Model.Config]
      ];

  [Theory]
  [MemberData(nameof(ConfigData))]
  public void GetConfigTest(string version, string config) =>
    new ReadAmIni(GetAmIniContent(version))
      .GetConfig().Should().Be(config);


  public static IEnumerable<object[]> DiskNoData =>
      [
        ["8_2", AmIni8_2Model.DiskNo],
        ["8_3", AmIni8_3Model.DiskNo]
      ];

  [Theory]
  [MemberData(nameof(DiskNoData))]
  public void GetDiskNoTest(string version, int diskNo) =>
    new ReadAmIni(GetAmIniContent(version))
      .GetDiskNo().Should().Be(diskNo);


  public static IEnumerable<object[]> LastDiskData =>
      [
        ["8_2", AmIni8_2Model.LastDisk],
        ["8_3", AmIni8_3Model.LastDisk]
      ];

  [Theory]
  [MemberData(nameof(LastDiskData))]
  public void GetLastDiskTest(string version, int lastDisk) =>
    new ReadAmIni(GetAmIniContent(version))
      .GetLastDisk().Should().Be(lastDisk);


  public static IEnumerable<object[]> IdData =>
      [
        ["8_2", AmIni8_2Model.ID],
        ["8_3", AmIni8_3Model.ID]
      ];

  [Theory]
  [MemberData(nameof(IdData))]
  public void GetIdTest(string version, string id) =>
    new ReadAmIni(GetAmIniContent(version))
      .GetId().Should().Be(id);


  public static IEnumerable<object[]> DateData =>
      [
        ["8_2", AmIni8_2Model.Date],
        ["8_3", AmIni8_3Model.Date]
      ];

  [Theory]
  [MemberData(nameof(DateData))]
  public void GetDateTest(string version, DateTime date) =>
    new ReadAmIni(GetAmIniContent(version))
      .GetDate().Should().Be(date);


  public static IEnumerable<object[]> IrSerialNumberData =>
      [
        ["8_2", AmIni8_2Model.IRSerialNr],
        ["8_3", AmIni8_3Model.IRSerialNr]
      ];

  [Theory]
  [MemberData(nameof(IrSerialNumberData))]
  public void GetIrSerialNrTest(string version, int iRSerialNr) =>
    new ReadAmIni(GetAmIniContent(version))
      .GetIRSerialNr().Should().Be(iRSerialNr);


  public static IEnumerable<object[]> VersionData =>
      [
        ["8_2", AmIni8_2Model.Version],
        ["8_3", AmIni8_3Model.Version]
      ];

  [Theory]
  [MemberData(nameof(VersionData))]
  public void GetVersionTest(string version, string archiveVersion) =>
    new ReadAmIni(GetAmIniContent(version))
      .GetVersion().Should().Be(archiveVersion);


  public static IEnumerable<object[]> TechPackData =>
      [
        ["8_2", AmIni8_2Model.TechPacks],
        ["8_3", AmIni8_3Model.TechPacks]
      ];

  [Theory]
  [MemberData(nameof(TechPackData))]
  public void GetTechPacksTest(string version, List<string> techPacks) =>
    new ReadAmIni(GetAmIniContent(version))
      .GetTechPacks().Should().BeEquivalentTo(techPacks);


  public static IEnumerable<object[]> TechPacksWithVersionData =>
      [
        ["8_2", AmIni8_2Model.TechPacksWithVersion],
        ["8_3", AmIni8_3Model.TechPacksWithVersion]
      ];

  [Theory]
  [MemberData(nameof(TechPacksWithVersionData))]
  public void GetTechPacksWithVersionsTest(string version, Dictionary<string, string> techPacksWithVersion) =>
    new ReadAmIni(GetAmIniContent(version))
      .GetTechPacksWithVersions()
      .Should().BeEquivalentTo(techPacksWithVersion);

  private List<string> GetAmIniContent(string kukaVersion) =>
    FileHelper.ReadFiletoList(
      FileHelper.GetFilePath(kukaVersion, "am.ini"));
}
