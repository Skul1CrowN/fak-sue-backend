using System.Text.Json.Serialization;

namespace Backend.Models.Response;

public class UserResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
    
    [JsonPropertyName("username")]
    public string Username { get; set; } = null!;
    
    [JsonPropertyName("role")]
    public string? Role { get; set; } = null!;
    
    [JsonPropertyName("student_id")]
    public string StudentId { get; set; } = "";

    [JsonPropertyName("email")]
    public string? Email { get; set; } = "";

    [JsonPropertyName("profile_image")]
    public string? ProfileImage { get; set; }
    
    [JsonPropertyName("banned")]
    public bool Banned { get; set; }
    
    [JsonPropertyName("deleted")]
    public bool Deleted { get; set; }

    public UserResponse(User user)
    {
        this.Id = user.Id;
        this.Name = user.Name;
        this.Username = user.Username;
        this.Role = user.Role;
        this.StudentId = user.StudentId;
        this.Email = user.Email;
        this.ProfileImage = user.ProfileImage;
        
        this.Banned = user.Banned;
        this.Deleted = user.Deleted;
    }
}