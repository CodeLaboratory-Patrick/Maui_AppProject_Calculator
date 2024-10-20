# Project Documentation for Calculator Application

## Overview
This documentation provides an in-depth analysis of the **Calculator Application** developed using **.NET MAUI**. The application follows the **MVVM (Model-View-ViewModel)** pattern, which helps to keep the code organized, maintainable, and easily testable. The main components of the Calculator application include:

1. **CalculatorView.xaml** - Defines the user interface of the calculator.
2. **CalculatorView.xaml.cs** - Code-behind for the `CalculatorView`, handling events and UI interactions.
3. **CalculatorViewModel.cs** - The ViewModel that handles the logic and data binding for `CalculatorView`.

## Overview of the UI Flow
### Screen 1: Basic UI Layout (Light Theme)

![Light Theme](https://github.com/user-attachments/assets/97de2467-179c-4f6a-8577-1a1dd1a519a4)

### Screen 2: Basic UI Layout (Dark Theme)

![Dark Theme](https://github.com/user-attachments/assets/857cd7d3-535e-4ca8-9dfd-07a362fee329)

### Screen 3: "+" Function

![+function](https://github.com/user-attachments/assets/d7799fe8-07d5-41be-9cff-e479615d06d6)

## Files Breakdown

### 1. CalculatorView.xaml
**Purpose**:
The `CalculatorView.xaml` file defines the layout and elements of the calculator's user interface. It includes controls such as **Buttons**, **Labels**, and **Grid** to represent the different calculator operations and input areas.

**Key Components**:
- **Grid Layout**: The `Grid` control is used to organize buttons (numbers and operations) in a structured format, making it easy for users to interact with the calculator.
- **Buttons**: Each button is defined to represent numbers (0-9) or operations (+, -, *, /).
- **Labels**: Used to display the current input, the result, and any operations being performed.

**Detailed Explanation**:
- **Grid Layout**: The `Grid` is used to arrange the calculator buttons in rows and columns, allowing for a consistent layout. This ensures that the buttons are easy to access, making the user experience more intuitive.
  - **RowDefinitions and ColumnDefinitions**: These properties are used to define the structure of the grid, determining how many rows and columns are available and their respective sizes.
- **Buttons**: Each button is placed in the grid with specific properties, such as `Grid.Row` and `Grid.Column`, to ensure it appears in the correct location. The buttons are also bound to commands from the `CalculatorViewModel` to enable the interaction logic.
  - **Text Property**: This specifies the text displayed on each button, such as numbers or operations.
  - **Command and CommandParameter**: Each button uses the `Command` property to bind to an appropriate command in the ViewModel and `CommandParameter` to pass specific data, such as the number or operation, to the command.
- **Labels**: The `Label` is used to show the user what they are inputting and the result of their calculations. The `Text` property of the label is bound to properties in the ViewModel, ensuring that updates to the calculation are reflected in real time.

**Example Structure**:
```xml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="YourNamespace.CalculatorView">
    <Grid Padding="20" RowDefinitions="*, *, *, *" ColumnDefinitions="*, *, *, *">
        <Label x:Name="DisplayLabel" Grid.ColumnSpan="4" FontSize="30" VerticalOptions="Center" HorizontalOptions="End" />
        <Button Text="1" Grid.Row="1" Grid.Column="0" Command="{Binding NumberCommand}" CommandParameter="1" />
        <Button Text="+" Grid.Row="1" Grid.Column="3" Command="{Binding OperationCommand}" CommandParameter="+" />
        <!-- More buttons here -->
    </Grid>
</ContentPage>
```
- **Grid Layout**: The buttons are arranged in a grid to ensure easy access and intuitive operation.
- **Command Binding**: Buttons use `Command` bindings to interact with the `ViewModel`, following the MVVM pattern.

### 2. CalculatorView.xaml.cs

### 3. CalculatorViewModel.cs

## Summary Table of Key Elements
| Component                      | File Path                | Description                                      | Key Features                            |
|--------------------------------|--------------------------|--------------------------------------------------|-----------------------------------------|
| **Calculator View**            | CalculatorView.xaml      | Defines the calculator UI layout                 | Grid layout, buttons for operations     |
| **Calculator Code-Behind**     | CalculatorView.xaml.cs   | Initializes the Calculator View                  | Binds to `CalculatorViewModel`          |
| **Calculator ViewModel**       | CalculatorViewModel.cs   | Handles logic and commands for the calculator    | Number, operation, and calculate commands |

## Reference Sites
- [.NET MAUI Documentation](https://learn.microsoft.com/en-us/dotnet/maui/)
- [MVVM Pattern in Xamarin and MAUI](https://learn.microsoft.com/en-us/xamarin/xamarin-forms/enterprise-application-patterns/mvvm)
- [Commanding in .NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/data-binding/commanding?view=net-maui-8.0)

## Required Nuget
- PropertyChanged.Fody : Version 4.1.0  /  Author : Simon Cropp
- Dangl.Calculator : Version 2.2.0  /  Author : Georg Dangl
