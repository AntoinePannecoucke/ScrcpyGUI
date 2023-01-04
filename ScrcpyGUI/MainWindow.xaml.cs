using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScrcpyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.CanMinimize;

            viewModel = new MainWindowViewModel();

            this.DataContext = viewModel;
        }

        private void Launch_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Launch();
        }

        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
        private static bool IsTextIsNumericOnly(string text)
        {
            return _regex.IsMatch(text);
        }

        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e){
            e.Handled = IsTextIsNumericOnly(e.Text);
        }
    }
}
