using System.Windows;

namespace modul10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string[] SplitText(string Text) //метод разбивки предложения на массив слов
        {
            string[] TextToMass = Text.Split(' '); //разделение предложения символом пробела
            return TextToMass; //возврат массива значения
        }
               
        static string ReverseWords(string inputPhrase) //метод представления предложения словами наоборот
        {
            string reverseText = null; //присвоение текстовой переменной нулл-значения
            string[] ReverseMass = SplitText(inputPhrase); //разивка предложения на слова, запись в массив            
            for (int i = ReverseMass.Length - 1; i >= 0; i--) //цикл записи слов в обратном порядке
            {
                reverseText = $"{reverseText} {ReverseMass[i]}";
            }
            return reverseText; //возврат текстовой переменной предложения словами наоборот
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e) //обработка нажатия кнопки button1
        {            
            string TextToSplit = textBox1.Text; //извлечение текста из textBox1 в переменную TextToSplit
            string[] OutputMass = SplitText(TextToSplit); //применение метода разбивки предложения на массив слов
            listBox1.ItemsSource = OutputMass; //вывод массива слов в listBox1           
        }

        private void button2_Click(object sender, RoutedEventArgs e) //обработка нажатия кнопки button2
        {            
            string TextToReverse = textBox2.Text; //извлечение текста из textBox2 в переменную TextToReverse
            label1.Content = ReverseWords(TextToReverse); //вывод массива слов в label1         
        }
    }
}
