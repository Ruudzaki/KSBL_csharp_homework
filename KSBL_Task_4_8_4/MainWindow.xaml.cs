using System;
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

namespace KSBL_Task_4_8_4
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

        private void radioButton_Copy_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int result1, result2;

            if ((bool)radioButton.IsChecked)
            {
                if (int.TryParse(textBox.Text, out result1) && int.TryParse(textBox1.Text, out result2))
                {
                    if (result2 != 0)
                    {
                        textBox2.Text = (result1 % result2).ToString();
                    }
                    else
                    {
                        textBox2.Text = "Undefined";
                    }
                }
            }

            if ((bool)radioButton_Copy.IsChecked)
            {
                if (int.TryParse(textBox.Text, out result1) && int.TryParse(textBox1.Text, out result2))
                {
                    textBox2.Text = Math.Pow(result1, result2).ToString();
                }
            }

            if ((bool)radioButton_Copy1.IsChecked)
            {
                textBox2.Text = textBox.Text + textBox1.Text;
            }

            if ((bool)radioButton_Copy2.IsChecked)
            {
                if (int.TryParse(textBox.Text, out result1) && int.TryParse(textBox1.Text, out result2))
                {
                    if (result2 != 0)
                    {
                        textBox2.Text = (result1 / result2).ToString();
                    }
                    else
                    {
                        textBox2.Text = "Undefined";
                    }
                }
            }

        }

        private void radioButton_Copy1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton_Copy2_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
