using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAppliaction;

namespace UnitTestProj
{
    [TestClass]
    public class UnitTestClass
    {
        [TestMethod]
        public void PossitiveSchenarioForChecking_combineArrayStringWithSpace_1()
        {
            string expectedResult = "This application is for testing purpose only";
            string[] actualStringArray = new string[] { "This", "application", "is", "for", "testing", "purpose", "only" };
            ApplicationCodeClass appObject = new ApplicationCodeClass();

            string actualResult = appObject.combineArrayStringWithSpace(actualStringArray);
            Assert.AreEqual<string>(expectedResult, actualResult);
        }

        [TestMethod]
        public void PossitiveSchenarioForChecking_combineArrayStringWithSpace_2()
        {
            string expectedResult = "This appliaction is for failed case";
            string[] actualStringArray = new string[] { "This", "application", "is", "for", "testing", "purpose", "only" };
            ApplicationCodeClass appObject = new ApplicationCodeClass();

            string actualResult = appObject.combineArrayStringWithSpace(actualStringArray);
            Assert.AreEqual<string>(expectedResult, actualResult);
        }
     
    }
}
