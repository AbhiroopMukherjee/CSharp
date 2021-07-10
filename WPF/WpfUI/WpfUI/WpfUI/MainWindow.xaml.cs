﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            people.Add(new Person {FirstName = "Abhiroop",LastName = "Mukherjee"});
            people.Add(new Person { FirstName = "kalyan", LastName = "Ghosh" });
            people.Add(new Person { FirstName = "Rahul", LastName = "Bose" });

            myComboBox.ItemsSource = people;
        }

        private void onClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstNameBox.Text}");
        }
    }
}
