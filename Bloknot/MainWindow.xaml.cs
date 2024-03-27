using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Bloknot
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                string textToSave = TextBox.Text;
                string filePath = saveFileDialog.FileName;

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(textToSave);
                }

                MessageBox.Show("Файл сохранен");
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                using (StreamReader sr = new StreamReader(filePath))
                {
                    TextBox.Text = sr.ReadToEnd();
                }
            }
        }
        private void SelectFonts_Click(object sender, RoutedEventArgs e)
        {
            //FontDialog fontDialog = new FontDialog();

            //if (fontDialog.ShowDialog() == true)
            //{
            //    TextBox.FontFamily = new FontFamily(fontDialog.FontFamily.Name);
            //    TextBox.FontSize = fontDialog.FontSize;
            //    TextBox.FontWeight = fontDialog.FontWeight;
            //    TextBox.FontStyle = fontDialog.FontStyle;
            //}

        }
    }
}