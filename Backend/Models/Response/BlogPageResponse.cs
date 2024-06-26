using System.Text.Json.Serialization;

namespace Backend.Models.Response;

public class BlogPageResponse
{
    [JsonPropertyName("blog_id")]
    public string BlogId { get; set; } = null!;

    [JsonPropertyName("author")]
    public UserResponse Author { get; set; } = null!;

    [JsonPropertyName("topic")]
    public string Topic { get; set; } = null!;

    [JsonPropertyName("content")]
    public string Content { get; set; } = "";
    
    [JsonPropertyName("max_order")] 
    public int MaxOrder { get; set; } = 1;
    
    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }
    
    [JsonPropertyName("orders")] 
    public List<Order>? Orders { get; set; } = null!;

    [JsonPropertyName("created_date")]
    public DateTime CreatedDate { get; set; }

    [JsonPropertyName("updated_date")]
    public DateTime UpdatedDate { get; set; }
    
    [JsonPropertyName("time")]
    public string Time { get; set; } = null!;

    public BlogPageResponse(Blog blog, User user)
    {
        this.BlogId = blog.Id;
        this.Author = new UserResponse(user);
        this.MaxOrder = blog.MaxOrder;
        this.Orders = blog.Orders;
        this.Timestamp = blog.TimeStamp;
        this.Topic = blog.Topic;
        this.Content = blog.Detail;
        
        this.CreatedDate = blog.CreatedDate;
        this.UpdatedDate = blog.UpdatedDate;
        this.Time = blog.Time;
    }
}