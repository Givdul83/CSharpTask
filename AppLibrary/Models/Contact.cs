﻿using AppLibrary.Interfaces;

namespace AppLibrary.Models;

public class Contact : IContact
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; }= null!;
    public string StreetAddress { get; set; } = null!;
    public string City { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public Guid Id { get; set; } = Guid.NewGuid();
}
