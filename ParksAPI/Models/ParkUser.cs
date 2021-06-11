using System;
using System.Collections.Generic;

namespace ParksAPI.Models
{
  public class ParkUser
  {
    // decide if this is the approach I wanna take with unique and secure ids, or should it be simplified down:
    // public ParkUser()
    // {
    //   ParkUserId = Guid.NewGuid().ToString();
    // }
    // public string ParkUserId { get; set; }

    public int ParkUserId { get; set; }
    public string Name { get; set; }
    public string Review { get; set; }
  }
}