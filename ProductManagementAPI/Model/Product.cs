using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(1000)]
        public required string Title { get; set; }

        [MaxLength(5000)]
        public string? Description { get; set; }

        [Required]
        [RegularExpression("^(S|M|L|XL)$", ErrorMessage = "Allowed values: S, M, L, XL")]
        public required string EstimatedComplexity { get; set; }

        [Required]
        [RegularExpression("^(New|Active|Closed|Abandoned)$", ErrorMessage = "Allowed values: New, Active, Closed, Abandoned")]
        public required string Status { get; set; }

        public DateTime? TargetCompletionDate { get; set; }
        public DateTime? ActualCompletionDate { get; set; }
    }
}
