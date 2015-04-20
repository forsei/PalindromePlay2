using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDPalindromeT;

namespace TDDPalindromeT.Test
{
    [TestClass]
    public class PalindromeTests
    {
        private PalindromeFinder _palindromeFinder = null;

        [TestInitialize]
        public void InitTest()
        {
            _palindromeFinder = new PalindromeFinder();
        }

        #region Positive Cases
        [TestMethod]
        public void IsPalindromeReturnTrue()
        {
            //Arrange
            string value = "rotator";
            bool expected = true;

            //Act
            bool actual = _palindromeFinder.IsPalindrome(value);

            //Assert
            Assert.AreEqual(expected, actual);



        }
        #endregion Positive Cases


        #region Negative Cases
        [TestMethod]
        public void IsPalindromeReturnFalse()
        {
            //Arrange
            string value = "raggartangenter";
            bool expected = false;

            //Act
            bool actual = _palindromeFinder.IsPalindrome(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

       
        [TestMethod]
       // [ExpectedException(typeof(ArgumentNullException))]
        public void IsPalindromeThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            try
            {
                //Act
                bool actual = _palindromeFinder.IsPalindrome(value);

                //If no exception is thrown, then it fails.
                Assert.Fail("Exppected ArgumentNullException");
            }
            catch (ArgumentNullException)
            {
                
                //This is what should happen. No fail.
            }

            catch
            {
                //If another expetion is thrown, then it fails
                Assert.Fail("Exppected ArgumentNullException");

            }

            

            

        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        public void IsPalindromeThrowArgumentException()
        {
            //Arrange
            string value = "a";

            try
            {
            //Act
            bool actual = _palindromeFinder.IsPalindrome(value);
              //If no exception is thrown, then it fails.
                Assert.Fail("Exppected ArgumentException");
            }
            catch (ArgumentException)
            {
                
                //This is what should happen. No fail.
            }

            catch
            {
                //If another expetion is thrown, then it fails
                Assert.Fail("Exppected ArgumentException");

            }



        }

      



        #endregion Negative Cases
    }
}
