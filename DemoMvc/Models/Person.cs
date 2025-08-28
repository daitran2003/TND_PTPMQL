namespace DemoMvc.Models
{
    public class Person
    {
        public required String Name { get; set; }
        public int BirthYear { get; set; }
        public int Age 
        {
            get
            {
                return DateTime.Now.Year - BirthYear;
            }
        }
    }
}
