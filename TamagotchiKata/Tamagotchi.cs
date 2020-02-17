namespace TamagotchiKata
{
    /// <summary>
    /// Class Tamagotchi.
    /// </summary>
    public class Tamagotchi
    {
        /// <summary>
        /// The needs
        /// </summary>
        private Needs _needs;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tamagotchi"/> class.
        /// </summary>
        public Tamagotchi() {}

        /// <summary>
        /// Feeds this instance.
        /// </summary>
        /// <returns>Needs.</returns>
        public Needs Feed()
        {
            _needs = new Feed();
            _needs.SendingNeeds();

            return _needs;
        }

        /// <summary>
        /// Plays this instance.
        /// </summary>
        /// <returns>Needs.</returns>
        public Needs Play()
        {
            _needs = new Play();
            _needs.SendingNeeds();

            return _needs;
        }

        /// <summary>
        /// Sleeps this instance.
        /// </summary>
        /// <returns>Needs.</returns>
        public Needs Sleep()
        {
            _needs = new Sleep();
            _needs.SendingNeeds();

            return _needs;
        }

        /// <summary>
        /// Makes a poop.
        /// </summary>
        /// <returns>Needs.</returns>
        public Needs MakeAPoop()
        {
            _needs = new MakeAPoop();
            _needs.SendingNeeds();

            return _needs;
        }

        /// <summary>
        /// Times the passed.
        /// </summary>
        /// <returns>Needs.</returns>
        public Needs TimePassed()
        {
            _needs = new TimePasses();
            _needs.SendingNeeds();

            return _needs;
        }
    }
}
