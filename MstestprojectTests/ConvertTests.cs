using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mstestproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mstestproject.Tests
{
    [TestClass()]
    public class ConvertTests
    {
        [TestMethod()]
        public void cal()
        {
            int a = 10;
            int b = 20;
            int res=Convert.cal(a, b);
            Assert.AreEqual(30, res);

        }

        [TestMethod()]
        public void sub() 
        {
            int a = 20;
            int b = 20;
            int res1=Convert.sub(a, b);
            Assert.AreEqual(0, res1);
        }
        [TestMethod()]
        public void mul()
        {
            int a = 3;
            int b=3;
            int res3 = Convert.mul(a, b);
            Assert.AreEqual(9, res3);
        }
        [TestMethod()]
        public void div()
        {
            double a = 3;
            double b = 3;
            double res4= Convert.div(a, b);
            Assert.AreEqual(1, res4);

        }
        
        //[TestMethod()]

        //public void name()
        //{
        //    string s = "Lokesh";
        //    string res5= Convert.name(s);
        //    Assert.AreEqual("Lokesh", res5);
        //}

       
    }
}