using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018
{
  public class CityGrid
  {
    public int Rows { get; set; }
    public int Columns { get; set; }
    public List<Vehicle> Vehicles { get; set; }
    public List<Ride> Rides { get; set; }
    public int VehiclesCount { get; set; }
    public int RidesCount { get; set; }
    public int Bonus { get; set; }
    public int Steps { get; set; }
    public bool HasFreeCars()
    {
      int numberOfFreeCars = Vehicles.Where(v => v.AssignedRides.Count == 0).Count();
      return numberOfFreeCars > 0;

    }
  }
}
