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

namespace KSBL_Task_1_2_Wpf_App
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("[0 ; 255]"); //byte
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("[-128 ; 127]"); //sbyte
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("[-32,768 ; 32,767]"); //short
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("[0 ; 65,535]"); //ushort
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("[-2,147,483,648 ; 2,147,483,647]"); //int
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("[0 ; 4,294,967,295]"); //uint
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("[-9,223,372,036,854,775,808 ; 9,223,372,036,854,775,807]"); //long
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("[0 ; 18,446,744,073,709,551,615]"); //ulong

        }
    }
}
