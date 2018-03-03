using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// @auth INDRIT KELLO
/// @team "DifDevs"
/// @totalScore 17,883,524
/// </summary>
namespace HashCode2018
{
  class Program
  {
    static void Main(string[] args)
    {
      //taking necessary data related to city and rides
      string filePath = "c_no_hurry.txt";
      InputData data = new InputData(filePath);
      data.City.Vehicles = new List<Vehicle>();
      //let's 'build' the vehicles as objects 
      for (int i = 0; i< data.City.VehiclesCount; i++)
      {
        data.City.Vehicles.Add(new Vehicle(i));
      }
      int id = 0;
      //firstly let's give a ride to each vehicle
      while (data.City.HasFreeCars())
      {
        data.City.Vehicles[id].Drive(data.City.Rides[id]);
        id++;
      }
      int j = id;
      //for the remaining rides we will choose the vehicles closely to the starting point of the ride
      while (j < data.City.RidesCount)
      {
        int index = WhichIsCloser(data.City.Vehicles, data.City.Rides[j]);
        data.City.Vehicles[index].Drive(data.City.Rides[j]);
        j++;
      }

      //writing output
      using (StreamWriter sw = new StreamWriter("output.txt"))
      {
        
        foreach(var v in data.City.Vehicles)
        {
          string line = "";
          line += v.AssignedRides.Count + " ";
          foreach(var r in v.AssignedRides)
          {
            line += r.RideID + " ";
          }
          sw.WriteLine(line);
        }
        
        sw.Flush();
        sw.Close();
      }

    }
    public static int WhichIsCloser(List<Vehicle> vehicles,Ride ride)
    {
      return vehicles.OrderBy(v => v.DistanceTo(ride)).First().Id;
    }
  }
}
