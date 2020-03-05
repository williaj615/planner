using System;
using System.Collections.Generic;

namespace Planner {

  public class Building {
    //Fields
    private string _designer = "Jasmine Williams";
    private DateTime _dateConstructed;
    private string _address;
    private string _owner;

    //Properties

    public int Stories { get; set; } = 3;
    public double Width { get; set; } = 145.5;
    public double Depth { get; set; } = 123.3;

    //Computed Property
    public double volume {
      get {
        return (Width * Depth) * (3 * Stories);
      }
    }

    //Constructor
    public Building (string address) {

      _address = address;

    }

    //Methods
    public void Construct () {
      _dateConstructed = DateTime.Now;
    }

    public void Purchase (string name) {
      _owner = name;
    }

    public void AddDevelopment () {
      Console.WriteLine ($"{_address}");
      Console.WriteLine ($"-----------------------");
      Console.WriteLine ($"Designed by {_designer}");
      Console.WriteLine ($"Constructed on {_dateConstructed}");
      Console.WriteLine ($"Owned by {_owner}");
      Console.WriteLine ($"{volume} cubic meters of space");
    }
  }
}