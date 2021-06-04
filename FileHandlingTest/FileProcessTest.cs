using FileHandling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileHandlingTest
{
    [TestClass]
    public class FileProcessTest
    {
        #region Start Methods
        [TestMethod]
        public void FileNameDoesExists()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fileProcessCall;

            //Act
            fileProcessCall = fp.FileExists(@"C:\Users\LHadberg\.npmrc");
            //Assert

            Assert.IsTrue(fileProcessCall);
        }
        [TestMethod]
        public void FileNameDoesNotExists()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fileProcessCall;

            //Act
            fileProcessCall = fp.FileExists(@"C:\Users\LHadberg\.npmrcweewoo");
            
            //Assert
            Assert.IsFalse(fileProcessCall);
        }
        [TestMethod]
        public void FileNameNullOrEmptyThrowsArgumentNullException()
        {
            //Arrange
            FileProcess fp = new FileProcess();

            //Act
            try
            {
                // invoke the method
                fp.FileExists("");
            }
            catch (System.ArgumentNullException)
            {
                // success
                return;
            }

            //Assert
            Assert.Fail("Call to FileExists() did not throw an ArgumentException.");
        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void FileNameNullOrEmpty_UsingAttribute()
        {
            //Arrange
            FileProcess fp = new FileProcess();

            //Act
            fp.FileExists("");

            //Assert handled by Attribute and expects ArgumentNullExpection to be thrown.
        }
        #endregion Start Methods
    }
}
