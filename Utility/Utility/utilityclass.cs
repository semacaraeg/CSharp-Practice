using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class UtilityClass
    {
        public float GetBMI(float height, float weight, bool isMetric) {
            //float result = 0.0F;
            float bmi = 0.0F;

            if (isMetric)
            {
                float heightInMeters = ConvertCmtoMeters(height);
                bmi = CalculateBMI(heightInMeters, weight);
            }
            else {
                bmi = CalculateBMI(ConvertHeightToMeter(height), ConvertWeightToKg(weight));
                }

            return bmi;
        }
        public float CalculateBMI(float height, float weight) {
            return (weight / (height * height));
        }
        public float ConvertHeightToMeter(float height) {
            //convert inches or cm to meter
            return (height * 0.0254F);
        }
        public float ConvertHeightToInches(float height)
        {
            //convert  cm to inches
            return (height * 2.54F);

        }
        public float ConvertWeightToKg(float weight)
        {
            //convert pounds to kg,  1kg = 2.2lbs
            return (weight / 2.2F);
        }

        public float ConvertWeightToPounds(float weight)
        {
            //convert kg to pounds
            return (weight * 2.2F);
        }

        public float ConvertCmtoMeters(float height) {
            return height / 100.0F;
        }

        public string ConvertCelsiusToFahren(float celsius) {
            float fahren = (celsius * 9 / 5) + 32;
            return "" + fahren + " degrees in Fahrenheit";
        }

        public string ConvertFahrenToCelsius(float fahren)
        {
            float celsius = (fahren - 32) * (5/9);
            return "" + celsius + " degrees in Celsius";
        }
    }

   
}
