
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Microsoft.AspNetCore.Identity;

namespace IdentityEndpointError.Models;

public class User : IdentityUser
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(25)]//, Unicode(false)]
    public string FirstName { get; set; }

    [MaxLength(25)]//, Unicode(false)]
    public string? LastName { get; set; }

    [MaxLength(25)]//, Unicode(false)]
    public string? UserName { get; set; }

    [Required, MaxLength(100)]
    public string Email { get; set; }

    //public Roles Role { get; set; } = Roles.User;

    //[Required, MaxLength(100)]
    //public string Salt { get; set; }

    //[Required, MaxLength(100)]
    //public string Hash { get; set; }

    public User Clone() => (User)MemberwiseClone();

    public bool IsSignedIn { get; set; }

    //[IgnoreDataMember]
    //public String Password { get; set; } = string.Empty;
}

public enum Roles { User, PowerUser, Admin }

