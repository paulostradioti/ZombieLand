namespace ZombieLand.Tests.TestData
{
    public class DataForMemberDataTests
    {
        public static IEnumerable<object[]> Data 
        {
            get 
            {
                yield return new object[] { 10, 90 };
                yield return new object[] { 15, 85 };
                yield return new object[] { 75, 25 };
                yield return new object[] { 200, 1 };
            } 
        }

        public static IEnumerable<object[]> GetInternalData()
        {
            yield return new object[] { 10, 90 };
            yield return new object[] { 15, 85 };
            yield return new object[] { 75, 25 };
            yield return new object[] { 200, 1 };
        }

        public static IEnumerable<object[]> GetExternalData()
        {
            var testCases = new List<object[]>();
            var lines = File.ReadAllLines("TestData/TestData.csv");

            foreach (var line in lines)
            {
                // 10,90 
                var values = line.Split(",")    // -> ["10", "90"]
                                 .Select(int.Parse); // [10, 90]

                var testCase = values.Cast<object>() //  [10, 90] (tipo é object)
                                     .ToArray();
                
                testCases.Add(testCase);
            }

            return testCases;
        }
    }
}
