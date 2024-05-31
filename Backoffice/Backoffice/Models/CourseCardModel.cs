namespace Backoffice.Models;

public class CourseCardModel
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string? Image { get; set; }
    public string Author { get; set; } = null!;
    public bool IsBestseller { get; set; }
    public string? Hours { get; set; }
    public string? LikesInPercent { get; set; }
    public string? NumberOfLikes { get; set; }
    public decimal OriginalPrice { get; set; }
    public decimal DiscountPrice { get; set; }
}
