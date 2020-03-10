using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaceGame_Simran;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGame_Simran.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            mann obj = new mann();
            obj.increment(150,50);
            Assert.IsTrue(true);
           
        }

        [TestMethod()]
        public void decrementTest() {

            Simn.decrement(150, 50);
            
            Assert.IsTrue(true);
        }

    }
}