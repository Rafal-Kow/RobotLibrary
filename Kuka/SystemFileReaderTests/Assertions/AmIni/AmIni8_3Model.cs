namespace SystemFileReaderTests.Assertions.AmIni;

public static class AmIni8_3Model
{
    public static string Name => @"\\172.19.184.74\KukaRob\K1TUHL415600R01.zip\";

    public static string Config => "All";

  public static int DiskNo => 0;

  public static int LastDisk => 1;

  public static string ID => "39b9b7cd-daa8-4ab1-8051-29f6d05cf526";

    public static DateTime Date => DateTime.Parse("2023.10.16 09:41:53");

    public static string RobName => "K1TUHL415600R01";

  public static int IRSerialNr => 1090126;

  public static string Version => "V8.3.23";

  public static List<string> TechPacks => [
      "BoardPackage",
      "DiagnoseSafety",
      "EthernetKRL",
      "LoadDataDetermination",
      "ProConOS 4-1",
      "Profinet KRC-Nexxt",
      "SafeOperation",
      "VW_Basic",
      "WorkVisual AddOnVKR",
      "WristMamesOffset",
    ];

  public static Dictionary<string, string> TechPacksWithVersion => new(){
      {"BoardPackage", "1.4.0"},
      {"DiagnoseSafety", "2.1.0"},
      {"EthernetKRL", "2.2.8"},
      {"LoadDataDetermination", "6.2.8"},
      {"ProConOS 4-1", "4.1.4"},
      {"Profinet KRC-Nexxt", "3.3.1"},
      {"SafeOperation", "3.2.4"},
      {"VW_Basic", "1.0.0"},
      {"WorkVisual AddOnVKR","1.1.0"},
      {"WristMamesOffset","1.0.1"}
    };
}