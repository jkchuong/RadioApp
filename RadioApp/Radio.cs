namespace RadioApp
{
    public class Radio
    {
        public Radio()
        {

        }

        private int _channel = 1;
        private bool _on = false;

        public int Channel 
        { 
            get => _channel;
            set
            {
                if ((value == 1 || value == 2 || value == 3 || value == 4) && _on)
                {
                    _channel = value;
                }
            }
        }

        public bool On { get; set; }

        public string Play()
        {
            if (_on)
            {
                return $"Playing channel {_channel}";
            }
            return "Radio is off";
        }

        public void TurnOff()
        {
            _on = false;
        }
        
        public void TurnOn()
        {
            _on = true;
        }

    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}