namespace ArduinoDriver.SerialProtocol {
    public class PinModeResponse : ArduinoResponse {
        public PinModeResponse(int pin, PinMode mode) {
            Pin = pin;
            Mode = mode;
        }

        public int Pin { get; }
        public PinMode Mode { get; }
    }
}
