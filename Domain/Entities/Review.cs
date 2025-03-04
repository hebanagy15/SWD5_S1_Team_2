namespace Domain.Entities;

public class Review
{
    public int Id { get; set; }

    [Range(1,5)]
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime ReviewDate { get; set; }

    [ForeignKey("UserId")]
    public int UserId { get; set; }
    public User user { get; set; }
    
    [ForeignKey("ProductId")]
    public int ProductId { get; set; }
    public Product product { get; set; }


}