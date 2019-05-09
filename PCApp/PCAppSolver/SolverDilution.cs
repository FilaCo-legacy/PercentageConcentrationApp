using System;

namespace PCAppSolver
{
    /// <summary>
    /// Finds the percentage concentration of diluted solute from a mass of the solute (before adding extra water)
    /// and its concentration
    /// </summary>
    public class SolverDilution:ISolver
    {
        private double _massSol;
        private double _concentration;
        private double _massExtraWater;
        
        /// <summary>
        /// Mass of the solution before dilution
        /// </summary>
        /// <exception cref="Exception"></exception>
        public double MassSol
        {
            get => _massSol;
            set
            {
                if (value < 0)
                    throw new Exception("Mass cannot be negative");
                _massSol = value;
            }
        }

        public double Concentration
        {
            get => _concentration;
            set
            {
                if (value < 0)
                    throw  new Exception("Percentage cannot be less than zero");
                if (value > 100)
                    throw  new Exception("Percentage cannot be more than 100%");

                _concentration = value;
            }
        }

        /// <summary>
        /// A mass of water that have been added
        /// </summary>
        /// <exception cref="Exception"></exception>
        public double MassExtraWater
        {
            get => _massExtraWater;
            set
            {
                if (value < 0)
                    throw  new Exception("Mass cannot be negative");

                _massExtraWater = value;
            }
        }

        public double Execute()
        {
            var massSub = Concentration * MassSol;
            var massDilutedSol = MassSol + MassExtraWater;

            return massSub / massDilutedSol;
        }
    }
}