using CalculatorTest2.Constants;
using CalculatorTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace CalculatorTest2.Services
{
    public class RestService:IRestService
    {
        // Accepts two numbers as input from UI
        //Calls calculator web service for the addition result
        public async Task<CalculatorItems> GetAddAsync(CalculatorItems input)
        { 
            using (var client = new HttpClient())
                {
                    string fNumber = input.num1;
                    string sNumber = input.num2;
                    client.BaseAddress = new Uri(Constant.RestUrl);
                    
                    var responseTask = await client.GetAsync("calculator/GetAdd/"+ fNumber +"/"+ sNumber);
                   
                    if (responseTask.IsSuccessStatusCode)
                    {
                        var readjob = responseTask.Content.ReadAsStringAsync();
                        input.Result = readjob.Result;
                    }
                return input;
                }
        }

        // Accepts two numbers as input from UI
        //Calls calculator web service for the subtraction result
        public async Task<CalculatorItems> GetSubtractAsync(CalculatorItems input)
        {
            using (var client = new HttpClient())
            {
                string fNumber = input.num1;
                string sNumber = input.num2;
                client.BaseAddress = new Uri("https://localhost:44374/api/");

                var responseTask = await client.GetAsync("calculator/GetSubtract/" + fNumber + "/" + sNumber);

                if (responseTask.IsSuccessStatusCode)
                {
                    var readjob = responseTask.Content.ReadAsStringAsync();
                    input.Result = readjob.Result;
                }
                return input;
            }
        }
        // Accepts two numbers as input from UI
        //Calls calculator web service for the multiplication result
        public async Task<CalculatorItems> GetMultiplyAsync(CalculatorItems input)
        {
            using (var client = new HttpClient())
            {
                string fNumber = input.num1;
                string sNumber = input.num2;
                client.BaseAddress = new Uri("https://localhost:44374/api/");

                var responseTask = await client.GetAsync("calculator/GetMultiply/" + fNumber + "/" + sNumber);

                if (responseTask.IsSuccessStatusCode)
                {
                    var readjob = responseTask.Content.ReadAsStringAsync();
                    input.Result = readjob.Result;
                }
                return input;
            }
        }
        // Accepts two numbers as input from UI
        //Calls calculator web service for the division result
        public async Task<CalculatorItems> GetDivideAsync(CalculatorItems input)
        {
            using (var client = new HttpClient())
            {
                string fNumber = input.num1;
                string sNumber = input.num2;
                client.BaseAddress = new Uri("https://localhost:44374/api/");

                var responseTask = await client.GetAsync("calculator/GetDivide/" + fNumber + "/" + sNumber);

                if (responseTask.IsSuccessStatusCode)
                {
                    var readjob = responseTask.Content.ReadAsStringAsync();
                    input.Result = readjob.Result;
                }
                return input;
            }
        }
    }
}