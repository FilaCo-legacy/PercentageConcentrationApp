using System;

namespace PCAppSolver
{
    /// <summary>
    /// Finds the percentage concentration of the solute from a mass of the solute (before adding extra substance)
    /// and its concentration
    /// </summary>
    public class SolverAddSub : ISolver
    {
        private double _massSol;
        private double _concentration;
        private double _massExtraSub;

        /// <summary>
        /// Mass of the solution before adding extra substance
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
                    throw new Exception("Percentage cannot be less than zero");
                if (value > 100)
                    throw new Exception("Percentage cannot be more than 100%");

                _concentration = value;
            }
        }

        /// <summary>
        /// A mass of the substance that have been added
        /// </summary>
        /// <exception cref="Exception"></exception>
        public double MassExtraSub
        {
            get => _massExtraSub;
            set
            {
                if (value < 0)
                    throw new Exception("Mass cannot be negative");

                _massExtraSub = value;
            }
        }

        public double Execute()
        {
            var massWater = (100 - Concentration) * MassSol / 100;
            var massNewSol = MassSol + MassExtraSub;

            return 100 - massWater * 100 / massNewSol;
        }
    }
}