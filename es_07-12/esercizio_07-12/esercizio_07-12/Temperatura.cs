using System;

namespace esercizio_07_12
{
    public class Temperatura
    {
        public static decimal fahreneitToCelsius(float tempFahreneit)
        {
            return (decimal)((tempFahreneit - 32) * 0.55);
        }
        public static decimal fahreneitToKelvin(float tempFahreneit)
        {
            return (decimal)(((tempFahreneit + 459.67) * 5) / 9);
        }
        public static decimal kelvinToCelsius(float tempKelvin)
        {
            return (decimal)(tempKelvin - 273.15);
        }
        public static decimal kelvinToFahreneit(float tempKelvin)
        {
            return (decimal)(((tempKelvin * 9) / 5) - 459.67);
        }
        public static decimal celsiusToKelvin(float tempCelsius)
        {
            return (decimal)(tempCelsius + 273.15);
        }      
        public static decimal celsiusToFahreneit(float tempCelsius)
        {
            return (decimal)((tempCelsius * 1.8) + 32);
        }
        
    }
}
