using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Threading;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace WebApplication1.Controllers
{
    public class J3Controller : ApiController
    {
        [HttpGet]
        [Route("api/J3/DistinctYear/{year}")]

        //<summary>
        // Problem J3: From 1987 to 2013
        //Problem Description
        //  You might be surprised to know that 2013 is the first year since 1987 with distinct digits.The years
        //  2014, 2015, 2016, 2017, 2018, 2019 each have distinct digits. 2012 does not have distinct digits,
        //  since the digit 2 is repeated.
        //  Given a year, what is the next year with distinct digits?
        //Input Specification
        //The input consists of one integer Y (0 ≤ Y ≤ 10000), representing the starting year.
        //  Output Specification
        //The output will be the single integer D, which is the next year after Y with distinct digits.
        //<returns>
        //An integer showing the year or the next distinct year after the input
        //</returns>
        //<example>
        //Input: 2013 Output: 2013
        //</example>
        //<example>
        //Input 2022 Output:2031
        //</example>


        public int DistinctYear(int year)
        {
           // checks if the input was within the date range
            if(year >= 1 && year <= 10000)
            {
                bool flag = true;
                while (flag == true)
                {

                
                    string stringNumber = year.ToString();
                    int[] counter = new int[10];
                    foreach (char c in stringNumber)
                    {
                        for (int i = 0; i <= 9; i++)
                        {
                            if (c == i) //keeps track of how many times a unique number is displayed in the number input
                            {
                                counter[i] = counter[i] + 1;
                            }
                        }
                    }
                    
                    for (int i = 0; i <= 9; i++)
                    {                                       //checks if all the numbers from the counter array are 0 or 1 (unique)
                        if (counter[i] > 1)
                        {
                            flag = false;     //a number is counted more than once = false
                        }
                    }
                    if (flag == false) 
                    {
                        year++;             //since number was not distinct it goes to the next year to repeat the same process, sets the flag to true again
                        flag = true;

                    }
                
                }

                return year;
            }
            else
            {
                return 0;
            }
            return 0;
        } 
        
    }
}
