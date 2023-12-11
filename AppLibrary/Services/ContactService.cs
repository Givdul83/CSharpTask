using AppLibrary.Interfaces;

namespace AppLibrary.Services;

public class ContactService : IContactService

{
    /// <summary>
    /// Add a contact to the contactlist
    /// </summary>
    /// <param name="contact">a Contact of type IContact</param>
    /// <returns>Return true if succesfull, false if failed or contact already exists</returns>
    
    public bool AddContactToList(IContact contact)
    {
        return true;
    }

    public IContact GetContactFromList(string email)
    {
        return null!;
    }

    public IEnumerable<IContact> GetContactsFromList()
    {
        return null!;
    }

    public bool RemoveContactFromList(IContact contact)
    {
        return true;
    }

    public bool UpdateContact(IContact contact)
    {
        return true;
    }
}
