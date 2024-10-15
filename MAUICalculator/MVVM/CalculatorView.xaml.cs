using MAUICalculator.MVVM.ViewModels;

namespace MAUICalculator.MVVM;

public partial class CalculatorView : ContentPage
{
	public CalculatorView()
	{
		InitializeComponent();
		BindingContext = new CalculatorViewModel();
	}
}