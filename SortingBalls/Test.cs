using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SortingBalls
{
    class Test
    {
        [Test]
        public static void Test_EmptyNumbers()
        {
            Rack testRack = new Rack();
            Assert.AreEqual(new List<int>() { }, testRack.balls);
            Console.WriteLine("Test Case 1 executed");
            testRack.PrintListValues();


            //second test case
            Console.WriteLine("Test Case 2");
            testRack.AddBalls(20);
            Assert.AreEqual(new List<int>() { 20 }, testRack.balls);           
            testRack.PrintListValues();


            //third test case
            Console.WriteLine("Test Case 3");
            testRack.AddBalls(10);
            testRack.BallSort();
            testRack.PrintListValues();
            Assert.AreEqual(new List<int>() { 10, 20 }, testRack.balls);
            
            
            
        }

        
    }
}
