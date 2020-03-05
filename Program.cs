using System;
using System.Collections.Generic;

namespace Planner {
    class Program {
        static void Main (string[] args) {
            Building cityHospital = new Building ("7201 Charlotte Pike");
            cityHospital.Width = 76.3;
            cityHospital.Depth = 43.5;
            cityHospital.Stories = 4;

            cityHospital.Construct ();
            cityHospital.Purchase ("Steve");

            cityHospital.AddDevelopment ();

            Building cityBank = new Building ("2706 Acklen Avenue");
            cityBank.Width = 85.4;
            cityBank.Depth = 26.4;
            cityBank.Stories = 6;

            cityBank.Construct ();
            cityBank.Purchase ("Adam");

            cityBank.AddDevelopment ();

            Building cityHall = new Building ("150 2nd Avenue North");
            cityHall.Width = 78.3;
            cityHall.Depth = 46.7;
            cityHall.Stories = 3;

            cityHall.Construct ();
            cityHall.Purchase ("Rose");

            cityHall.AddDevelopment ();

            Building cityGrocery = new Building ("2807 22nd Avenue South");
            cityGrocery.Width = 98.3;
            cityGrocery.Depth = 34.2;
            cityGrocery.Stories = 1;

            cityGrocery.Construct ();
            cityGrocery.Purchase ("Brenda");

            cityGrocery.AddDevelopment ();

            Building citySchool = new Building ("1506 Elmwood Avenue");
            citySchool.Width = 99.2;
            citySchool.Depth = 76.5;
            citySchool.Stories = 2;

            citySchool.Construct ();
            citySchool.Purchase ("Jasmine");

            citySchool.AddDevelopment ();

        }
    }
}