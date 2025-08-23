# Calculator

A simple Windows Forms calculator application built with C# and .NET Framework 4.8.

## Description

This is a basic calculator application that provides essential arithmetic operations through an intuitive graphical user interface. The calculator supports addition, subtraction, multiplication, and division operations with error handling for division by zero.

## Features

- **Basic Arithmetic Operations**: Addition (+), Subtraction (-), Multiplication (*), Division (/)
- **User-Friendly Interface**: Clean Windows Forms GUI with organized button layout
- **Error Handling**: Prevents division by zero with appropriate error messages
- **Real-time Display**: Shows input and results in a dedicated display area

## Screenshots

![Calculator Interface](screenshot.png) *(Add a screenshot of your calculator here)*

## Requirements

- **OS**: Windows 7/8/10/11
- **.NET Framework**: 4.8 or higher
- **IDE**: Visual Studio 2017 or later (for development)

## Installation

### Option 1: Download Release
1. Download the latest release from the [Releases](../../releases) page
2. Extract the ZIP file to your desired location
3. Run `Calculator.exe`

### Option 2: Build from Source
1. Clone this repository:
2. Open `Calculator.sln` in Visual Studio
3. Build the solution (Ctrl+Shift+B)
4. Run the application (F5)

## Usage

1. **Input Numbers**: Click the number buttons (0-9) to input values
2. **Select Operation**: Click an operator button (+, -, *, /)
3. **Calculate Result**: Click the equals (=) button to perform the calculation
4. **View Result**: The result will be displayed in the text box

### Example Operations
- Addition: `25 + 41 = 66`
- Subtraction: `50 - 15 = 35`
- Multiplication: `8 * 7 = 56`
- Division: `100 / 4 = 25`

## Technical Details

### Architecture
- **Language**: C# 
- **Framework**: .NET Framework 4.8
- **UI Framework**: Windows Forms
- **Pattern**: Event-driven programming

### Key Components
- `frmDashboard`: Main form containing the calculator interface
- `Form1.Designer.cs`: Auto-generated UI layout code
- `Program.cs`: Application entry point

### Code Structure

## Known Limitations

- Supports only two-operand calculations
- Integer-only arithmetic (no decimal support in current version)
- No memory functions (M+, M-, MR, MC)
- No advanced mathematical functions

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## Future Enhancements

- [ ] Decimal number support
- [ ] Memory functions
- [ ] Keyboard input support
- [ ] Scientific calculator mode
- [ ] History of calculations
- [ ] Copy/paste functionality

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Author

*Add your name and contact information here*

## Version History

- **v1.0.0** (2025) - Initial release with basic arithmetic operations

---

*This calculator was developed as part of a 6th Semester Lab assignment.*