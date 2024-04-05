using System.IO.Ports;

namespace Adenuis_Com
{
    public partial class Main : Form
    {
        SerialPort currentPort;
        int readingSleepTimeMs;
        string receivedText;

        private static int GetDefaultReadingSleepTime()
        {
            return 500;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Reset placeholder texts
            portBox.Text = string.Empty;
            sendTextBox.Text = string.Empty;
            receivedTextBox.Text = string.Empty;
            readingSleepTimeMs = GetDefaultReadingSleepTime();
            receivedText = string.Empty;

            // Populate the PORT box with the available ports
            foreach (string port in SerialPort.GetPortNames())
            {
                portBox.Items.Add(port);
            }

            // Start the reading task
            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(readingSleepTimeMs);
                    if (currentPort == null || !currentPort.IsOpen)
                    {
                        Invoke(new Action(() =>
                        {
                            logToForm($"PR");
                        }));
                        continue;
                    }

                    Invoke(new Action(() =>
                    {
                        logToForm($"R");
                    }));
                    ReadSerial();
                }
            });
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseSerial();
        }

        private void GetPortBoxPort(object sender, EventArgs e)
        {
            receivedTextBox.Text = string.Empty;

            if (portBox.Text.Length > 0)
            {
                ConnectToPort(portBox.Text);
            }
        }

        private bool ReadSerial()
        {
            try
            {
                // If there is an input then speed up the process by
                // removing the readingSleepTimeMs
                int dataByte = currentPort.ReadByte();
                if (dataByte == -1)
                {
                    readingSleepTimeMs = GetDefaultReadingSleepTime();
                    Invoke(new Action(() =>
                    {
                        receivedTextBox.Text = receivedText;
                    }));
                    return false;
                }

                readingSleepTimeMs = 0;
                char receivedChar = (char)dataByte;
                if (receivedChar.ToString().Equals(string.Empty))
                {
                    receivedChar = '\n';
                }
                receivedText += receivedChar.ToString();   

                // TODO: Call this once, when the data stream ends
                Invoke(new Action(() =>
                {
                    receivedTextBox.Text = receivedText;
                }));
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            receivedTextBox.Clear();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            logToForm("W");
            try
            {
                currentPort.Write(sendTextBox.Text);
                Thread.Sleep(500);
            }
            catch
            {
                MessageBox.Show($"Communication error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConnectToPort(string portName)
        {
            try
            {
                CloseSerial();
                currentPort = new SerialPort(portName, 115200, Parity.None, 8, StopBits.One);
                Thread.Sleep(100);
                currentPort.Open();
            }
            catch
            {
                currentPort = null;
                logToForm($"LC: {portBox.Text}");
            }
        }

        private void CloseSerial()
        {
            if (currentPort != null && currentPort.IsOpen)
            {
                currentPort.Close();
                currentPort.Dispose();
            }
        }

        private void logToForm(string inputText)
        {
            loggerLabel.Text = inputText;
        }
    }
}
