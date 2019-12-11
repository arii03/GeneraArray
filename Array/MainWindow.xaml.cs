using System;
using System.Collections.Generic;
using System.IO;
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

namespace Array
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();

            string line;
            StreamReader sr = new StreamReader("array.txt");
            while ((line = sr.ReadLine()) != null)
            {
                int n = int.Parse(line);
            }
        }

        private void btnGenera_Click(object sender, RoutedEventArgs e)
        {
            int lunghezza = int.Parse(txtPositivo.Text);
            int[] array = new int[1];
            for (int x = 0; x < array.Length; x++)
            {
                array[x] = random.Next();
            }
            lblArray.Content += "[";
            for (int x = 0; x < array.Length; x++)
            {
                if (x <= array.Length - 2)
                    lblArray.Content += $"{array[x]}";
                else
                {
                    lblArray.Content += $"{array[x]}";
                }
            } 
            lblArray.Content += "]";

            string file = @"array.txt";
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine(array.Length);
            for (int x = 0; x < array.Length; x++)
            {
                sw.WriteLine(array[x]);
            }
            sw.Flush();
            sw.Close();
        }
    }
}
