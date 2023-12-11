using AppLibrary.Interfaces;
using System.Diagnostics;

namespace AppLibrary.Services;

internal class FileService : IFileService
{
    private string filePath= @"c:\csharptask\contacts.json";

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
