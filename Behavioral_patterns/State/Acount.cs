namespace State
{
    /// <summary>
    /// Context
    /// </summary>
    public class Acount
    {
        /// <summary>
        /// Balance of acount
        /// </summary>
        public double Balance
        {
            get { return State.Balance; }
        }

        /// <summary>
        /// Current state of acount
        /// </summary>
        public State State { get; set;  }

        /// <summary>
        /// Current membership of acount
        /// </summary>
        public Membership Membership
        {
            get
            {
                return State.Membership;
            }
        }

        private string _owner;

        /// <summary>
        /// Create an acount
        /// </summary>
        /// <param name="owner">Acount owner</param>
        public Acount(string owner)
        {
            this._owner = owner;
            this.State = new NormalMember(0, this);
        }

        /// <summary>
        /// Money movements
        /// </summary>
        /// <param name="money"></param>
        public void Transaction(double money)
        {
            State.Balance += money;

            if (State.Balance < 0)
                State.Balance = 0;

            // If only one step allowed
            // State.StateChangeCheck();

            // If multiple step allowed
            if (money > 0)
                do
                {
                    State.StateChangeCheck();
                } while (State.Balance >= State.UpperLimit);
            else
                do
                {
                    State.StateChangeCheck();
                } while (State.Balance < State.LowerLimit);
        }

    }
}