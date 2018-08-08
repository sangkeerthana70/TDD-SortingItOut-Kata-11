using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBalls
{
    class Rack
    {
        //property
        public List<int> balls;
        
        //constructor
        public Rack()
        {

            this.balls = new List<int>() {};
        }

        //method to add balls and sort
        public void AddBalls(int ball)
        {
            //adds the next ball draw to the existting list of balls
            balls.Add(ball);
            balls.Sort();
        }

        //method to print values from the list
        public void PrintListValues()
        {
            foreach(int ball in balls)
                Console.WriteLine("Balls in the draw: " + ball);

        } 
            
    }

}
         




       
       
    



