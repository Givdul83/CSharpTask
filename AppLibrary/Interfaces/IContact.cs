

namespace AppLibrary.Interfaces;

public interface IContact
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    int PhoneNumber { get; set; }
    string StreetAddress { get; set; }
    string City { get; set; }
    int PostalCode {  get; set; } 
    Guid Id {  get; set; }
   
}
