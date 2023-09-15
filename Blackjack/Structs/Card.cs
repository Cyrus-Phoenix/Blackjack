namespace Blackjack.Structs
{
    public struct Card
    {
        const string _back = "🂠";
        string _symbol = string.Empty;

        public bool IsHidden { get; set; }

        public string Symbol { get { return IsHidden ? _back : _symbol; } }

        // Samma som ovan fast mer modernare sätt att skriva den på
        int _value = 0;
        public int Value => IsHidden ? _value : 0;

        public bool IsRemoved { get; set; }
        public Card(string symbol, int value, bool isHidden = false)
        {
            _symbol = symbol;
            _value = value;
            IsHidden = isHidden;

        }


    }
}
