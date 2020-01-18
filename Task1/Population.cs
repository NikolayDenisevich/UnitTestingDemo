using System;

namespace Task1
{
    /// <summary>
    /// The main class that is being tested.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Method which get how many years does the town need to have population greater or equal to currentPopulation inhabitants.
        /// </summary>
        /// <param name="initialPopulation"> The population at the beginning of a year. </param>
        /// <param name="percent"> By so many percent the population increases every year. </param>
        /// <param name="visitors"> New inhabitants per year. </param>
        /// <param name="currentPopulation"> Number of inhabitants at the moment. </param>
        /// <returns> years does the town need to have population greater or equal to currentPopulation inhabitants. </returns>
        /// <exception cref="ArgumentException"> this params
        /// <paramref name="currentPopulation"/>, <paramref name="initialPopulation"/>, <paramref name="visitors"/>
        /// cannot be less or equals zero.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException"> this params
        /// <paramref name="percent"/>
        /// cannot be less then 0% or more then 100%.
        /// </exception>
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