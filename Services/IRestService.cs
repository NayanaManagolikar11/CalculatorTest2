using CalculatorTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest2.Services
{
    public interface IRestService
    {
        Task<CalculatorItems> GetAddAsync(CalculatorItems input);
        Task<CalculatorItems> GetSubtractAsync(CalculatorItems input);
        Task<CalculatorItems> GetMultiplyAsync(CalculatorItems input);
        Task<CalculatorItems> GetDivideAsync(CalculatorItems input);
    }
}
