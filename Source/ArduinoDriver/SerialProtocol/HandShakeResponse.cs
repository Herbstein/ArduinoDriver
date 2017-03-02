namespace ArduinoDriver.SerialProtocol {
    public class HandShakeResponse : ArduinoResponse {
        public HandShakeResponse(int protocolMajorVersion, int protocolMinorVersion) {
            ProtocolMajorVersion = protocolMajorVersion;
            ProtocolMinorVersion = protocolMinorVersion;
        }

        public int ProtocolMajorVersion { get; }
        public int ProtocolMinorVersion { get; }
    }
}
