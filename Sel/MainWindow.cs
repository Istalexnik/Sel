using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Threading.Tasks;

namespace Sel
{
    public class MainWindow : Window
    {
        // Declare UI components
        private ComboBox? environmentStateComboBox;
        private ComboBox? claimTypeComboBox;
        private TextBox? urlTextBox;
        private Button? startButton;
        private Button? resetButton;
        private TextBox? firstnameTextBox;
        private TextBox? lastnameTextBox;
        private TextBox? ssnTextBox;
        private TextBox? dobTextBox;
        private TextBox? zipTextBox;
        private TextBox? employer1TextBox;
        private TextBox? employer1BeginDateTextBox;
        private TextBox? employer1EndDateTextBox;
        private TextBox? employer2TextBox;
        private TextBox? employer2BeginDateTextBox;
        private TextBox? employer2EndDateTextBox;
        private CheckBox? useSecondEmployerCheckBox;
        private TextBox? createdUsernamesTextArea;

        private List<Environment> environments;

        public MainWindow()
        {
            environments = Environment.CreateEnvironments();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Set up the window properties
            this.Title = "Sel";
            this.Width = 500;
            this.Height = 500;
            this.ResizeMode = ResizeMode.CanMinimize;
            this.WindowStyle = WindowStyle.SingleBorderWindow;

            // Set background color and border
            this.Background = new SolidColorBrush(Colors.LightGray);
            this.BorderBrush = new SolidColorBrush(Colors.DarkGray);
            this.BorderThickness = new Thickness(2);

            // Create a Grid to hold the UI elements
            Grid grid = new Grid();
            this.Content = grid;

            // Define rows and columns
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 0: Environment ComboBox and Claim Type
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 1: First Name
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 2: Last Name
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 3: SSN
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 4: DOB
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 5: Zip
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 6: Employer 1
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 7: Employer 1 Begin Date
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 8: Employer 1 End Date
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 9: Use Second Employer Checkbox
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 10: Employer 2
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 11: Employer 2 Begin Date
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 12: Employer 2 End Date
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }); // Row 13: Spacer
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 14: Reset Button
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 15: URL TextBox
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row 16: Start Button

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto }); // Column 0: Labels
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) }); // Column 1: TextBoxes
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) }); // Column 2: Text Area

            // Add ComboBox for environment-state combinations
            environmentStateComboBox = new ComboBox
            {
                Width = 240,
                Height = 25,
                Margin = new Thickness(0),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top
            };

            foreach (var environment in environments)
            {
                environmentStateComboBox.Items.Add(environment.DisplayName);
            }
            environmentStateComboBox.SelectedIndex = 0;
            environmentStateComboBox.SelectionChanged += UpdateFieldsBasedOnEnvironment;
            Grid.SetRow(environmentStateComboBox, 0);
            Grid.SetColumn(environmentStateComboBox, 0);
            Grid.SetColumnSpan(environmentStateComboBox, 2);
            grid.Children.Add(environmentStateComboBox);

            // Add ComboBox for claim type
            claimTypeComboBox = new ComboBox
            {
                Width = 150,
                Height = 25,
                Margin = new Thickness(5, 0, 0, 0),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top
            };

            claimTypeComboBox.Items.Add("Regular");
            claimTypeComboBox.Items.Add("UCX");
            claimTypeComboBox.Items.Add("UCFE");
            claimTypeComboBox.Items.Add("CWC");
            claimTypeComboBox.Items.Add("Alien");
            claimTypeComboBox.SelectedIndex = 0;
            Grid.SetRow(claimTypeComboBox, 0);
            Grid.SetColumn(claimTypeComboBox, 2);
            grid.Children.Add(claimTypeComboBox);

            // Add TextBoxes for user details and environment-related fields with default values
            AddLabelAndTextBox(grid, "First Name:", 1, 0, out firstnameTextBox, "Random");
            AddLabelAndTextBox(grid, "Last Name:", 2, 0, out lastnameTextBox, "Random");
            AddLabelAndTextBox(grid, "SSN:", 3, 0, out ssnTextBox, "Random");
            AddLabelAndTextBox(grid, "DOB:", 4, 0, out dobTextBox, "11/11/1959");
            AddLabelAndTextBox(grid, "Zip:", 5, 0, out zipTextBox);

            // Add the TextArea for created usernames right after the textboxes
            createdUsernamesTextArea = new TextBox
            {
                AcceptsReturn = true,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(5, 0, 0, 0),
                Height = 120,
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Left,
                Width = 195
            };
            Grid.SetRow(createdUsernamesTextArea, 1);
            Grid.SetRowSpan(createdUsernamesTextArea, 5);
            Grid.SetColumn(createdUsernamesTextArea, 2);
            grid.Children.Add(createdUsernamesTextArea);

            // Add Employer 1 field with reduced width by 5%
            AddLabelAndTextBox(grid, "Employer 1:", 6, 0, out employer1TextBox, "", 200);

            // Add Employer 1 Begin Date field
            AddLabelAndTextBox(grid, "Begin Date:", 7, 0, out employer1BeginDateTextBox, "01/01/2020", 95);
            // Add Employer 1 End Date field on the next row
            AddLabelAndTextBox(grid, "End Date:", 8, 0, out employer1EndDateTextBox, DateTime.Today.ToString("MM/dd/yyyy"), 95);

            // Add "Use second employer" CheckBox
            useSecondEmployerCheckBox = new CheckBox
            {
                Content = "Use second employer",
                Margin = new Thickness(5, 0, 0, 0),
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Left
            };
            useSecondEmployerCheckBox.Checked += ToggleSecondEmployerFields;
            useSecondEmployerCheckBox.Unchecked += ToggleSecondEmployerFields;
            Grid.SetRow(useSecondEmployerCheckBox, 9);
            Grid.SetColumn(useSecondEmployerCheckBox, 0);
            Grid.SetColumnSpan(useSecondEmployerCheckBox, 3);
            grid.Children.Add(useSecondEmployerCheckBox);

            // Add Employer 2 field with reduced width by 5%
            AddLabelAndTextBox(grid, "Employer 2:", 10, 0, out employer2TextBox, "", 200);

            // Add Employer 2 Begin Date field
            AddLabelAndTextBox(grid, "Begin Date:", 11, 0, out employer2BeginDateTextBox, "01/01/2020", 95);
            // Add Employer 2 End Date field on the next row
            AddLabelAndTextBox(grid, "End Date:", 12, 0, out employer2EndDateTextBox, DateTime.Today.ToString("MM/dd/yyyy"), 95);

            // Add a Reset Button above the URL TextBox, aligned to the right
            resetButton = new Button
            {
                Content = "Reset",
                Width = 100,
                Height = 25,
                Margin = new Thickness(5),
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Center
            };
            resetButton.Click += ResetButton_Click;
            Grid.SetRow(resetButton, 14);
            Grid.SetColumn(resetButton, 0);
            Grid.SetColumnSpan(resetButton, 3);
            grid.Children.Add(resetButton);

            // Add a TextBox for displaying the current URL just above the Start button
            urlTextBox = new TextBox
            {
                Width = 400,
                Height = 25,
                Margin = new Thickness(5),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                IsReadOnly = true
            };
            Grid.SetRow(urlTextBox, 15);
            Grid.SetColumn(urlTextBox, 0);
            Grid.SetColumnSpan(urlTextBox, 3);
            grid.Children.Add(urlTextBox);

            // Initial update for the fields
            UpdateFieldsBasedOnEnvironment(null, null);
            ToggleSecondEmployerFields(null, null);

            // Add a Button in the bottom row, centered horizontally
            startButton = new Button
            {
                Content = "Start",
                Width = 200,
                Height = 30,
                Margin = new Thickness(5),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Bottom
            };
            Grid.SetRow(startButton, 16);
            Grid.SetColumn(startButton, 0);
            Grid.SetColumnSpan(startButton, 3);
            grid.Children.Add(startButton);

            // Hook up the StartButton_Click event to start Selenium test
            startButton.Click += StartButton_Click;
        }

        private void AddLabelAndTextBox(Grid grid, string labelText, int row, int column, out TextBox textBox, string defaultValue = "", double textBoxWidth = 120)
        {
            Label label = new Label
            {
                Content = labelText,
                Margin = new Thickness(0),
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetRow(label, row);
            Grid.SetColumn(label, column);
            grid.Children.Add(label);

            textBox = new TextBox
            {
                Margin = new Thickness(0),
                Width = textBoxWidth,
                Height = 25,
                VerticalAlignment = VerticalAlignment.Center,
                Text = defaultValue
            };
            Grid.SetRow(textBox, row);
            Grid.SetColumn(textBox, column + 1);
            grid.Children.Add(textBox);
        }

        private void UpdateFieldsBasedOnEnvironment(object? sender, SelectionChangedEventArgs? e)
        {
            if (environmentStateComboBox == null || urlTextBox == null)
                return;

            string? selectedEnvironmentState = environmentStateComboBox.SelectedItem.ToString();
            var environment = environments.FirstOrDefault(env => env.DisplayName == selectedEnvironmentState);

            if (environment != null)
            {
                urlTextBox.Text = environment.Url;
                zipTextBox!.Text = environment.ZipCode;
                employer1TextBox!.Text = environment.Employer1;
                employer2TextBox!.Text = environment.Employer2;
            }
        }

        private void ToggleSecondEmployerFields(object? sender, RoutedEventArgs? e)
        {
            bool isEnabled = useSecondEmployerCheckBox!.IsChecked == true;

            // Employer 2 fields
            ToggleVisibility(isEnabled, employer2TextBox, 10);
            ToggleVisibility(isEnabled, employer2BeginDateTextBox, 11);
            ToggleVisibility(isEnabled, employer2EndDateTextBox, 12);
        }

        private void ToggleVisibility(bool isEnabled, UIElement? element, int row)
        {
            if (element != null)
            {
                element.Visibility = isEnabled ? Visibility.Visible : Visibility.Collapsed;
                foreach (UIElement child in ((Grid)this.Content).Children)
                {
                    if (Grid.GetRow(child) == row && Grid.GetColumn(child) == 0)
                    {
                        child.Visibility = isEnabled ? Visibility.Visible : Visibility.Collapsed;
                    }
                }
            }
        }

        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Disable the Start button while the test is running
            startButton!.IsEnabled = false;

            // Get the selected URL from the TextBox
            string? url = urlTextBox?.Text;

            if (!string.IsNullOrEmpty(url))
            {
                // Run the Selenium test asynchronously
                await Task.Run(() => SeleniumHelper.RunSeleniumTest(url));
                MessageBox.Show("Selenium test completed!");
            }
            else
            {
                MessageBox.Show("Please select a valid environment.");
            }

            // Re-enable the Start button after the test is done
            startButton.IsEnabled = true;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            // Reset all fields to their default values, excluding createdUsernamesTextArea
            environmentStateComboBox!.SelectedIndex = 0;
            claimTypeComboBox!.SelectedIndex = 0;
            firstnameTextBox!.Text = "Random";
            lastnameTextBox!.Text = "Random";
            ssnTextBox!.Text = "Random";
            dobTextBox!.Text = "11/11/1959";
            zipTextBox!.Text = "";
            employer1TextBox!.Text = "";
            employer1BeginDateTextBox!.Text = "01/01/2020";
            employer1EndDateTextBox!.Text = DateTime.Today.ToString("MM/dd/yyyy");
            employer2TextBox!.Text = "";
            employer2BeginDateTextBox!.Text = "01/01/2020";
            employer2EndDateTextBox!.Text = DateTime.Today.ToString("MM/dd/yyyy");
            useSecondEmployerCheckBox!.IsChecked = false;

            // Update fields based on the default environment
            UpdateFieldsBasedOnEnvironment(null, null);
        }
    }
}
