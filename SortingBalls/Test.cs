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
        public static void Test_AddingNumbersToDraw()
        {
            Rack testRack = new Rack();
            Assert.AreEqual(new List<int>() { }, testRack.balls);//Assert that empty numbers in the list is the same for input and expected output
            Console.WriteLine("Test Case 1 executed");
            testRack.PrintListValues();


            //second test case
            Console.WriteLine("Test Case 2");
            testRack.AddBalls(20);//add 20 to the list
            Assert.AreEqual(new List<int>() { 20 }, testRack.balls);         
            testRack.PrintListValues();


            //third test case
            Console.WriteLine("Test Case 3");
            testRack.AddBalls(10);
            testRack.PrintListValues();
            Assert.AreEqual(new List<int>() { 10, 20 }, testRack.balls);

            //Last Test Case
            Console.WriteLine("Test Case 4");
            testRack.AddBalls(30);
            testRack.PrintListValues();
            Assert.AreEqual(new List<int>() { 10, 20, 30 }, testRack.balls);

            
            
            
        }

        
    }
}
