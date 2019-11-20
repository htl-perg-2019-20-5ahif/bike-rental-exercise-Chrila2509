using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.Services
{
    public class Calculator : ICalculator
    {
        public decimal Calculate(DateTime start, DateTime end, decimal rentalPriceFirstHour, decimal rentalPriceAdditionalHours)
        {
            // check correct datetimes
            if (end < start)
            {
                throw new InvalidCastException();
            }

            // check duration > 0
            var duration = end - start;
            if (duration < TimeSpan.Zero)
            {
                throw new InvalidCastException();
            }
            decimal totalPrice = 0;

            // check durration < 15minutes -> free
            if (duration.TotalMinutes >= 15)
            {
                totalPrice += rentalPriceFirstHour;
            }

            // check for additional hours
            var additionalHours = (int)Math.Ceiling((duration - TimeSpan.FromHours(1)).TotalHours);
            if (additionalHours > 0)
            {
                totalPrice += additionalHours * rentalPriceAdditionalHours;
            }

            return totalPrice;

        }
    }
}
