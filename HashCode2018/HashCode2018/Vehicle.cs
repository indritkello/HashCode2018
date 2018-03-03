using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018
{
  public class Vehicle
  {
    public List<Ride> AssignedRides { get; set; }
    //Current Intersaction
    public int Id { get; set; }
    public int x0 { get; set; }
    public int y0 { get; set; }
    public int stepsOfVehicle { get; set; }//will bi added by one
    public Vehicle(int id)
    {
      this.AssignedRides = new List<Ride>();
      x0 = 0;
      y0 = 0;
      stepsOfVehicle = 0;
      Id = id;
    }
    public bool IsCurrentStepEarlier(Ride ride)
    {
      return stepsOfVehicle < ride.EarliestStart;
    }
    public void WaitOneStep()
    {
      stepsOfVehicle++;//for waiting
    }
    public void DriveToStartIntersaction(Ride ride)
    {
      stepsOfVehicle = stepsOfVehicle + Math.Abs(ride.a-x0) + Math.Abs(ride.b-y0);
      x0 = ride.a;
      y0 = ride.b;
    }
    public void DriveToFinishIntersaction(Ride ride)
    {
      stepsOfVehicle += ride.Distance;
      x0 = ride.x;
      y0 = ride.y;
    }
    public void Drive(Ride ride)
    {
      DriveToStartIntersaction(ride);
      while(IsCurrentStepEarlier(ride))
      {
        WaitOneStep();
      }
      DriveToFinishIntersaction(ride);
      AssignedRides.Add(ride);
    }
    public int DistanceTo(Ride ride)
    {
      return Math.Abs(ride.a - x0) + Math.Abs(ride.b - y0);
    }
    
  }
}
