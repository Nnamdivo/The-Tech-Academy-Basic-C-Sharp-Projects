# Welcome message - Display the initial greeting to the user
print("Welcome to Package Express. Please follow the instructions below.")

# Prompt the user for the package weight and convert input to float
weight = float(input("Please enter the package weight:\n"))

# Check if the weight exceeds the maximum allowed weight of 50
if weight > 50:
    # Display error message and exit the program if weight is too heavy
    print("Package too heavy to be shipped via Package Express. Have a good day.")
    exit()

# Prompt the user for the package width and convert input to float
width = float(input("Please enter the package width:\n"))

# Prompt the user for the package height and convert input to float
height = float(input("Please enter the package height:\n"))

# Prompt the user for the package length and convert input to float
length = float(input("Please enter the package length:\n"))

# Calculate the sum of all three dimensions (width + height + length)
dimensions_total = width + height + length

# Check if the total dimensions exceed the maximum allowed total of 50
if dimensions_total > 50:
    # Display error message and exit the program if dimensions are too large
    print("Package too big to be shipped via Package Express.")
    exit()

# Calculate the shipping quote:
# Multiply width, height, and length together to get the volume
# Then multiply by weight
# Finally divide by 100 to get the quote amount
quote = (width * height * length * weight) / 100

# Display the shipping quote formatted as a dollar amount with 2 decimal places
print(f"Your estimated total for shipping this package is: ${quote:.2f}")

# Display thank you message
print("Thank you!")

