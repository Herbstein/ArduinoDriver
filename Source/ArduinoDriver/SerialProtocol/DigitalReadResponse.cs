namespace ArduinoDriver.SerialProtocol {
    public class DigitalReadResponse : ArduinoResponse {
        public DigitalReadResponse(int pinRead, int value) {
            PinRead = (byte) pinRead;
            PinValue = (byte) value == 1 ? DigitalValue.High : DigitalValue.Low;
        }

        public int PinRead { get; }
        public DigitalValue PinValue { get; }
    }
}
