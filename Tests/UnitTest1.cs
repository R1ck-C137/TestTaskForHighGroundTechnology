using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using TestTaskForHighGroundTechnology.Controllers;

namespace Tests
{
    public class UnitTest
    {
        [Fact]
        public void TestFirstTask()
        {
            var result = new ListOfNumbersController().FirstTask("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");

            Assert.Equal("1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz-buzz", result.Value[0].Value<string>());
        }

        [Fact]
        public void TestSecondTask()
        {
            var result = new ListOfNumbersController().SecondTask("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420");

            Assert.Equal("1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, guzz, fizz-buzz, fizz-buzz-muzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz", result.Value[0].Value<string>());
        }

        [Fact]
        public void TestThirdTask()
        {
            var result = new ListOfNumbersController().ThirdTask("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420");

            Assert.NotEqual("1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, fizz-muzz, 13, guzz, good-boy, good-boy-muzz, good-boy-guzz, good-boy-muzz-guzz", result.Value[0].Value<string>());
            Assert.Equal("1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, dog-muzz, 13, guzz, good-boy, good-boy-muzz, good-boy-guzz, good-boy-muzz-guzz", result.Value[0].Value<string>());
        }
    }
}