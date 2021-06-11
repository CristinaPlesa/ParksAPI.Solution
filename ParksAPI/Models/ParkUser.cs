using System;
using System.Collections.Generic;

namespace ParksAPI.Models
{
  public class ParkUser
  {
    public ParkUser()
    {
      ParkUserId = Guid.NewGuid().ToString();
    }

    public string ParkUserId { get; set; }
    public string Name { get; set; }
    public string Review { get; set; }
  }
}