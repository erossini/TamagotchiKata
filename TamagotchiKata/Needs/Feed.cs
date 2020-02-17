namespace TamagotchiKata
{
    /// <summary>
    /// Class Feed.
    /// Implements the <see cref="TamagotchiKata.Needs" />
    /// </summary>
    /// <seealso cref="TamagotchiKata.Needs" />
    public class Feed : Needs
    {
        /// <summary>
        /// Sendings the needs.
        /// </summary>
        public override void SendingNeeds()
        {
            Hungriness = Decrease(Hungriness);
            Fullness = Increase(Fullness);
        }
    }
}
