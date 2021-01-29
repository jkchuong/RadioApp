namespace RadioApp
{
    public class Radio
    {
        public Radio()
        {

        }

        private int _channel;

        /*
        private bool _on = false;

        public int Channel 
        { 
            get { return _channel; }
            set
            {
                if ((value == 1 || value == 2 || value == 3 || value == 4) && _on)
                {
                    _channel = value;
                }
            }
        }
        */

        public bool On { get; set; }

        public string Play()
        {
            if (_channel ==0) { return "No Channel Selected"; }
            if (On)
            {
                return $"Playing channel {_channel}";
            }
            return "Radio is off";
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
        }

        /*
        public void TurnOff()
        {
            _on = false;
        }
        
        public void TurnOn()
        {
            _on = true;
        }
        */
    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}