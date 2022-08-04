using System.Collections.Generic;

namespace BikiniBottomCustomers.Models
{
  public class Customer
  {
    public Customer()
    {
      this.JoinEntities = new HashSet<CustomerRestaurant>();
    }
    public int CustomersId { get; set; }
    public string Name { get; set; }
    public virtual IColleection<CustomerRestaurant> JoinEntites { get; }
  }
}