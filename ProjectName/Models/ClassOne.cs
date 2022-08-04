namespace ProjectName.Models
{
  public class ClassOne
  {
    public int ClassOneId { get; set; }
    public int ClassTwo { get; set; }
    public virtual ClassTwo ClassTwo { get; set; }
  }
}