namespace Patterns
{
    public class CoinStack
    {
        public class CoinStackState
        {
            private int _coinStackCounter;

            public int Coins { get { return _coinStackCounter; } }

            internal CoinStackState(int coinCounter)
            {
                _coinStackCounter = coinCounter;
            }
        }

        private int _coinCounter;
        public int Coins { get => _coinCounter; }

        public CoinStack() { _coinCounter = 0; }

        public void AddCoin()
        {
            _coinCounter++;
        }

        public CoinStackState SaveState()
        {
            return new CoinStackState(Coins);
        }

        public void RestoreState(CoinStackState state)
        {
            this._coinCounter = state.Coins;
        }
    }

    public class Treasurer
    {
        private List<CoinStack.CoinStackState> _mementos;

        private CoinStack _coinStack;

        public Treasurer ()
        {
            _mementos = new List<CoinStack.CoinStackState>();
            _coinStack = new CoinStack();
        }

        public void AddCoin()
        {
            _coinStack.AddCoin();
        }

        public int CountCoins()
        {
            return _coinStack.Coins;
        }

        public void SaveState()
        {
            _mementos.Add(_coinStack.SaveState());
        }

        public void RestoreLastSave()
        {
            if ( _mementos.Count > 0 )
            {
                _coinStack.RestoreState(_mementos.Last());
            }
        }
    }
}
