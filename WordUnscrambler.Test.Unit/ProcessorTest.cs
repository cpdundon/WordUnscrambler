using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WordUnscrambler.Test.Unit
{
    [TestClass]
    public class ProcessorTest
    {
        private Processor p = new Processor();
        [TestMethod]
        public void TestProcessWords_CheckSum()
        {
            string[] input = {"tac ", ""};
            List<WordPair> catAct = Processor.ProcessWords(input);
            Assert.Equals(2, catAct.Count);
            Console.WriteLine("Test");
        }
    }
}
