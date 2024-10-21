# Project Documentation for Calculator Application

## 1. Overview
This documentation provides an in-depth analysis of the **Calculator Application** developed using **.NET MAUI**. The application follows the **MVVM (Model-View-ViewModel)** pattern, which helps to keep the code organized, maintainable, and easily testable. The main components of the Calculator application include:

1. **CalculatorView.xaml** - Defines the user interface of the calculator.
2. **CalculatorView.xaml.cs** - Code-behind for the `CalculatorView`, handling events and UI interactions.
3. **CalculatorViewModel.cs** - The ViewModel that handles the logic and data binding for `CalculatorView`.

## 2. Overview of the UI Flow
### 2.1 Screen 1: Basic UI Layout (Light Theme)
![Light Theme](https://github.com/user-attachments/assets/97de2467-179c-4f6a-8577-1a1dd1a519a4)

### 2.2 Screen 2: Basic UI Layout (Dark Theme)
![Dark Theme](https://github.com/user-attachments/assets/857cd7d3-535e-4ca8-9dfd-07a362fee329)

### 2.3 Screen 3: "+" Function
![+function](https://github.com/user-attachments/assets/d7799fe8-07d5-41be-9cff-e479615d06d6)

## 3. Files Breakdown

### 3.1 CalculatorView.xaml
**Purpose**:
The `CalculatorView.xaml` file defines the layout and elements of the calculator's user interface. It includes controls such as **Buttons**, **Labels**, and **Grid** to represent the different calculator operations and input areas.

**Key Components**:
- **Grid Layout**: The `Grid` control is used to organize buttons (numbers and operations) in a structured format, making it easy for users to interact with the calculator.
- **Buttons**: Each button is defined to represent numbers (0-9) or operations (+, -, *, /).
- **Labels**: Used to display the current input, the result, and any operations being performed.

**Detailed Explanation**:
#### 3.1.1 XML Declaration
```xml
<?xml version="1.0" encoding="utf-8" ?>
```
This line declares that the file is an XML document, and specifies that UTF-8 encoding is used. This is standard for XML files.

#### 3.1.2 ContentPage Definition
```xml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MAUICalculator.MVVM.CalculatorView"
             Title="CalculatorView">
```
This line defines the root element of the XAML document. It is a `ContentPage`, which is a page within the MAUI application. The attributes include:

- **xmlns**: This specifies the default XML namespace for MAUI elements, allowing the usage of standard MAUI controls.
- **xmlns:x**: This defines an additional namespace used for various XAML-specific attributes, such as `x:Class`.
- **x:Class**: Specifies the namespace and name of the C# class that this XAML file is associated with (`CalculatorView`). This connects the XAML UI with the corresponding code-behind class in C#.
- **Title**: Sets the title of the page, which may be displayed in certain navigation contexts.

#### 3.1.3 Grid Layout and Label Elements
```xml
<Grid RowDefinitions=".4*, .6*">
    <VerticalStackLayout>
        <Label Text="{Binding Formula}" StyleClass="LabelText, LabelOperations"/>
        <Label Text="{Binding Result}" StyleClass="LabelText, LabelResult"/>
    </VerticalStackLayout>
</Grid>
```
This section sets up a `Grid` that defines the main layout of the page. The `RowDefinitions` specifies two rows with different proportions (`0.4*` and `0.6*`). The layout contains two `Label` elements to display the ongoing formula and the result of the calculations:

- **Label for Formula**: Displays the current calculation formula.
- **Label for Result**: Displays the result of the calculation.
- **Binding**: The `Text` property is data-bound using `{Binding}` to properties from the `CalculatorViewModel`, allowing dynamic updates of the formula and result.
- **StyleClass**: Specifies styles applied to these labels.

#### 3.1.4 Grid with Buttons for Calculator Inputs
```xml
<Grid Grid.Row="1">
    <BoxView />
    <Grid ColumnDefinitions="*, *, *, *"
          ColumnSpacing="15"
          RowDefinitions="*, *, *, *, *"
          RowSpacing="15"
          Padding="15">
        <!-- Various rows and columns defining the calculator buttons -->
    </Grid>
</Grid>
```
This nested `Grid` structure represents the main interface for the calculator buttons. Key aspects include:

- **Grid.Row="1"**: This places the `Grid` in the second row of the parent layout.
- **ColumnDefinitions and RowDefinitions**: Define the layout of the calculator buttons (4 columns and 5 rows).
- **Spacing and Padding**: Ensure there is appropriate spacing between buttons and padding around the grid for a clean layout.

#### 3.1.5 Button Elements
The individual buttons are defined within the `Grid`, representing different calculator actions such as digits, operations, and commands like "AC" (reset) or "=" (calculate). For example:

```xml
<Button Text="AC"
        Style="{StaticResource YellowButton}"
        Command="{Binding ResetCommand}"/>
```
- **Text**: The label on the button.
- **Style**: Refers to a static resource (`YellowButton`), which likely defines visual properties such as color and font.
- **Command**: Data-binding to commands in the `CalculatorViewModel`, which encapsulate the behavior that should occur when the button is pressed.
- **CommandParameter**: Passes a specific parameter to the command, e.g., the number or operation.

The buttons are defined in a grid structure to create a standard calculator layout, with arithmetic operators and digits distributed across rows and columns. The use of commands facilitates the MVVM pattern by separating UI interactions from the underlying logic.

### Summary of Regions:
- **Row 1**: Includes buttons for reset (AC), backspace (⌫), modulus (%), and division (/).
- **Row 2 - Row 4**: Include digit buttons (`7, 8, 9`, etc.) and operation buttons (`*`, `-`, `+`).
- **Row 5**: Includes the zero (`0`) button, a decimal point (`.`), and the equals (`=`) button to calculate the result.

### 3.2 CalculatorView.xaml.cs
#### 3.2.1 Class Declaration
```csharp
public partial class CalculatorView : ContentPage
{
    ...
}
```
This line defines a class named `CalculatorView`. Let's break it down further:

- **public**: The class is accessible from any other class. This visibility modifier ensures that the `CalculatorView` class can be used anywhere within the project or by external projects that reference it.
- **partial**: The `partial` keyword means that this class definition may be split across multiple files. This is useful in XAML-based applications where a part of the class is auto-generated based on XAML markup, which describes the UI layout.
- **CalculatorView**: The name of the class. As the name suggests, this class represents the View component of a calculator, likely responsible for rendering the UI and interacting with user inputs.
- **ContentPage**: `CalculatorView` inherits from `ContentPage`, which is a class provided by MAUI/Xamarin.Forms that represents a single page of content in the application. In MAUI, a `ContentPage` is typically used to host the user interface.

#### 3.2.2 Constructor
```csharp
public CalculatorView()
{
    InitializeComponent();
    BindingContext = new CalculatorViewModel();
}
```
This is the constructor for the `CalculatorView` class. A constructor is a special method used to initialize objects. Let's analyze each part:

##### 3.2.2.1 `InitializeComponent()`
This method is called to initialize the components of the page. This is a generated method that connects the user interface elements defined in the XAML file (associated with `CalculatorView`) to the C# code. It effectively "wires up" all UI components to their respective events and properties.

- The XAML (Extensible Application Markup Language) file associated with `CalculatorView` likely defines various UI elements, such as buttons and labels for a calculator interface.
- The `InitializeComponent()` method is typically auto-generated and ensures that the visual elements of the page are properly constructed when the view is loaded.

##### 3.2.2.2 `BindingContext = new CalculatorViewModel();`
The `BindingContext` property is set to a new instance of `CalculatorViewModel`.

- **BindingContext**: This property determines the data context for the `CalculatorView`. Essentially, it tells the view what data to bind to its UI components.
- **new CalculatorViewModel()**: Here, a new instance of `CalculatorViewModel` is created and assigned to `BindingContext`. This means that the `CalculatorView` is linked to `CalculatorViewModel`, which acts as the data source.
  - The `CalculatorViewModel` will contain properties and commands that are bound to the UI elements, such as buttons and labels. It provides the logic behind the UI, like handling operations (e.g., addition, subtraction) and updating the display accordingly.
- This is a fundamental concept in MVVM, where the ViewModel contains the application logic and data, and the View binds to this data, ensuring a clean separation between UI and business logic.

### 3.3 CalculatorViewModel.cs
#### 3.3.1 Class Declaration and `AddINotifyPropertyChangedInterface` Attribute
```csharp
namespace MAUICalculator.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalculatorViewModel
    {
        ...
    }
}
```
The `CalculatorViewModel` class is declared within the `MAUICalculator.MVVM.ViewModels` namespace, adhering to the MVVM architecture.

- **[AddINotifyPropertyChangedInterface]**: This attribute is used to automatically implement the `INotifyPropertyChanged` interface for this class. The `INotifyPropertyChanged` interface is a key part of data binding in MVVM, as it allows the view to be notified whenever a property value changes, enabling automatic UI updates.

#### 3.3.2 Properties
##### 3.3.2.1 `Formula`
```csharp
public string Formula { get; set; }
```
- **Formula** is a `string` property that represents the current mathematical expression being input by the user. This property is updated as the user presses different buttons on the calculator (e.g., numbers or operators).

##### 3.3.2.2 `Result`
```csharp
public string Result { get; set; } = "0";
```
- **Result** is another `string` property that stores the current result of the calculation. It is initialized to "0" to represent the default starting value of the calculator display.

#### 3.3.3 Commands
Commands are used to bind UI actions (such as button clicks) to logic defined in the ViewModel, allowing for separation of concerns.

##### 3.3.3.1 `OperationCommand`
```csharp
public ICommand OperationCommand => new Command((number) => { Formula += number; });
```
- This command is used to append numbers and operators to the `Formula`. It takes a parameter, **number**, which represents the button pressed by the user.
- **Formula += number**: This line appends the value (either a number or an operator) to the `Formula` property, thereby building the complete mathematical expression.

##### 3.3.3.2 `ResetCommand`
```csharp
public ICommand ResetCommand =>
    new Command(() =>
    {
        Result = "0";
        Formula = "";
    });
```
- The `ResetCommand` clears both the `Formula` and `Result` properties, effectively resetting the calculator to its default state.
- **Result = "0"** and **Formula = ""**: The `Result` is set back to "0", and `Formula` is cleared. This corresponds to pressing an "AC" button on a physical calculator.

##### 3.3.3.3 `BackspaceCommand`
```csharp
public ICommand BackspaceCommand =>
    new Command(() =>
    {
        if (Formula.Length > 0)
        {
            Formula = Formula.Substring(0, Formula.Length - 1);
        }
    });
```
- The `BackspaceCommand` removes the last character from the `Formula`. This mimics the backspace functionality of a standard calculator.
- **Formula.Substring(0, Formula.Length - 1)**: If the `Formula` has at least one character, this expression removes the last character from `Formula`.

##### 3.3.3.4 `CalculateCommand`
```csharp
public ICommand CalculateCommand =>
    new Command(() =>
    {
        if (Formula.Length == 0)
            return;
        var calculation = Calculator.Calculate(Formula);
        Result = calculation.Result.ToString();
    });
```
- The `CalculateCommand` evaluates the current `Formula` and updates the `Result` property.
- **Calculator.Calculate(Formula)**: This line uses the `Dangl.Calculator` library to evaluate the mathematical expression represented by `Formula`.
- **Result = calculation.Result.ToString()**: The result of the calculation is then converted to a string and assigned to the `Result` property. This is what gets displayed on the calculator UI.

### 4. Summary Table of Key Elements
| Component                      | File Path                | Description                                      | Key Features                            |
|--------------------------------|--------------------------|--------------------------------------------------|-----------------------------------------|
| **Calculator View**            | CalculatorView.xaml      | Defines the calculator UI layout                 | Grid layout, buttons for operations     |
| **Calculator Code-Behind**     | CalculatorView.xaml.cs   | Initializes the Calculator View                  | Binds to `CalculatorViewModel`          |
| **Calculator ViewModel**       | CalculatorViewModel.cs   | Handles logic and commands for the calculator    | Number, operation, and calculate commands |

### 5. Reference Sites
- [.NET MAUI Documentation](https://learn.microsoft.com/en-us/dotnet/maui/)
- [MVVM Pattern in Xamarin and MAUI](https://learn.microsoft.com/en-us/xamarin/xamarin-forms/enterprise-application-patterns/mvvm)
- [Commanding in .NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/data-binding/commanding?view=net-maui-8.0)

### 6. Required Nuget
- PropertyChanged.Fody : Version 4.1.0  /  Author : Simon Cropp
- Dangl.Calculator : Version 2.2.0  /  Author : Georg Dangl


