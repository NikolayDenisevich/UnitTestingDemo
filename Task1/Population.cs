using System;

namespace Task1
{
    public static class Population
    {
        /// <summary>
        /// The main class that is being tested.
        /// </summary>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (currentPopulation <= 0 || initialPopulation <= 0 || visitors < 0)
            {
                throw new ArgumentException("Invalid parameters of population or visitors");
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "cannot be less than 0% or mre than 100%");
            }

            int years = 0;
            while (initialPopulation <= currentPopulation)
            {
                double newPop = (initialPopulation * (1 + (percent / 100))) + visitors;
                initialPopulation = Convert.ToInt32(newPop);
                years++;
            }

            return years;
        }
    }
}