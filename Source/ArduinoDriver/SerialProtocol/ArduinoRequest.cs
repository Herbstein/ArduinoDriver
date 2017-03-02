namespace ArduinoDriver.SerialProtocol {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class ArduinoRequest : ArduinoMessage {
        internal IList<byte> Bytes = new List<byte>();

        protected ArduinoRequest(byte command) {
            Command = command;
        }

        internal byte Command { get; }

        public override string ToString() {
            return $"{GetType().FullName} ({BitConverter.ToString(Bytes.ToArray())})";
        }
    }
}
