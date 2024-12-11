using System.Collections.ObjectModel;
using System;
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
using tabl;
using static tabl.Class1;

namespace pr9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> peoples;

        public MainWindow()
        {
            InitializeComponent();
            peoples = new ObservableCollection<Person>();
             dataGridPeople.ItemsSource = peoples;


            
        }
        private void ShowData_Click(object sender, RoutedEventArgs e)
        {
            // Явный конструктор
            Person person1 = new Person("Иванов Иван Иванович", "Мужской", "Программист", 5, 100000m);
            ShowPersonInfo(person1);


            // Неявный конструктор (значения по умолчанию)
            Person person2 = new Person(); // все поля будут пустыми
            ShowPersonInfo(person2, "Person 2 (Неявный конструктор):");


            // Заполнение person2
            person2.fio = "Петрова Анна Сергеевна";
            person2.Gender = "Женский";
            person2.doljnost = "Дизайнер";
            person2.staj = 3;
            person2.oklad = 80000m;
            ShowPersonInfo(person2, "Person 2 (после заполнения):");


            // Добавление в DataGrid
            peoples.Add(person1);
            peoples.Add(person2);

        }

        private void ShowPersonInfo(Person person, string prefix = "")
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{prefix} ФИО: {person.fio}");
            sb.AppendLine($"{prefix} Пол: {person.Gender}");
            sb.AppendLine($"{prefix} Должность: {person.doljnost}");
            sb.AppendLine($"{prefix} Стаж: {person.staj}");
            sb.AppendLine($"{prefix} Оклад: {person.oklad:C}");
            txtOutput.Text += sb.ToString() + Environment.NewLine;

        }

        private void BtnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ФИО разработчика: [Ваше ФИО]\nНомер работы: [Номер работы]\nФормулировка задания: [Формулировка задания]", "О программе");
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}