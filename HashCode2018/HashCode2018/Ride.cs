using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018
{
  public class Ride
  {
    public int RideID { get; set; }
    public int a { get; set; }
    public int b { get; set; }
    public int x { get; set; }
    public int y { get; set; }
    public int Distance { get; set; }
    public int EarliestStart { get; set; }
    public int LatestFinish { get; set; }

    public Ride(int rid,int a1, int b1, int x1, int y1, int eS, int lF)
    {
      RideID = rid;
      a = a1;
      b = b1;
      x = x1;
      y = y1;
      Distance = (x - a) + (y - b);
      EarliestStart = eS;
      LatestFinish = lF;
    }

  }
}
