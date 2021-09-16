using NUnit.Framework;
using TLVRoofs;

namespace TestTLVRoofs
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert 
            var exampleArray = new int[] { 20, 30, 50, 70, 100 };
            var expectedArray = new int[] { 0, 0, 0, 0, 0 };

            var viwedBuildings = TLVRoofChecker.GetViewedBuildings(exampleArray);
            CollectionAssert.AreEqual(viwedBuildings, expectedArray);
        }


        [Test]
        public void Test2()
        {
            //Assert 
            var exampleArray = new int[] { 100, 70, 50, 30, 10 };
            var expectedArray = new int[] { 0, 1, 2, 3, 4 };

            var viwedBuildings = TLVRoofChecker.GetViewedBuildings(exampleArray);
            CollectionAssert.AreEqual(viwedBuildings, expectedArray);
        }


        [Test]
        public void Test3()
        {
            //Assert 
            var exampleArray = new int[] { 101, 87, 122, 208, 74, 107, 152, 130 };
            var expectedArray = new int[] { 0, 1, 0, 0, 4, 4, 4, 7 };

            var viwedBuildings = TLVRoofChecker.GetViewedBuildings(exampleArray);
            CollectionAssert.AreEqual(viwedBuildings, expectedArray);
        }

        [Test]
        public void Test4()
        {
            //Assert 
            var exampleArray = new int[] { 80, 75, 60, 70 };
            var expectedArray = new int[] { 0, 1, 2, 2 };

            var viwedBuildings = TLVRoofChecker.GetViewedBuildings(exampleArray);
            CollectionAssert.AreEqual(viwedBuildings, expectedArray);
        }

        [Test]
        public void Test5()
        {
            //Assert 
            var exampleArray = new int[] { 10, 70, 30, 40, 35, 20, 50 };
            var expectedArray = new int[] { 0, 0, 2, 2, 4, 5, 2 };

            var viwedBuildings = TLVRoofChecker.GetViewedBuildings(exampleArray);
            CollectionAssert.AreEqual(viwedBuildings, expectedArray);
        }

        [Test]
        public void Test6()
        {
            //Assert 
            var exampleArray = new int[] { 70, 20, 60, 80 };
            var expectedArray = new int[] { 0, 1, 1, 0 };

            var viwedBuildings = TLVRoofChecker.GetViewedBuildings(exampleArray);
            CollectionAssert.AreEqual(viwedBuildings, expectedArray);
        }
    }
}