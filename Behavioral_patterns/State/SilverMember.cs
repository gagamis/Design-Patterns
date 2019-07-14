namespace State
{
    /// <summary>
    /// Kinde of State
    /// </summary>
    public class SilverMember : State
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
        /// Create an silver state
        /// </summary>
        /// <param name="state">initial state</param>
        public SilverMember(State state) : this(state.Balance, state.Acount)
        { }
        /// <summary>
        /// Create an silver state
        /// </summary>
        /// <param name="balance">initial balance</param>
        /// <param name="acount">initial acount</param>
        public SilverMember(double balance, Acount acount)
        {
            this.Balance = balance;
            this.Acount = acount;
            this.LowerLimit = 300_000;
            this.UpperLimit = 500_000;
            this.Membership = Membership.SILVER;
        }

        /// <summary>
        /// Check of changing acount state
        /// </summary>
        public override void StateChangeCheck()
        {
            if (Balance >= UpperLimit)
                this.Acount.State = new GoldMember(this);
            else if (Balance < LowerLimit)
                this.Acount.State = new NormalMember(this);
        }
    }
}