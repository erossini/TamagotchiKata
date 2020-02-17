namespace TamagotchiKata
{
    /// <summary>
    /// Class Play.
    /// Implements the <see cref="TamagotchiKata.Needs" />
    /// </summary>
    /// <seealso cref="TamagotchiKata.Needs" />
    public class Play : Needs
    {
        /// <summary>
        /// Sendings the needs.
        /// </summary>
        public override void SendingNeeds()
        {
            Tiredness = Increase(Tiredness);
            Happiness = Increase(Happiness);
        }
    }
}
