using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.Services
{
    interface ICalculator
    {
        public decimal Calculate(DateTime start, DateTime end, decimal rentalPriceFirstHour, decimal rentalPriceAdditionalHours);
    }
}
