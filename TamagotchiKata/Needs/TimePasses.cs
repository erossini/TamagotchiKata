namespace TamagotchiKata
{
    /// <summary>
    /// Class TimePasses.
    /// Implements the <see cref="TamagotchiKata.Needs" />
    /// </summary>
    /// <seealso cref="TamagotchiKata.Needs" />
    public class TimePasses : Needs
    {
        /// <summary>
        /// Sendings the needs.
        /// </summary>
        public override void SendingNeeds()
        {
            Tiredness = Increase(Tiredness);
            Hungriness = Increase(Hungriness);
            Happiness = Decrease(Happiness);
        }
    }
}
