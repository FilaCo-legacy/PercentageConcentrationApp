using System;

namespace PCAppSolver
{
    /// <summary>
    /// Finds the percentage concentration of the mixed solute
    /// </summary>
    public class SolverMix:ISolver
    {
        private double _massSolA;
        private double _concentrationA;
        
        private double _massSolB;
        private double _concentrationB;

        /// <summary>
        /// Mass of the first solution
        /// </summary>
        /// <exception cref="Exception"></exception>
        public double MassSolA
        {
            get => _massSolA;
            set
            {
                if (value < 0)
                    throw new Exception("Mass cannot be negative");
                _massSolA = value;
            }
        }
        
        /// <summary>
        /// Mass of the second solution
        /// </summary>
        /// <exception cref="Exception"></exception>
        public double MassSolB
        {
            get => _massSolB;
            set
            {
                if (value < 0)
                    throw new Exception("Mass cannot be negative");
                _massSolB = value;
            }
        }

        /// <summary>
        /// Concentration of the first solution
        /// </summary>
        /// <exception cref="Exception"></exception>
        public double ConcentrationA
        {
            get => _concentrationA;
            set
            {
                if (value < 0)
                    throw  new Exception("Percentage cannot be less than zero");
                if (value > 100)
                    throw  new Exception("Percentage cannot be more than 100%");

                _concentrationA = value;
            }
        }
        
        /// <summary>
        /// Concentration of the second solution
        /// </summary>
        /// <exception cref="Exception"></exception>
        public double ConcentrationB
        {
            get => _concentrationB;
            set
            {
                if (value < 0)
                    throw  new Exception("Percentage cannot be less than zero");
                if (value > 100)
                    throw  new Exception("Percentage cannot be more than 100%");

                _concentrationB = value;
            }
        }
        
        public double Execute()
        {
            var massSubA = ConcentrationA * MassSolA / 100;
            var massSubB = ConcentrationB * MassSolB / 100;

            var sumMassSub = massSubA + massSubB;
            var sumMassSol = MassSolA + MassSolB;

            return sumMassSub * 100 / sumMassSol;
        }
    }
}