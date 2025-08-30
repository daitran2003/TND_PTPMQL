namespace DemoMvc.Models
{
    public class BMI
    {
        public double Height { get; set; }   // Chiều cao 
        public double Weight { get; set; }   // Cân nặng 
        public double Result { get; set; }   // Kết quả

        public required string Category { get; set; }   
    }
}
