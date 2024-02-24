using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Security.Policy;
using System.Web.Http;
using System.Web.Routing;
using System.Web.Security;

namespace WebApplication1.Controllers
{
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/SongContest/{votes}/{singer}")]

        //<summary>
        // The J2 problem that was used for this method was from 2014 CCC Junior Division.
        //Problem Description
        //A vote is held after singer A and singer B compete in the final round of a singing competition.
        //Your job is to count the votes and determine the outcome.
        //Input Specification
        //The input will be two lines.The first line will contain V (1 ≤ V ≤ 15), the total number of
        //votes.The second line of input will be a sequence of V characters, each of which will be A or B,
        //representing the votes for a particular singer.
        //Output Specification
        //The output will be one of three possibilities:
        //    • A, if there are more A votes than B votes;
        //    • B, if there are more B votes than A votes;
        //    • Tie, if there are an equal number of A votes and B votes.
        //<.summary>
        //<returns>
        //The method will be returning a string announcing the winner or if the contest was a tie, after counting the votes.
        //</returns>
        //<example>
        //api/J2/SongContest/7/AAABBAB
        // 7 votes total --- 'A' was counted 4 times, 'B' was counted 3 times
        // "The winner is singer A."
        //</example>
        //<example>
        //api/J2/SongContest/10/ABABBABAAB
        // 10 votes total --- 'A' was counted 5 times, 'B' was counted 5 times
        //"The contest was a tie."
        //</example>

        public string SongContest(int votes, string singer)
        {
            //valid vote check
            if (votes >=1 && votes <=15)   
            {
                //valid singers' vote length, string characters should be equal to number of votes input
                if (singer.Length == votes)  
                {
                    int countA = 0;
                    int countB = 0;
                    //foreach loop to count the number of times characters A and B are shown in teh singer input
                    foreach (char x in singer)   
                    {
                        if (x=='a' || x == 'A')
                        {
                            countA++;
                        }
                        else if (x == 'b' || x == 'B')
                        {
                            countB++;
                        } 
                        
                    }
                    //vote count logic
                    if (countA > countB)            
                    {
                        return "The winner is singer A.";
                    }
                    else if (countB > countA)
                    {
                        return "The winner is singer B";
                    }
                    else
                    {
                        return "The contest was a tie.";
                    }
                } else
                    {
                    return "Invalid input";
                    }
            } else
            {
                return "Invalid input";
            }
        }









    }
}
