namespace State
{
    /// <summary>
    /// Kinde of State
    /// </summary>
    public class GoldMember : State
    {
        /// <summary>
        /// Upper limit of balance
        /// </summary>
        public override double UpperLimit { get; set; }
        /// <summary>
        /// Lower limit of balance
        /// </summary>
        public override double LowerLimit { get; set; }

        /// <summary>
        /// Create an gold state
        /// </summary>
        /// <param name="state">initial state</param>
        public GoldMember(State state): this(state.Balance, state.Acount)
        {}
        /// <summary>
        /// Create an gold state
        /// </summary>
        /// <param name="balance">initial balance</param>
        /// <param name="acount">initial acount</param>
        public GoldMember(double balance, Acount acount)
        {
            this.Balance = balance;
            this.Acount = acount;
            this.LowerLimit = 500_000;
            this.UpperLimit = double.MaxValue;
            this.Membership = Membership.GOLD;
        }

        /// <summary>
        /// Check of changing acount state
        /// </summary>
        public override void StateChangeCheck()
        {
            if (Balance < LowerLimit)
                this.Acount.State = new SilverMember(this);
            else
                this.Acount.State = this;
        }
    }
}