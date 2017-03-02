namespace ArduinoDriver.SerialProtocol {
    public class AnalogReadResponse : ArduinoResponse {
        public AnalogReadResponse(int pinRead, byte byte1, byte byte2) {
            PinRead = (byte) pinRead;
            PinValue = (byte1 << 8) + byte2;
        }

        public int PinRead { get; }
        public int PinValue { get; }
    }
}
