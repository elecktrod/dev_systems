using ds.test.impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_ds.test.impl
{
    [TestClass]
    public class PlaginsTests
    {
        [TestMethod]
        public void AdditionPlagin_trueReturned()
        {
            int expected = 7;
            int result = Plugins.GetPlugin(Plugins.GetPluginNames[0]).Run(3, 4);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SubtractionPlagin_trueReturned()
        {
            int expected = -2;
            int result = Plugins.GetPlugin(Plugins.GetPluginNames[1]).Run(3, 5);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MultiplicationPlugin_trueReturned()
        {
            int expected = -15;
            int result = Plugins.GetPlugin(Plugins.GetPluginNames[2]).Run(-3, 5);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DivisionPlugin_trueReturned()
        {
            int expected = 2;
            int result = Plugins.GetPlugin(Plugins.GetPluginNames[3]).Run(11, 5);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionPlugin_ZeroException_exceptionReturned()
        {
            int result = Plugins.GetPlugin(Plugins.GetPluginNames[3]).Run(5, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Plugins_GetPlugin_WrongPlaginName_exceptionReturned()
        {
            IPlugin plugin = Plugins.GetPlugin("WrongName");
        }
    }
}
