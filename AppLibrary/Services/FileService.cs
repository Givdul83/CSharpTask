using AppLibrary.Interfaces;
using System.Diagnostics;
using System.IO;


namespace AppLibrary.Services;

public class FileService : IFileService
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


        catch (Exception ex) { Debug.WriteLine("FileService - GetContent" + ex.Message); }
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
            catch (Exception ex) {Debug.WriteLine("FileService - SaveContent"+ ex.Message); }
            return false;
    }
}
