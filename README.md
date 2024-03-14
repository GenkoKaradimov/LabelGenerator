# Label Generator
Python script to generate printable PDF file with labels

## Goal
The script should create two identical well centered labels, which will be stuck on a box containing the corresponding device
![Labels on A4 pattern 2x8 ](/Example_QR_Code_Labels_Generator_for_IBP.png)

## Test configuration
> We created well-centered labels

**OS:** Linux Mint 21.1 Cinnamon 5.6.8
**Python:** 3.10.12
**Printer:** Lexmark MX711de
**Paper:** Self-adhesive labels A4 (2x8 pieces)

## How to install and use
- Download and unzip the script called: qr-labels.py
- Install python
- Install pip
- Run command: pip install reportlab
- Run command: pip install qrcode[pil]
- Run script:  python3 qr-labels.py
- Follow instructions on the console
- PDF file will appear in the same folder as a script

## Warnings
- Script will create up to 8 files during running, their names will be 'qrcode-{i}.png' (i: 0 to 7). If you have files with same names they will be overwriten and deleted.
- You can enter more than 8 serial number, but labels will be generated only  for first 8 serial numbers. 
- Generated PDF file not the same as printed paper at our configuration

