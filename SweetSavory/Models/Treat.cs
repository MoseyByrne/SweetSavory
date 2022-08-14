using System.Collections.Generic;

namespace SweetSavory.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();

      // this.JoinEntities2 = new HashSet<TreatSpecialty>();

    }

    public int TreatId { get; set; }

    public string Name { get; set; }

    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}
