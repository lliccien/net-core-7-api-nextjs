using System.Text.Json.Serialization;

namespace products_app.Models;

public class User
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    [JsonIgnore ]
    public byte[] StoredSalt { get; set; } = new byte[32];
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

}
