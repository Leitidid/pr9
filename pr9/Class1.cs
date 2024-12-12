
namespace tabl
{
    public class Class1
    {
        public struct Person
        {
            public string fio;
            public string Gender;
            public string doljnost;
            public int staj;
            public decimal oklad;  // Оклад
            public Person(string fio, string gender, string doljnost, int staj, decimal oklad)
            {
                this.fio = fio;
                this.Gender = gender;
                this.doljnost = doljnost;
                this.staj = staj;
                this.oklad = oklad;
            }
        }
    }
    
}



