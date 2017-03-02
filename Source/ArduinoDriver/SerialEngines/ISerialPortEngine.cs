namespace ArduinoDriver.SerialEngines {
    using System;

    public interface ISerialPortEngine : IDisposable {
        string PortName { get; set; }
        int BaudRate { get; set; }
        int ReadTimeout { get; set; }
        int WriteTimeout { get; set; }
        void Open();
        void Close();
        void Write(byte[] buffer, int offset, int count);
        int Read(byte[] buffer, int offset, int count);
    }
}
