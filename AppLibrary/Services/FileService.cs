using AppLibrary.Interfaces;
using System.Diagnostics;

namespace AppLibrary.Services;

internal class FileService : IFileService
{
    public string GetContent(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
        }


        catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }
    

    public bool SaveContent(string filePath, string content)
    {
       try
        {
            using var sw= new StreamWriter(filePath);
            sw.Write(content);
            return true;
        }
            catch (Exception ex) {Debug.WriteLine(ex.Message); }
            return false;
    }
}
