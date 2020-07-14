using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    public static class TemperatureConverter
    {
        //function to convert temperature from fahrenheit to celsius.
        public static double ConvertToCelsius(double fahrenheit)
        {         
            return ((double)(5*(fahrenheit-32))/9);
        }

        // function to convert temperature from celsius to fahrenheit.
        public static double ConvertToFahrenheit(double celsius)
        {
            return ((double)((celsius*9)/5)+32);
        }
    }
}
