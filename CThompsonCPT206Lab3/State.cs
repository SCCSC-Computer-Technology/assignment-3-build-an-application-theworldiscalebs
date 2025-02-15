using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CThompsonCPT206Lab3
{
    public class State //class header
    {
        public State()
        {
            stateName = "";
            statePopulation = 0;
            stateFlagDesc = "";
            stateFlower = "";
            stateBird = "";
            stateColors = "";
            statesThreeLargestCities = "";
            stateCapital = "";
            stateMedianIncome = 0.0m;
            stateComputerJobPercent = 0.0m;
        }
        //List of properties 
        public string stateName { get; set; }
        
        public string stateFlagDesc { get; set; }
        public string stateFlower { get; set; }
        public string stateBird { get; set; }
        public string stateColors { get; set; }
        public string statesThreeLargestCities { get; set; }
        public string stateCapital { get; set; }
        public decimal stateMedianIncome { get; set; }
        public decimal stateComputerJobPercent { get; set; }
        public long statePopulation { get; set; }

        public string stateFlagPath { get; set; }
    }
}
