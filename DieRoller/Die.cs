﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1 - 6)
    /// </summary>
    public class Die
    {
        private static Random _random; // makes a static field

        static Die()
        {
            _random = new Random();
        }

        /// <summary>
        /// Cretaes the die and rolls it to start with a random
        /// number
        /// </summary>
        public Die()
        {
            Roll();
        }

        /// <summary>
        /// The face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; } // private overrides public access for set

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/>  to the new number
        /// if the die is not currently held.
        /// Returns the <see cref="FaceValue"/>
        /// </summary>
        /// <returns><see cref="FaceValue"/></returns>
        public byte Roll()
        {
            if (!IsHeld)
            {
               // Generate random number
                byte newValue = (byte)_random.Next(1, 7);

                // Set to face Value
                FaceValue = newValue;
            }
            return FaceValue;
        }
    }
}
