namespace State
{
    /// <summary>
    /// Kinde of state
    /// </summary>
    public class NormalMember : State
    {
        /// <summary>
        /// Lower limit of balance
        /// </summary>
        public override double LowerLimit { get; set; }
        /// <summary>
        /// Upper limit of balance
        /// </summary>
        public override double UpperLimit { get; set; }

        /// <summary>
        /// Create an normal state
        /// </summary>
        /// <param name="state">initial state</param>
        public NormalMember(State state) : this(state.Balance, state.Acount)
        { }

        /// <summary>
        /// Create an normal state
        /// </summary>
        /// <param name="balance">initial balance</param>
        /// <param name="acount">initial acount</param>
        public NormalMember(double balance, Acount acount)
        {
            this.Balance = balance;
            this.Acount = acount;
            this.UpperLimit = 300_000;
            this.LowerLimit = 0;
            this.Membership = Membership.NORMAL;
        }

        /// <summary>
        /// Check changing of acount state
        /// </summary>
        public override void StateChangeCheck()
        {
            if (Balance >= UpperLimit)
                Acount.State = new SilverMember(this);
            else
                Acount.State = this;
        }

    }
}