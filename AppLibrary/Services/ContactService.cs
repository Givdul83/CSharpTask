using AppLibrary.Interfaces;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;
using System.Collections;

namespace AppLibrary.Services;

public class ContactService : IContactService

{
    private readonly IFileService _fileService = new FileService();
    private List<IContact> _contacts = [];
    private readonly string _filePath = @"c:\chsarptask\contacts.json";

    public bool AddContactToList(IContact contact)
    {
        try
        {
            if (!_contacts.Any(x => x.Email == contact.Email))
            {
                _contacts.Add(contact);

                string json = JsonConvert.SerializeObject(contact, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });

                var result = _fileService.SaveContent(_filePath, json);


                return result;
        } 
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }

    public IContact GetContactFromList(string email)
    {
        try
        {

            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }

    public IEnumerable<IContact> GetContactsFromList()
    {
        try
        {
            var content = _fileService.GetContent(_filePath);

            if (!string.IsNullOrEmpty(content))
            {
                _contacts = JsonConvert.DeserializeObject<List<IContact>>(content, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All })! ;
            }

            return content;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null;
    }

    public bool RemoveContactFromList(IContact contact)
    {
        try
        {

            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }

    public bool UpdateContact(IContact contact)
    {
        try
        {

            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
}
