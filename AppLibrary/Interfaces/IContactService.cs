

namespace AppLibrary.Interfaces;

public interface IContactService
{
    bool AddContactToList(IContact contact);
    IEnumerable<IContact> GetContactsFromList();

    IContact GetContactFromList(string email);

    bool RemoveContactFromList(IContact contact);

    bool UpdateContact(IContact contact);
}
