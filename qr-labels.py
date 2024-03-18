# Done by Genko Karadimov
# March 2024

# Function to generate QR code
def generate_qr_code(text, file_name):
    qr = qrcode.QRCode(
        version=1,
        error_correction=qrcode.constants.ERROR_CORRECT_L,
        box_size=10,
        border=4,
    )
    qr.add_data(text)
    qr.make(fit=True)

    # Create an image from the QR Code instance
    img = qr.make_image(fill_color="black", back_color="white")
    img.save(file_name)

# Start Program
# Checking Required Libraries
try:
    import qrcode
except ImportError:
    print("'qrcode' is not installed, so this app cannot be launched")
    print("Please install 'qrcode':")
    print("Open console and run: pip install qrcode[pil]")
    print("If pip is not found, install it :)")

try:
    import reportlab
    print("Welcome to label generator for ldx`s boxes")
    print("")
except ImportError:
    print("reportlab is not installed, so this app cannot be launched")
    print("Please install reportlab:")
    print("Open console and run: pip install reportlab")
    print("If pip is not found, install it :)")

# Adding Libraries
from reportlab.lib.pagesizes import A4
from reportlab.pdfgen import canvas
import qrcode
import datetime
import sys
import os


# Constants
COMPANY_NAME = "IBPhotonics LTD"; # first text row of label
a4_width, a4_height = A4; # paper: A4 Vertical - 210 x 297 mm 
PAPER_WIDTH = a4_width;
PAPER_HEIGHT = a4_height;
QRCODE_SIZE = 92;
MAR_TOP_INIT = 84;
MAR_TOP = 108.94;
MAR_LEFT_INIT = 20;
MAR_LEFT = 305.635;
MAR_TEXT_TO_QR = 6;
MAR_TEXT_BOTTOM = 12;
MAR_TEXT_TO_TEXT = 19;

# User inputs
device_name = input("Please enter a model of LDX: ")
date_string = input("Please enter a date (as string): ")
print("Enter a serial numbers (max 8), separated only with space")
serial_numbers_input = input("Serial Numbers: ")

# Validating user`s input
serial_numbers = serial_numbers_input.split()
if len(serial_numbers) == 0:
    print("No serial numbers!")
    sys.exit()
if len(serial_numbers) > 8:
    print("Only first 8 serial numbers will be get!")

# Generating QR Codes
for index, element in enumerate(serial_numbers):
    text = COMPANY_NAME + "\n" + device_name + "\nS/N: " + element + "\n" + date_string;
    generate_qr_code(text, "qrcode" + str(index) + ".png")

# Creating sheeet
formatted_datetime = datetime.datetime.now().strftime("%Y-%m-%d_%H-%M-%S")
file_name = f"labels_for_ldx_{formatted_datetime}.pdf"
c = canvas.Canvas(file_name, pagesize=A4)
# Set bold font
c.setFont("Helvetica", 14)  # Adjust font name and size as needed
    

# Adding QR codes to pdf
for index, element in enumerate(serial_numbers):
    x = MAR_LEFT_INIT;
    y = PAPER_HEIGHT - MAR_TOP_INIT - index * MAR_TOP;
    c.drawImage("qrcode" + str(index) + ".png", x, y, QRCODE_SIZE, QRCODE_SIZE);
    c.drawImage("qrcode" + str(index) + ".png", x + MAR_LEFT, y, QRCODE_SIZE, QRCODE_SIZE);
    # c.drawImage("qrcode" + str(index) + ".png", x + 2 * MAR_LEFT, y, QRCODE_SIZE, QRCODE_SIZE);

# Deleting QR codes
for index, element in enumerate(serial_numbers):
    os.remove("qrcode" + str(index) + ".png")

# Adding texts to pdf
for index, element in enumerate(serial_numbers):
    x = MAR_LEFT_INIT + QRCODE_SIZE + MAR_TEXT_TO_QR;
    y = PAPER_HEIGHT - MAR_TOP_INIT - index * MAR_TOP;
    c.drawString(x, y + MAR_TEXT_BOTTOM + 3 * MAR_TEXT_TO_TEXT, COMPANY_NAME)
    c.drawString(x, y + MAR_TEXT_BOTTOM + 2 * MAR_TEXT_TO_TEXT, device_name)
    c.drawString(x, y + MAR_TEXT_BOTTOM + MAR_TEXT_TO_TEXT, "S/N: " + element)
    c.drawString(x, y + MAR_TEXT_BOTTOM, date_string)

for index, element in enumerate(serial_numbers):
    x = MAR_LEFT_INIT + QRCODE_SIZE + MAR_TEXT_TO_QR;
    y = PAPER_HEIGHT - MAR_TOP_INIT - index * MAR_TOP;
    c.drawString(x + MAR_LEFT, y + MAR_TEXT_BOTTOM + 3 * MAR_TEXT_TO_TEXT, COMPANY_NAME)
    c.drawString(x + MAR_LEFT, y + MAR_TEXT_BOTTOM + 2 * MAR_TEXT_TO_TEXT, device_name)
    c.drawString(x + MAR_LEFT, y + MAR_TEXT_BOTTOM + MAR_TEXT_TO_TEXT, "S/N: " + element)
    c.drawString(x + MAR_LEFT, y + MAR_TEXT_BOTTOM, date_string)

# Saving pdf
c.save()




