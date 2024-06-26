using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Backend.Models.Request;

public class CreateBlogRequest
{
    [Required]
    [JsonPropertyName("topic")]
    public string Topic { get; set; } = "";

    [Required]
    [JsonPropertyName("content")]
    public string Content { get; set; } = "";

    [Required]
    [JsonPropertyName("timestamp")]
    public DateTime TimeStamp { get; set; } = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, 12, 0, 0);

    [Required]
    [JsonPropertyName("max_order")]
    public int MaxOrder { get; set; } = 1;

    [JsonPropertyName("orders")] 
    public List<Order>? Orders { get; set; } = new List<Order>();
    [JsonPropertyName("time")]
    public string Time { get; set; } = null!;
}