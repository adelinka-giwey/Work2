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

namespace Work2
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            if(!int.TryParse(NumberATextBox.Text, out int a) || !int.TryParse(NumberBTextBox.Text, out int b) || a < 0 || b < 0)
            {
                MessageBox.Show("Введите числа больше 0");
                return;
            }
            else if(a < b)
            {
                MessageBox.Show("Число А должно быть больше B");
            }

            int answer = a / b;

            AnswerTextBox.Text = $"Число отрезков: {answer}";
        }
    }
}
