using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;

namespace TestTaskForHighGroundTechnology.Controllers
{
    public class ListOfNumbersController : Controller
    {
        /// <param name="list">Exemple: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15</param>
        [HttpGet]
        [Route("firstTask")]
        public ActionResult<JArray> FirstTask(string list)
        {
            List<int> numbers = Util.ParseInput(list);
            
            List<object> result = new List<object>();
            foreach(int number in numbers)
            {
                result.Add(Util.GetFizzBuzzOutput(number));
            }
            return new JArray(string.Join(", ", result));
        }

        /// <param name="list">Exemple: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420</param>
        [HttpGet]
        [Route("secondTask")]
        public ActionResult<JArray> SecondTask(string list)
        {
            List<int> numbers = new List<int>(Array.ConvertAll(list.Replace(" ", "").Split(","), int.Parse));

            List<object> result = new List<object>();
            foreach (int number in numbers)
            {
                result.Add(Util.GetFizzBuzzMuzzGuzzOutput(number));
            }
            return new JArray(string.Join(", ", result));
        }

        /// <param name="list">Exemple: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420</param>
        [HttpGet]
        [Route("thirdTask")]
        public ActionResult<JArray> ThirdTask(string list) 
        {
            List<int> numbers = new List<int>(Array.ConvertAll(list.Replace(" ", "").Split(","), int.Parse));

            List<object> result = new List<object>();
            foreach (int number in numbers)
            {
                result.Add(Util.GetCatDogMuzzGuzzOutput(number));
            }
            return new JArray(string.Join(", ", result));
        }
    }
}
