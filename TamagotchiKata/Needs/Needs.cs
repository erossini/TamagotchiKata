namespace TamagotchiKata
{
    /// <summary>
    /// Class Needs.
    /// </summary>
    public abstract class Needs
    {
        /// <summary>
        /// Gets or sets the hungriness.
        /// </summary>
        /// <value>The hungriness.</value>
        public int Hungriness  { get; protected set; }
        /// <summary>
        /// Gets or sets the fullness.
        /// </summary>
        /// <value>The fullness.</value>
        public int Fullness    { get; protected set; }
        /// <summary>
        /// Gets or sets the happiness.
        /// </summary>
        /// <value>The happiness.</value>
        public int Happiness   { get; protected set; }
        /// <summary>
        /// Gets or sets the tiredness.
        /// </summary>
        /// <value>The tiredness.</value>
        public int Tiredness   { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Needs"/> class.
        /// </summary>
        public Needs()
        {
            Hungriness = 10;
            Fullness = 10;
            Happiness = 10;
            Tiredness = 10;
        }

        /// <summary>
        /// Sendings the needs.
        /// </summary>
        public abstract void SendingNeeds();

        /// <summary>
        /// Increases the specified mood.
        /// </summary>
        /// <param name="mood">The mood.</param>
        /// <returns>System.Int32.</returns>
        protected int Increase(int mood)
        {
            return mood += 1;
        }

        /// <summary>
        /// Decreases the specified mood.
        /// </summary>
        /// <param name="mood">The mood.</param>
        /// <returns>System.Int32.</returns>
        protected int Decrease(int mood)
        {
            return mood -= 1;
        }
    }
}
