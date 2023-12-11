

namespace AppLibrary.Interfaces;

public interface IContactService
{
    bool AddContactToList(IContact contact);
    IEnumerable<IContact> GetContactsFromList();

    IContact GetContactFromList(string email);

    bool RemoveContactFromList(string email);

    bool UpdateContact(IContact contact);
}
