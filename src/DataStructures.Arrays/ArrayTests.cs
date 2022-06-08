namespace DataStructures.Arrays
{
    public class ArrayTests
    {
        [Fact(DisplayName = "should return a new array with a new item count")]
        public void Array01()
        {
            var array = new int[] { 1, 2, 3, 4 };

            var newArray = array.Append(5);

            Assert.Equal(4, array.Count());
            Assert.Equal(5, newArray.Count());
        }

        [Fact(DisplayName = "should return the first item in the array")]
        public void Array02()
        {
            var array = new int[] { 1, 2, 3 };

            var result = array.First();

            Assert.Equal(1, result);
        }

        [Fact(DisplayName = "should return the last item in the array")]
        public void Array03()
        {
            var array = new int[] { 1, 2, 3 };

            var result = array.Last();

            Assert.Equal(3, result);
        }
    }
}
