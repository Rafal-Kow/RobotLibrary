using System.Globalization;

namespace Robot.Kuka.SystemFileReader.RootFiles;

public class ReadAmIni(IEnumerable<string> amIniContent)
{
    private readonly List<string> amIniContent = amIniContent.ToList();

    public string GetRobotName() =>
         GetValue("RobName");

    public string GetName() =>
         GetValue("Name");

    public string GetConfig() =>
        GetValue("Config");

    public int GetDiskNo() =>
        int.Parse(GetValue("DiskNo"));

    public int GetLastDisk() =>
        int.Parse(GetValue("LastDisk"));

    public string GetId() =>
        GetValue("ID");

    public DateTime GetDate() =>
        DateTime.ParseExact(GetValue("Date"),
            "yyyy-M-dd_H-mm-ss",
            CultureInfo.InvariantCulture);

    public int GetIRSerialNr() =>
        int.Parse(GetValue("IRSerialNr"));

    public string GetVersion() =>
        GetValue("Version");

    public IEnumerable<string> GetTechPacks() =>
        GetTechPacksList();

    public Dictionary<string, string> GetTechPacksWithVersions() =>
        GetTechPacksVersions(GetTechPacksList().ToList());

    private string GetValue(string keyWord)
    {
        var line = GetLine(keyWord);

        if (line.Length == 0)
            return "";

        return line[(line.IndexOf('=') + 1)..];
    }

    private string GetLine(string searchText) =>
        amIniContent.Any(p => p.StartsWith(searchText)) switch
        {
            false => "",
            _ => amIniContent.DefaultIfEmpty("").Single(p =>
                     p.StartsWith(searchText))
        };

    private IEnumerable<string> GetTechPacksList()
    {
        var output = GetValue("TechPacks");

        if (output.EndsWith('|'))
        {
            return output.Remove(output.LastIndexOf('|')).Split('|');
        }

        return output.Split('|');
    }

    private Dictionary<string, string> GetTechPacksVersions(List<string> techPacks)
    {
        var output = new Dictionary<string, string>();

        foreach (string techpack in techPacks)
        {
            output.Add(techpack, GetValue(techpack));
        }

        return output;
    }
}
