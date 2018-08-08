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
            Assert.AreEqual(new int[] {}, testRack.balls);
            
        }
    }
}
