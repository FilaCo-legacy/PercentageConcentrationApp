using System;

namespace PCAppSolver
{
    /// <summary>
    /// Finds the percentage concentration from a mass of the substance and a mass of the vaporized solution
    /// </summary>
    public class SolverMassSub_Sol:ISolver
    {
        private double _massSubstance;
        private double _massSol;
        
        public double MassSubstance
        {
            get => _massSubstance;
            set
            {
                if (value < 0)
                    throw new Exception("Mass cannot be negative");
                _massSubstance = value;
            }
        }

        /// <summary>
        /// Mass of the solution before vaporizing
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

        public double Execute()
        {
            return MassSubstance * 100 / MassSol;
        }
    }
}