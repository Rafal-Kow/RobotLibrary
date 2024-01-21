using System.Reflection;

namespace SystemFileReaderTests;

public static class FileHelper
{
  public static List<string> ReadFiletoList(string path) =>
    File.ReadAllLines(path).ToList();

  public static string GetFilePath(string relativePath, string fileName) =>
    Directory.GetFiles(GetTestPath(relativePath)).Any(p => p.EndsWith(fileName))
      ? Directory.GetFiles(GetTestPath(relativePath)).First(p => p.EndsWith(fileName))
      : "";


  private static string GetTestPath(string relativPath)
  {
    var codeBaseUrl = new Uri(Assembly.GetExecutingAssembly().Location);
    var codeBasePath = Uri.UnescapeDataString(codeBaseUrl.AbsolutePath);
    var dirPath = Path.GetDirectoryName(codeBasePath);
    return Path.Combine(dirPath, "TestFiles", relativPath);
  }
}
