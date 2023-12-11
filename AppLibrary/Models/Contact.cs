using AppLibrary.Interfaces;

namespace AppLibrary.Models;

public class Contact : IContact
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int PhoneNumber { get; set; }
    public string StreetAddress { get; set; } = null!;
    public string City { get; set; } = null!;
    public int PostalCode { get; set; }
    public Guid Id { get; set; } = Guid.NewGuid();
}
