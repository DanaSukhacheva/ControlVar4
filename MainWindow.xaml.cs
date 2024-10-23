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

namespace Pr22_102_Suhacheva_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // не работает проверка, на любом языке выводит "Invalid enter", поэтому я её закоментила

            string input = TextBox.Text.Trim();

            
                string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string result = "";
            /*if (!IfItEnglish(input))
            {
                TextBlock.Text = "Invalid enter";
                return;
            }*/
           
                foreach (string word in words)
                {
                    if (word.Length > 1)
                    {
                        string transformedWord = char.ToUpper(word[0]) + word.Substring(1, word.Length - 2).ToLower() + char.ToUpper(word[word.Length - 1]);
                        result += transformedWord + " это_пробел ";
                    }
                    else
                    {
                        result += char.ToUpper(word[0]) + " это_пробел ";
                    }

                }
                TextBlock.Text = result.Trim();

                return;
            
            
        }
        private bool IfItEnglish(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && c != ' ')
                    continue;


                if ((c < 'A' || c > 'Z') && (c < 'a' || c > 'z'))
                {
                    return false;
                }
            }
            return true;

        }
    }
 }


