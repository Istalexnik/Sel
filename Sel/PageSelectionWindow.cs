﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Sel.Enums;

namespace Sel
{
    public class PageSelectionWindow : Window
    {
        private ListBox? pageSelectionListBox;
        private Button? okButton;

        public List<PageType>? SelectedPages { get; private set; }

        public PageSelectionWindow()
        {
            this.Title = "Select Pages to Pause";
            this.Width = 300;
            this.Height = 400;
            this.ResizeMode = ResizeMode.NoResize;
            this.WindowStyle = WindowStyle.SingleBorderWindow;

            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Grid grid = new Grid();
            this.Content = grid;

            // Define rows and columns
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }); // ListBox
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // OK Button

            // ListBox for selecting pages
            pageSelectionListBox = new ListBox
            {
                SelectionMode = SelectionMode.Multiple,
                Margin = new Thickness(10)
            };

            foreach (var page in Enum.GetValues(typeof(PageType)))
            {
                pageSelectionListBox.Items.Add(page);
            }

            Grid.SetRow(pageSelectionListBox, 0);
            grid.Children.Add(pageSelectionListBox);

            // OK Button
            okButton = new Button
            {
                Content = "OK",
                Width = 100,
                Height = 30,
                Margin = new Thickness(10),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Bottom
            };
            okButton.Click += OkButton_Click;

            Grid.SetRow(okButton, 1);
            grid.Children.Add(okButton);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            // Store the selected pages
            SelectedPages = pageSelectionListBox!.SelectedItems.Cast<PageType>().ToList();
            this.DialogResult = true;
            this.Close();
        }
    }
}
