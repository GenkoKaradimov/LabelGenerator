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
from reportlab.lib.pagesizes import letter
from reportlab.pdfgen import canvas
import qrcode
import datetime
import sys
import os


# Constants
COMPANY_NAME = "IBPhotonics LTD";
PAPER_WIDTH = 595.27; # paper: A4 Vertical
PAPER_HEIGHT = 841.89;
QRCODE_SIZE = 92;
MAR_TOP_INIT = 100;
MAR_TOP = 105.23625;
MAR_LEFT_INIT = 25;
MAR_LEFT = 297.635;

# User inputs
device_name = 'LDX220C-250u-10H-C3';
#device_name = input("Please enter type of LDX: ")
date_string = '8-Dec-2023';
#date_string = input("Please enter a date: ")
print("Enter a serial numbers (max 8), separated only with space")
serial_numbers_input = '1215 1216 1217 1218 1219 1220 1221 1222';
#serial_numbers_input = input("Serial Numbers: ")

# Validating user`s input
serial_numbers = serial_numbers_input.split()
if len(serial_numbers) == 0:
    print("No serial numbers!")
    sys.exit()
if len(serial_numbers) > 8:
    print("Only first 8 serial numbers will be get!")

# generating QR Codes
for index, element in enumerate(serial_numbers):
    text = COMPANY_NAME + "\n" + device_name + "\nS/N: " + element + "\n" + date_string;
    generate_qr_code(text, "qrcode" + str(index) + ".png")

# creating sheeet
formatted_datetime = datetime.datetime.now().strftime("%Y-%m-%d_%H-%M-%S")
file_name = f"labels_for_ldx_{formatted_datetime}.pdf"
c = canvas.Canvas(file_name, pagesize=(PAPER_WIDTH, PAPER_HEIGHT)) # size of A4 - Vertically

# adding qr codes to pdf
for index, element in enumerate(serial_numbers):
    x = MAR_LEFT_INIT;
    y = PAPER_HEIGHT - MAR_TOP_INIT - index * MAR_TOP;
    c.drawImage("qrcode" + str(index) + ".png", x, y, QRCODE_SIZE, QRCODE_SIZE);
    c.drawImage("qrcode" + str(index) + ".png", x + MAR_LEFT, y, QRCODE_SIZE, QRCODE_SIZE);
    # c.drawImage("qrcode" + str(index) + ".png", x + 2 * MAR_LEFT, y, QRCODE_SIZE, QRCODE_SIZE);

# deleting qrcodes
for index, element in enumerate(serial_numbers):
    os.remove("qrcode" + str(index) + ".png")

# adding texts to pdf

# saving pdf
c.save()




