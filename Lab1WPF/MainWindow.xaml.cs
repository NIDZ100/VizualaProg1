using System;
using System.Windows;
using System.Windows.Controls;

namespace Lab1WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler for ListView selection changes
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Your logic here (if needed)
        }

        // Event handler for txtGruop TextBox changes
        private void txtGruop_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Your logic here (if needed)
        }

        // Event handler for txtSurname1 TextBox changes
        private void txtSurname1_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Your logic here (if needed)
        }

        // Event handler for txtID TextBox changes
        private void txtID_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Add your logic here (if needed)
        }
    }
}
