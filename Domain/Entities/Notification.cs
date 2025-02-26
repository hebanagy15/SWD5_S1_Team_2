namespace Domain.Entities;

public class Notification
{
    public int Id { get; set; }
   
    public int UserId { get; set; }
   
    public string? URL { get; set; }
    
    public string Title { get; set; }
    
    public string Message { get; set; }
    public bool? IsRead { get; set; }
    
    public DateTime? CreatedAt { get; set; }
    
    public DateTime? ReadAt { get; set; }
    
    
    
}