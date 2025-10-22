using System.ComponentModel.DataAnnotations;

namespace ControllerAPI;

public class Order
{
    [Required]
    public required string OrderNumber { get; set; }
}
