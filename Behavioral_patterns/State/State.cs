namespace State
{
    /// <summary>
    /// Memberships
    /// </summary>
    public enum Membership
    {
        NORMAL,
        SILVER,
        GOLD
    }
    public abstract class State
    {

        /// <summary>
        /// Upper limit of balance
        /// </summary>
        public abstract double UpperLimit { get; set; }

        /// <summary>
        /// Lower limit of balance
        /// </summary>
        public abstract double LowerLimit { get; set; }

        /// <summary>
        /// Balance of state
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// Acount of state
        /// </summary>
        public Acount Acount { get; set; }

        /// <summary>
        /// Membership of state
        /// </summary>
        public Membership Membership { get; set; }

        /// <summary>
        /// Transaction
        /// </summary>
        /// <param name="money"></param>
        public void Transaction(double money) => Balance += money;

        /// <summary>
        /// Check membership changing
        /// </summary>
        public abstract void StateChangeCheck();
    }
}