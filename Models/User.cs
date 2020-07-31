using System.Collections.Generic;

namespace Models
{
  public class User
  {
    public int Id { get; set; }

    public string Username { get; set; }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }

    public string Name { get; set; }
    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    // EF Core Relationship: 
    // FoodTruck (many) and User (many) Models 
    public ICollection<FoodTruckUser> FoodTruckUsers { get; set; }
  }
}