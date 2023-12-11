namespace AppLibrary.Interfaces;

internal interface IFileService
{
    bool SaveContent(string filePath,  string content);
    string GetContent(string filePath);
}
