using System;

namespace PCAppSolver
{
    /// <summary>
    /// Finds the percentage concentration from a mass of the substance and a mass of a water
    /// </summary>
    public class SolverMassSub_Water : ISolver
    {
        private double _massSubstance;
        private double _massWater;
        
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

        public double MassWater
        {
            get => _massWater;
            set
            {
                if (value < 0)
                    throw new Exception("Mass cannot be negative");
                _massWater = value;
            }
        }

        public double Execute()
        {
            var massSol = MassSubstance + MassWater;

            return MassSubstance / massSol;
        }
    }
}