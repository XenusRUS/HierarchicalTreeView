using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPF_Timer;
using WPF_Timer.For_MVVM;

namespace Test_WPF_Timer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Person()
        {
            Person lol = new Person();
            string res = lol.LastName;
            Assert.AreEqual("Lol", res);
        }
    }
}
