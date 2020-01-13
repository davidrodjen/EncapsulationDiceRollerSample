using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDiceRollerSample
{
    /// <summary>
    /// Represents a single 6-sided die
    /// </summary>
    class Die
    {
        /// <summary>
        /// Static members get shared across all
        /// instances of this class
        /// </summary>
        private static Random rand;

        /// <summary>
        /// runs once before any Die objects are
        /// created and initializes random object once
        /// </summary>
        static Die()
        {
            rand = new Random();
        }


        public Die()
        {
            Roll();
        }

        /// <summary>
        /// The current value of the die
        /// </summary>
        public byte FaceValue { get; private set; } //private overrides the public

        /*
        public byte FaceValue
        {
            get { return FaceValue; }
            private set
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentException
                }
            }
        }
        */

        /// <summary>
        /// Saving the roll
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Generates a new random face value. sets face value,
        /// returns the generated the face value
        /// </summary>
        public byte Roll()
        {

            // If current die is held, return the current value
            if (IsHeld)
            {
                return FaceValue;
            }

            const byte MinValue = 1;
            const byte MaxValue = 6;
            // Offset is for the exclusive range of Random.Next();
            const byte Offset = 1;

            
            byte newValue = (byte)rand.Next(MinValue, MaxValue + Offset);

            FaceValue = newValue;
            return newValue;
        }
    }
}
