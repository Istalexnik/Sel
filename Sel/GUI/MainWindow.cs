using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Sel.Data;
using Sel.Enums;
using Sel.Utilities;
using Environment = Sel.Data.Environment;

namespace Sel.GUI
{
    public class MainWindow : Window
    {
        private ComboBox? environmentStateComboBox;
        private ComboBox? claimTypeComboBox;
        private TextBox? urlTextBox;
        private Button? startButton;
        private Button? resetButton;
        private Button? selectPagesButton;
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

        private string? stateAbbreviation;
        private string? stateName;

        private List<Environment> environments;
        private List<PageType> selectedPages;

        public MainWindow()
        {
            environments = Environment.CreateEnvironments();
            selectedPages = new List<PageType>();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Title = "Sel";
            Width = 530;
            Height = 600;
            ResizeMode = ResizeMode.CanMinimize;
            WindowStyle = WindowStyle.SingleBorderWindow;

            Background = new SolidColorBrush(Colors.LightGray);
            BorderBrush = new SolidColorBrush(Colors.DarkGray);
            BorderThickness = new Thickness(2);

            Grid grid = new Grid();
            Content = grid;

            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row for Select Pages and Reset buttons
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row for URL TextBox
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row for Start Button

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) });

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

            claimTypeComboBox = new ComboBox
            {
                Width = 150,
                Height = 25,
                Margin = new Thickness(5, 0, 0, 0),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top
            };

            foreach (var claimType in Enum.GetValues(typeof(ClaimType)))
            {
                claimTypeComboBox.Items.Add(claimType);
            }
            claimTypeComboBox.SelectedIndex = 0;
            Grid.SetRow(claimTypeComboBox, 0);
            Grid.SetColumn(claimTypeComboBox, 2);
            grid.Children.Add(claimTypeComboBox);

            AddLabelAndTextBox(grid, "First Name:", 1, 0, out firstnameTextBox, "Random");
            AddLabelAndTextBox(grid, "Last Name:", 2, 0, out lastnameTextBox, "Random");
            AddLabelAndTextBox(grid, "SSN:", 3, 0, out ssnTextBox, "Random");
            AddLabelAndTextBox(grid, "DOB:", 4, 0, out dobTextBox, Helper.GenerateUniqueBirthdate());
            AddLabelAndTextBox(grid, "Zip:", 5, 0, out zipTextBox);

            createdUsernamesTextArea = new TextBox
            {
                AcceptsReturn = true,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(5, 0, 0, 0),
                Height = 120,
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Left,
                Width = 195,
                IsReadOnly = true
            };
            Grid.SetRow(createdUsernamesTextArea, 1);
            Grid.SetRowSpan(createdUsernamesTextArea, 5);
            Grid.SetColumn(createdUsernamesTextArea, 2);
            grid.Children.Add(createdUsernamesTextArea);

            AddLabelAndTextBox(grid, "Employer 1:", 6, 0, out employer1TextBox, "", 200);
            AddLabelAndTextBox(grid, "Begin Date:", 7, 0, out employer1BeginDateTextBox, "01/01/2020", 95);
            AddLabelAndTextBox(grid, "End Date:", 8, 0, out employer1EndDateTextBox, DateTime.Today.ToString("MM/dd/yyyy"), 95);

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

            AddLabelAndTextBox(grid, "Employer 2:", 10, 0, out employer2TextBox, "", 200);
            AddLabelAndTextBox(grid, "Begin Date:", 11, 0, out employer2BeginDateTextBox, "01/01/2020", 95);
            AddLabelAndTextBox(grid, "End Date:", 12, 0, out employer2EndDateTextBox, DateTime.Today.ToString("MM/dd/yyyy"), 95);

            // Add event handlers for clearing and restoring text
            AddTextBoxFocusHandlers(firstnameTextBox, "Random");
            AddTextBoxFocusHandlers(lastnameTextBox, "Random");
            AddTextBoxFocusHandlers(ssnTextBox, "Random");

            // Add Select Pages button, aligned to the left
            selectPagesButton = new Button
            {
                Content = "Select Pages",
                Width = 100,
                Height = 25,
                Margin = new Thickness(1),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center
            };
            selectPagesButton.Click += SelectPagesButton_Click;
            Grid.SetRow(selectPagesButton, 14);
            Grid.SetColumn(selectPagesButton, 0);
            grid.Children.Add(selectPagesButton);

            // Add Reset button, aligned to the right and slightly moved to the left
            resetButton = new Button
            {
                Content = "Reset",
                Width = 100,
                Height = 25,
                Margin = new Thickness(5, 0, 0, 0), // Moved to the left
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Center
            };
            resetButton.Click += ResetButton_Click;
            Grid.SetRow(resetButton, 14);
            Grid.SetColumn(resetButton, 2);
            grid.Children.Add(resetButton);

            // Add URL TextBox just above the Start button
            urlTextBox = new TextBox
            {
                Width = 400,
                Height = 25,
                Margin = new Thickness(5),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                IsReadOnly = false
            };
            Grid.SetRow(urlTextBox, 15);
            Grid.SetColumn(urlTextBox, 0);
            Grid.SetColumnSpan(urlTextBox, 3);
            grid.Children.Add(urlTextBox);

            UpdateFieldsBasedOnEnvironment(null, null);
            ToggleSecondEmployerFields(null, null);

            // Add Start button at the very bottom, centered
            startButton = new Button
            {
                Content = "Start",
                Width = 510,
                Height = 50,
                Background = new SolidColorBrush(Color.FromArgb(255, 250, 255, 250)),
                //Margin = new Thickness(1),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Bottom
            };
            Grid.SetRow(startButton, 16);
            Grid.SetColumn(startButton, 0);
            Grid.SetColumnSpan(startButton, 3);
            grid.Children.Add(startButton);

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

        private void AddTextBoxFocusHandlers(TextBox textBox, string defaultText)
        {
            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == defaultText)
                {
                    textBox.Clear();
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = defaultText;
                }
            };
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
                stateAbbreviation = environment.StateAbbreviation;
                stateName = environment.StateName;
            }
        }

        private void ToggleSecondEmployerFields(object? sender, RoutedEventArgs? e)
        {
            bool isEnabled = useSecondEmployerCheckBox!.IsChecked == true;

            ToggleVisibility(isEnabled, employer2TextBox, 10);
            ToggleVisibility(isEnabled, employer2BeginDateTextBox, 11);
            ToggleVisibility(isEnabled, employer2EndDateTextBox, 12);
        }

        private void ToggleVisibility(bool isEnabled, UIElement? element, int row)
        {
            if (element != null)
            {
                element.Visibility = isEnabled ? Visibility.Visible : Visibility.Collapsed;
                foreach (UIElement child in ((Grid)Content).Children)
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
            startButton!.IsEnabled = false;

            // Fetch data from UI elements and store it in TestData
            FetchData();

            if (!string.IsNullOrEmpty(TestData.Url) && selectedPages != null)
            {
                try
                {
                    // Run the WebDriver on a separate thread using the pre-fetched TestData
                    await Task.Run(() =>
                    {
                        SeleniumBase.RunSeleniumTest(TestData.Url);
                    });
                    MessageBox.Show("Selenium test completed!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    startButton.IsEnabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please select a valid environment and pause pages.");
                startButton.IsEnabled = true;
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            environmentStateComboBox!.SelectedIndex = 0;
            claimTypeComboBox!.SelectedIndex = 0;
            firstnameTextBox!.Text = "Random";
            lastnameTextBox!.Text = "Random";
            ssnTextBox!.Text = "Random";
            dobTextBox!.Text = Helper.GenerateUniqueBirthdate();
            zipTextBox!.Text = "";
            employer1TextBox!.Text = "";
            employer1BeginDateTextBox!.Text = "01/01/2020";
            employer1EndDateTextBox!.Text = DateTime.Today.ToString("MM/dd/yyyy");
            employer2TextBox!.Text = "";
            employer2BeginDateTextBox!.Text = "01/01/2020";
            employer2EndDateTextBox!.Text = DateTime.Today.ToString("MM/dd/yyyy");
            useSecondEmployerCheckBox!.IsChecked = false;

            UpdateFieldsBasedOnEnvironment(null, null);
            ToggleSecondEmployerFields(null, null);
        }

        private void SelectPagesButton_Click(object sender, RoutedEventArgs e)
        {
            PageSelectionWindow pageSelectionWindow = new PageSelectionWindow();
            if (pageSelectionWindow.ShowDialog() == true)
            {
                selectedPages = pageSelectionWindow.SelectedPages!;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            SeleniumBase.QuitDriver();
            base.OnClosed(e);
        }

        private void FetchData()
        {
            TestData.SSN = string.IsNullOrWhiteSpace(ssnTextBox!.Text) || ssnTextBox.Text == "Random"
                ? Helper.GenerateRandomNumbers(1, "234567") + Helper.GenerateRandomNumbers(8)
                : ssnTextBox.Text;
            TestData.Url = urlTextBox!.Text;
            TestData.StateName = stateName;
            TestData.StateAbbreviation = stateAbbreviation;
            TestData.Zip = zipTextBox!.Text;
            TestData.Employer1 = employer1TextBox!.Text;
            TestData.Employer2 = employer2TextBox!.Text;
            TestData.useTwoEmployers = useSecondEmployerCheckBox!.IsChecked ?? false;
            TestData.FirstName = TestData.LastName = firstnameTextBox!.Text == "Random" && lastnameTextBox!.Text == "Random" ? Helper.GenerateRandomLetters(8) : firstnameTextBox.Text == "Random" ? Helper.GenerateRandomLetters(8) : firstnameTextBox.Text;
            TestData.LastName = lastnameTextBox!.Text == "Random" && firstnameTextBox.Text != "Random"
                ? Helper.GenerateRandomLetters(8)
                : lastnameTextBox.Text;
            TestData.DOB = dobTextBox!.Text;
            TestData.WorkBeginDate1 = employer1BeginDateTextBox!.Text;
            TestData.WorkEndDate1 = employer1EndDateTextBox!.Text;
            TestData.WorkBeginDate2 = employer2BeginDateTextBox!.Text;
            TestData.WorkEndDate2 = employer2EndDateTextBox!.Text;
            TestData.Username = "GSIUIAI" + Helper.GenerateRandomLetters(7) + (new[] { "PR" }.Any(site => TestData.StateAbbreviation!.Contains(site)) ? "01" : "1");
            TestData.Email = TestData.Username + "@geosolinc.com";
            TestData.SelectedPages = selectedPages;
        }
    }
}
