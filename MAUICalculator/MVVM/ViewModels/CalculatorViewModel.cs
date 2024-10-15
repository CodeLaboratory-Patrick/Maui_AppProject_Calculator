using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUICalculator.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalculatorViewModel
    {
        public string Formular { get; set; }

        public string Result { get; set; } = "0";

        public ICommand OperationCommand => new Command((number) => { Formular += number; });
    }
}
