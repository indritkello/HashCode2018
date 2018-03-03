using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018
{
  public class InputData
  {
    public CityGrid City;
    //Properties

    public InputData(string filePath)
    {
      //int linesRead = 0;
      int tempCount = 0;
      int rideId = 0;
      using (StreamReader str = new StreamReader(filePath))
      {
        while (!str.EndOfStream)
        {
          if (tempCount == 0)
          {
            string nextLine = str.ReadLine();
            
            string[] lineData = nextLine.Split(' ');
            City = new CityGrid();
            City.Rows = Convert.ToInt32(lineData[0]);
            City.Columns = Convert.ToInt32(lineData[1]);
            City.VehiclesCount = Convert.ToInt32(lineData[2]);
            City.RidesCount = Convert.ToInt32(lineData[3]);
            tempCount = City.RidesCount;
            City.Bonus = Convert.ToInt32(lineData[4]);
            City.Steps = Convert.ToInt32(lineData[5]);
            City.Rides = new List<Ride>();//will be added in following rows
          }
          
          else
          {
            string nextLine = str.ReadLine();

            string[] lineData = nextLine.Split(' ');
            int rid = rideId;
            rideId++;
            int a = Convert.ToInt32(lineData[0]);
            int b = Convert.ToInt32(lineData[1]);
            int x = Convert.ToInt32(lineData[2]);
            int y = Convert.ToInt32(lineData[3]);
            int eS = Convert.ToInt32(lineData[4]);
            int lF = Convert.ToInt32(lineData[5]);
            Ride ride = new Ride(rid,a,b,x,y,eS,lF);
            City.Rides.Add(ride);
            tempCount--;
          }
        }
      }

      

    }
  }
}
