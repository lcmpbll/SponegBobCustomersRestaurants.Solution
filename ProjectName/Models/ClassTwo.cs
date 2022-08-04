namespace ProjectName.Models
{
  public class ClassTwo
  {
    public ClassTwo()
    {
      this.ClassOnes = new HashSet<ClassOne>();
    }

    public int ClassTwoId { get; set; }
    public virtual ICollection<ClassOne> ClassOnes { get; set; }
  }
}