using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace Cross
{
    //UI Made By ilycross & .mr_violet. 
    //Any use of the ui must give credit to the creators.
    //The ui was leaked because Cross was betrayed & used by the owner and other dev of bleach 

    public partial class MainWindow : Window
    {
        private string folderPath = "Bleach/Scripts";

        public MainWindow()
        {
            InitializeComponent();
            CreateFolder("Bleach/Scripts");
            Load();
        }

        public void CreateFolder(string folderName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string folderPath = System.IO.Path.Combine(currentDirectory, folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private void Load()
        {
            textEditor.Text = "--[[ \r\n\tWelcome To Bleach Beta Made By ilycross\r\n\tDiscord: discord.gg/term disocrd.gg/vexhub\r\n--]]";
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bool drag = Mouse.LeftButton == MouseButtonState.Pressed;
            if (drag)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //Extra
        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            textEditor.Clear();
        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            //Removed by cross
        }

        private void Button_LoadScript(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = System.IO.Path.GetDirectoryName(Environment.ProcessPath),
                Title = "Open"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string fileContent = File.ReadAllText(openFileDialog.FileName);
                    textEditor.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void FilesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Removed by cross
        }

        private void Button_Kill(object sender, RoutedEventArgs e)
        {
            //Removed by cross
        }

        private void Button_Reload(object sender, RoutedEventArgs e)
        {
            ReloadFiles();
        }

        private void ReloadFiles()
        {
            //Removed by cross
        }

        //Inject & Execute
        private void Button_Execute(object sender, RoutedEventArgs e)
        {
            //Removed by cross
        }

        private void Button_Inject(object sender, RoutedEventArgs e)
        {
            //Removed by cross
        }
    }
}