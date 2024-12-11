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
        }
        private void ShowData_Click(object sender, RoutedEventArgs e)
        {
             // Явный конструктор
  Person person1 = new Person("Галкина Ирина Игоревна", "Женский", "Стриптезерша", 2, 100000m);
  ShowPersonInfo(person1);

  // // Неявный конструктор (значения по умолчанию)
  // Person person2 = new Person(); // все поля будут пустыми
  // // Заполнение person2
  // person2.fio = "Байков Дмитрий Евгеньевич";
  // person2.Gender = "Мужской";
  // person2.doljnost = "Поломойка";
  // person2.staj = 19;
  // person2.oklad = 2000m;
  // ShowPersonInfo(person2, "Person 2 :");
  Person person2 = new Person("Байков Дмитрий Евгеньевич", "Женский", "Поломойка", 18, 2000m);
  ShowPersonInfo(person2);
  Person person3 = new Person("Сухомяткина Ксения Игоревна", "Женский", "Стриптизерша",1, 80000m);
  ShowPersonInfo(person3);
  Person person4 = new Person("Исаев Арсений Вячеславович", "Мужской", "Фейс-контролер", 3, 15000m);
  ShowPersonInfo(person4);
  Person person5 = new Person("Дудина Екатерина Андеевна"  , "Женский", "Бармен", 5, 200000m);
  ShowPersonInfo(person5);
  Person person6 = new Person("Печников Роман Анжреевич", "Мужской", "заводила)", 10, 15000000000m);
  ShowPersonInfo(person6);
  Person person7 = new Person("Бандуркин Дмитрий Дмитриевич", "Мужской", "Рекламный менеджер", 5, 5000m);
  ShowPersonInfo(person7);
  Person person8 = new Person("Попов Глеб Евгеньевич", "Мужской", "БАРЫГА)))", 10, 5000000m);
  ShowPersonInfo(person8);
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
