import serial
import time

# Define the serial port and baudrate
serial_port = 'COM4'  # Adjust the port name based on your system (e.g., 'COM1' on Windows)
baud_rate = 115200

# Initialize the serial connection
ser = serial.Serial(serial_port, baud_rate)
print(f"Serial port '{serial_port}' opened successfully.")

try:
    # Wait for a brief moment to ensure the serial connection is established
    time.sleep(2)

    # Read serial data as long as there is data available
    while ser.in_waiting:
        print(ser.read().decode("utf-8"), end="")
        time.sleep(0.25)

    print("Serial port closed.")

except serial.SerialException as e:
    print(f"Error opening or writing to serial port: {e}")
finally:
    ser.close()
