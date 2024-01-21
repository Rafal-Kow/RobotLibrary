namespace SystemFileReaderTests.Assertions.AmIni;

public static class AmIni8_2Model
{
    public static string Name => @"\\172.19.184.74\KukaRob\K1TUHR115425R01.zip\";

    public static string Config => "All";

  public static int DiskNo => 0;

  public static int LastDisk => 1;

  public static string ID => "c63690b4-1904-450e-afef-eb25007ccf0e";

    public static DateTime Date => DateTime.Parse("2023.10.15 17:37:54");

    public static string RobName => "K1TUHR115425R01";

  public static int IRSerialNr => 617076;

  public static string Version => "V8.2.20 HF04";

  public static List<string> TechPacks => [
      "KRC4 Interbus",
      "LoadDataDetermination",
      "ProConOS 4-1",
      "Profinet KRC-Nexxt",
    ];

  public static Dictionary<string, string> TechPacksWithVersion => new(){
      {"KRC4 Interbus", "1.0.6"},
      {"LoadDataDetermination", "6.1.5"},
      {"ProConOS 4-1", "4.0.2"},
      {"Profinet KRC-Nexxt", "2.2.4"},
    };
}