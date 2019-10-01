using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Models;


namespace Allergies.Test
{
    [TestClass]
    public class AllergiesTest
    {
        [TestMethod]
        public void CalculateScore_CalculatesAllergenScore_1()
        {
            //arrage
            bool[] inputarray = {true,false,false,false,false,false,false,false};
            //act
            int result = AllergiesClass.CalculateScore(inputarray);
            //assert
            Assert.AreEqual(1,result);
        }
        [TestMethod]
        public void CalculateScore_CalculatesAllergenScore_255()
        {
            //arrage
            bool[] inputarray = { true, true, true, true, true, true, true, true };
            //act
            int result = AllergiesClass.CalculateScore(inputarray);
            //assert
            Assert.AreEqual(255, result);
        }





    }



}