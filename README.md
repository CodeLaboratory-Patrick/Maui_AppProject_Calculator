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
