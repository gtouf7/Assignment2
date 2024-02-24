using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        // The J1 problem for this method was the J1 problem that was shown on the assignment 2 sheet as an example
        // MENU
        // (item: option:calories)
        // burgers: 1:461, 2:431, 3:420, 4:0
        // drinks: 1:130, 2:160, 3:118, 4:0
        // sides: 1:100, 2:57, 3:70, 4:0
        // dessert: 1:167, 2:266, 3:75, 4:0
        // ------------------------------------
        // <summary>
        // receives four integers 1-4 matching the menu items and calculates the total calories of the order
        //</summary>
        //<returns>
        // returns an integer representing the total calories.
        //<example>
        // api/J1/Menu/1/3/1/1
        // calories = 461 + 118 + 100 + 167 = 846
        // "Your total calorie count is 846."
        //</example>

        public string Menu(int burger, int drink, int side, int dessert)
        {
            //Burgers Menu
            List<int> Burgers = new List<int>();
            Burgers.Add(461);
            Burgers.Add(431);
            Burgers.Add(420);
            Burgers.Add(0);

            //Drinks Menu
            List<int> Drinks = new List<int>();
            Drinks.Add(130);
            Drinks.Add(160);
            Drinks.Add(118);
            Drinks.Add(0);

            //Sides Menu
            List<int> Sides = new List<int>();
            Sides.Add(100);
            Sides.Add(57);
            Sides.Add(70);
            Sides.Add(0);

            //Desserts Menu
            List<int> Desserts = new List<int>();
            Desserts.Add(167);
            Desserts.Add(266);
            Desserts.Add(75);
            Desserts.Add(0);

            //LOGIC
            //Burger check
            int calories = 0;
            if (burger > 0 && burger <5)
            {
                calories = calories + Burgers[burger - 1];
            }
            //Drink check
            if (drink > 0 && drink < 5)
            {
                calories = calories + Drinks[drink - 1];
            }
            //Side check
            if (side > 0 && side < 5)
            {
                calories = calories + Sides[side - 1];
            }
            //Dessert check
            if (dessert > 0 && dessert < 5)
            {
                calories = calories + Desserts[dessert - 1];
            }

            return "Your total calorie count is " + calories + ".";


        }
    }
}
