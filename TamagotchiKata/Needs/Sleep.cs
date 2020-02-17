namespace TamagotchiKata
{
    /// <summary>
    /// Class Sleep.
    /// Implements the <see cref="TamagotchiKata.Needs" />
    /// </summary>
    /// <seealso cref="TamagotchiKata.Needs" />
    public class Sleep : Needs
    {
        /// <summary>
        /// Sendings the needs.
        /// </summary>
        public override void SendingNeeds()
        {
            Tiredness = Decrease(Tiredness);
        }
    }
}
