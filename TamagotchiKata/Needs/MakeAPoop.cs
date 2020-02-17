namespace TamagotchiKata
{
    /// <summary>
    /// Class MakeAPoop.
    /// Implements the <see cref="TamagotchiKata.Needs" />
    /// </summary>
    /// <seealso cref="TamagotchiKata.Needs" />
    public class MakeAPoop : Needs
    {
        /// <summary>
        /// Sendings the needs.
        /// </summary>
        public override void SendingNeeds()
        {
            Fullness = Decrease(Fullness);
        }
    }
}
