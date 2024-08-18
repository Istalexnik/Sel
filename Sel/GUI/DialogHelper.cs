using System;
using System.Windows;
using System.Windows.Controls;

namespace Sel.GUI
{
    public static class DialogHelper
    {
        public static void ShowCustomPauseDialog(string message)
        {
            // Create a new window
            var window = new Window
            {
                Title = "Pause",
                Width = 300,
                Height = 150,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                Topmost = true // Ensures the window is on top of all others
            };

            // Create a StackPanel to hold the content
            var stackPanel = new StackPanel();

            // Create and configure the Label
            var label = new Label
            {
                Content = message,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            // Create and configure the Button
            var okButton = new Button
            {
                Content = "Ok",
                Width = 75,
                Height = 30,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 20, 0, 0)
            };
            okButton.Click += (sender, e) => window.Close();

            // Add the Label and Button to the StackPanel
            stackPanel.Children.Add(label);
            stackPanel.Children.Add(okButton);

            // Set the window content
            window.Content = stackPanel;

            // Show the dialog window and pause execution until it's closed
            window.ShowDialog();
        }
    }
}
