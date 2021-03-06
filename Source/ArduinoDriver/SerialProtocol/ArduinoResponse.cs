﻿namespace ArduinoDriver.SerialProtocol {
    using System.IO;

    public abstract class ArduinoResponse : ArduinoMessage {
        public static ArduinoResponse Create(byte[] bytes) {
            var commandByte = bytes[0];
            switch (commandByte) {
                case CommandConstants.HandshakeAck: {
                    return new HandShakeResponse(bytes[1], bytes[2]);
                }
                case CommandConstants.DigitalReadAck: {
                    return new DigitalReadResponse(bytes[1], bytes[2]);
                }
                case CommandConstants.DigitalWriteAck: {
                    return new DigitalWriteReponse(bytes[1], bytes[2]);
                }
                case CommandConstants.PinModeAck: {
                    return new PinModeResponse(bytes[1], (PinMode) bytes[2]);
                }
                case CommandConstants.AnalogReadAck: {
                    return new AnalogReadResponse(bytes[1], bytes[2], bytes[3]);
                }
                case CommandConstants.AnalogWriteAck: {
                    return new AnalogWriteResponse(bytes[1], bytes[2]);
                }
                case CommandConstants.Error: {
                    return new ErrorResponse(bytes[1], bytes[2], bytes[3]);
                }
                case CommandConstants.ToneAck: {
                    return new ToneResponse();
                }
                case CommandConstants.NoToneAck: {
                    return new NoToneResponse();
                }
                default: {
                    throw new IOException(string.Format("Unexpected command byte in response: {0}!", commandByte));
                }
            }
        }
    }
}
