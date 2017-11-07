using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ArrayTests
    {
        private int[] array1 { get; set; }
        private int[] array2 { get; set; }
        Common common = new Common();

        [SetUp]
        public void SetUpTest()
        {
            //set up arrays with randominteger values
            //array1 = common.GetRandomArray(25, -10, 35);
            //array2 = common.GetRandomArray(12, 5, 50);
        }

        [Test]
        [Category("Array's Unit Tests")]
        public void Array_Compare_CompareTwoValidArrays()
        {
            Array array = new Array();
            this.array1 = new int[] { 1,2,3,4,5,6,7};
            this.array2 = new int[] { 5,6,7 };
            int [] expectedResult = new int[] { 5,6,7};
            int [] actualResult = array.GetCommonElemets1(array1, array2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [Category("Array's Unit Tests")]
        public void Array_Compare_CompareNullArrays()
        {
            Array array = new Array();
            this.array1 = null;
            this.array2 = null;

            Assert.IsEmpty(array.GetCommonElemets1(array1, array2));
        }

        [Test]
        [Category("Array's Unit Tests")]
        public void Array_Compare_CompareArrayWithNull()
        {
            Array array = new Array();
            this.array1 = null;
            this.array2 = new int[] {5,6,7 };

            Assert.IsEmpty(array.GetCommonElemets1(array1, array2));
            Assert.IsEmpty(array.GetCommonElemets1(array2, array1));
        }
    }
}
