namespace BikiniBottomCustomers.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      this.JoinEntities = new HashSet<CustomerRestaurant>();
    }

    public int RestaurantId { get; set; }
    public string RestaurantName { get; set; }
    public virtual ICollection<CustomerRestaurant> JoinEntities { get; set; }
  }
}