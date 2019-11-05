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
            if ((bool)radioButton.IsChecked)
            {
                textBox2.Text = (int.Parse(textBox.Text) % int.Parse(textBox1.Text)).ToString();
            }

            if ((bool)radioButton_Copy.IsChecked)
            {
                textBox2.Text = Math.Pow(int.Parse(textBox.Text), int.Parse(textBox1.Text)).ToString();
            }

            if ((bool)radioButton_Copy1.IsChecked)
            {
                textBox2.Text = textBox.Text + textBox1.Text;
            }

            if ((bool)radioButton_Copy2.IsChecked)
            {
                textBox2.Text = (int.Parse(textBox.Text) / int.Parse(textBox1.Text)).ToString();
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
