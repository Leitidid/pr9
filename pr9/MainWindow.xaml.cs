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
        private ObservableCollection<Person> peoples;//Это коллекция, которая будет хранить
                                                     //информацию о людях.Она используется для привязки данных
                                                     //к интерфейсу. ObservableCollection используется,
                                                     //потому что если данные в ней изменятся, WPF автоматически обновит отображение.

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
            Person person2 = new Person("Байков Дмитрий Евгеньевич", "Женский", "Поломойка", 18, 2000m);
            ShowPersonInfo(person2);
            Person person3 = new Person("Сухомяткина Ксения Игоревна", "Женский", "Стриптизерша", 1, 80000m);
            ShowPersonInfo(person3);
            Person person4 = new Person("Исаев Арсений Вячеславович", "Мужской", "Фейс-контролер", 3, 15000m);
            ShowPersonInfo(person4);
            Person person5 = new Person("Дудина Екатерина Андеевна", "Женский", "Бармен", 5, 200000m);
            ShowPersonInfo(person5);
            Person person6 = new Person("Печников Роман Анжреевич", "Мужской", "заводила)", 10, 150000m);
            ShowPersonInfo(person6);
            Person person7 = new Person("Бандуркин Дмитрий Дмитриевич", "Мужской", "Рекламный менеджер", 5, 150000m);
            ShowPersonInfo(person7);
            Person person8 = new Person("Попов Глеб Евгеньевич", "Мужской", "БАРЫГА)))", 10, 30000m);
            ShowPersonInfo(person8);
            List<Person> allPersons = new List<Person>() { person1, person2, person3, person4, person5, person6, person7, person8 };
            //List <T> Создает динамический массив. Обеспечивает такие же 
            //функциональные возможности, как и необобщенный класс ArrayList
            //<T> указывают, что класс является 
            //обобщенным, а тип T, заключенный в угловые скобки, будет использоваться этим
            //классом.
            if (allPersons.Count == 0)
            {
                MessageBox.Show("нет данных для расчета");
                return;
            }
            decimal sumofOklad = allPersons.Sum(person => person.oklad);
            decimal okladik = sumofOklad / allPersons.Count;
            txtOkadika.Text = "Средний оклад" + okladik;
        }


        private void ShowPersonInfo(Person person, string prefix = "")
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{prefix} ФИО: {person.fio}");
            sb.AppendLine($"{prefix} Пол: {person.Gender}");
            sb.AppendLine($"{prefix} Должность: {person.doljnost}");
            sb.AppendLine($"{prefix} Стаж: {person.staj}");
            sb.AppendLine($"{prefix} Оклад: {person.oklad:C}");//:с валюта
            txtOutput.Text += sb.ToString() + Environment.NewLine; //Environment.NewLine добавляет перевод строки.

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string developer = "Дудина Екатерина";
            int job = 9;
            string task = " Заполнить таблицу со списком сотрудников на 7 человек с полями: ФИО, пол, \r\nдолжность, стаж работы, оклад. Вывести результат на экран. Вывести средний \r\nоклад.\r\n";
            MessageBox.Show($"Разработчик: {developer}\nНомер работы: {job}\nЗадание: {task}", "О программе");
        }
        // "Выход"
        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

