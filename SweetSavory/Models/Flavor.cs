using System;
using System.Collections.Generic;

namespace SweetSavory.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }

    public string Description { get; set; }

    public DateTime Birthdate { get; set; }

    public virtual ICollection<TreatFlavor> JoinEntities { get; }
  }
}
