namespace BikiniBottomCustomers.Models
{
  public class CustomerRestaurant
  {
    public int CustomerRestaurantId { get; set; }
    public int CustomerId { get; set; }
    public int RestaurantId { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}