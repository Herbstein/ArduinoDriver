namespace ArduinoDriver.SerialProtocol {
    public class AnalogWriteResponse : ArduinoResponse {
        public AnalogWriteResponse(int pinRead, int value) {
            PinWritten = (byte) pinRead;
            ValueWritten = value;
        }

        public int PinWritten { get; }
        public int ValueWritten { get; }
    }
}
