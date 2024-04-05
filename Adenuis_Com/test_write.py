"""
Write to COM10
"""
import serial
import time

# Define the serial port and baudrate
serial_port = 'COM4'  # Adjust the port name based on your system (e.g., 'COM1' on Windows)
baud_rate = 115200

data_to_send = """
test data 1\ntest data 2\ntest data 3\ntest data 4\ntest data 5\ntest data 6\ntest data 7\n
""".strip()

try:
    # Initialize the serial connection
    ser = serial.Serial(serial_port, baud_rate)
    print(f"Serial port '{serial_port}' opened successfully.")

    # Wait for a brief moment to ensure the serial connection is established
    time.sleep(2)

    # Send data over the serial port
    
    ser.write(data_to_send.encode())
    print(f"Data sent: {data_to_send}")

    # Close the serial connection
    ser.close()
    print("Serial port closed.")

except serial.SerialException as e:
    print(f"Error opening or writing to serial port: {e}")
