using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace JewelryStore
{
    /// <summary>
    /// Interaction logic for Form2.xaml
    /// </summary>
    public partial class Form2 : Window
    {
        private readonly double _discountValue;

        public Form2(string userType)
        {
            InitializeComponent();

            try
            {
                _discountValue = int.Parse(ConfigurationManager.AppSettings["discount"]);
                WelcomeLabel.Content = "Welcome: " + userType + " User";

                if (userType == "Normal")
                {
                    DiscountLabel.Visibility = Visibility.Hidden;
                    DiscountTextBlock.Visibility = Visibility.Hidden;
                    _discountValue = 0;
                }
                else if (userType == "Privileged")
                {
                    DiscountTextBlock.Text = _discountValue + " %";
                }
                else
                {
                    MessageBox.Show("Invalid customer type");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {

            TotalPriceTextBlock.Text = VerifyAndCalculatePrice().ToString();
        }

        private void PTSButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(VerifyAndCalculatePrice().ToString());
        }

        private void PTFButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string path = ConfigurationManager.AppSettings["resultFilePath"];
                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();
                    using (TextWriter tw = new StreamWriter(path))
                    {
                        tw.WriteLine("The Total Price is ------" + VerifyAndCalculatePrice().ToString());
                    }
                }
                else if (File.Exists(path))
                {
                    using var tw = new StreamWriter(path, true);
                    tw.WriteLine("The Total Price is ------" + VerifyAndCalculatePrice().ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void PTPButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }


        private double VerifyAndCalculatePrice()
        {
            try
            {
                if (string.IsNullOrEmpty(GoldPriceTextBox.Text) || string.IsNullOrEmpty(WeightTextBox.Text))
                {
                    MessageBox.Show("Enter Some Price and weight");
                    return 0;
                }

                double goldPrice;
                double weight;
                try
                {
                    goldPrice = double.Parse(GoldPriceTextBox.Text);
                    weight = double.Parse(WeightTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter valid double values. Exception " + ex.Message);
                    return 0;
                }

                var discountPrice = _discountValue / 100 * (goldPrice * weight);
                var totalPrice = (goldPrice * weight) - discountPrice;

                return totalPrice;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            
        }

    }
}