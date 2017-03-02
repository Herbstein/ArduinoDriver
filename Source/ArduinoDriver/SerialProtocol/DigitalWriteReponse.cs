namespace ArduinoDriver.SerialProtocol {
    public class DigitalWriteReponse : ArduinoResponse {
        public DigitalWriteReponse(int pinRead, int value) {
            PinWritten = (byte) pinRead;
            PinValue = (byte) value == 1 ? DigitalValue.High : DigitalValue.Low;
        }

        public int PinWritten { get; }
        public DigitalValue PinValue { get; }
    }
}
