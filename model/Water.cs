using System;
using System.Collections.Generic;
using System.Text;


namespace oop.model
{
    /// <summary>
    /// Water osztály
    /// </summary>
    class Water
    {
        /// <summary>
        /// A víz hőmérséklete
        /// </summary>
        private double temperature;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="temperature">A víz hőmérséklete</param>
        /// <exception cref="WaterTemperatureException">Kivétel keletkezik ha a hőmérséklet kisebb mint az abszolút nulla foknál</exception>
        public Water(double temperature)
        {
            if (temperature < -273)
                throw new WaterTemperatureException("A víz hőmérséklete nem lehet kisebb az abszolút nulla foknál.");
            this.temperature = temperature;
        }

        /// <summary>
        /// Hőmérséklet, írható tulajdonság
        /// </summary>
        /// <exception cref="WaterTemperatureException">Kivétel keletkezik ha a hőmérséklet kisebb mint az abszolút nulla foknál</exception>
        public double Temperature
        {
            set
            {
                if (value <= 0)
                    throw new WaterTemperatureException("A víz hőmérséklete nem lehet kisebb az abszolút nulla foknál.");
                temperature = value;
            }
        }

        /// <summary>
        /// A víz halmazállapota
        /// </summary>
        public string StateOfWater
        {
            get
            {
                if (temperature < 0)
                    return "A víz fagyott állapotban van.";
            }
        }
    }
}
