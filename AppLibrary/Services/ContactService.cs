using AppLibrary.Interfaces;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;
using System.Collections;

namespace AppLibrary.Services;

public class ContactService : IContactService

{
    private readonly IFileService _fileService;



    private List<IContact> _contacts = [];
    private readonly string _filePath = @"c:\csharptask\contacts.json";

   

    public bool AddContactToList(IContact contact)
    {
        try
        {
            GetContactsFromList();

            if (!_contacts.Any(x => x.Email == contact.Email))
            {
                _contacts.Add(contact);

                string json = JsonConvert.SerializeObject(_contacts, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });

                var result = _fileService.SaveContent(_filePath, json);


                return result;
        } 
        }
        catch (Exception ex) { Debug.WriteLine("ContactService- AddContactToList"+ ex.Message); }
        return false;
    }

    public IContact GetContactFromList(string email)
    {
        try
        {
            GetContactsFromList();
            var contact = _contacts.FirstOrDefault(x => x.Email == email);
            return contact ??= null!;

            
        }
        catch (Exception ex) { Debug.WriteLine("ContactService- GetContactToList" + ex.Message); }
        return null!;
    }

    public IEnumerable<IContact> GetContactsFromList()
    {
        try
        {
            var content = _fileService.GetContent(_filePath);

            if (!string.IsNullOrEmpty(content))
            {
                _contacts = JsonConvert.DeserializeObject<List<IContact>>(content, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All })! ;
                return _contacts;
            }

           
        }
        catch (Exception ex) { Debug.WriteLine("ContactService- AddContactsToList" + ex.Message); }
        return null!;
    }

    public bool RemoveContactFromList(string email)
    {
        try
        {
            GetContactsFromList();
            var contact = _contacts.FirstOrDefault(x => x.Email == email);

            if (contact != null)
            {
                _contacts.Remove(contact);
                return true;
            }
            else 
            {
                return false;
            }
        }
        catch (Exception ex) { Debug.WriteLine("ContactService- RemoveContactToList" + ex.Message); }
        return false;
    }

    public bool UpdateContact(IContact contact)
    {
        try
        {

            return true;
        }
        catch (Exception ex) { Debug.WriteLine("ContactService- UpdateContact" + ex.Message); }
        return false;
    }
}
