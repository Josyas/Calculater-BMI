namespace BmiOp.Entities
{
    class Bmi
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        
        public Bmi(string Name, int Age, double Height, double Weight)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
            this.Weight = Weight;
        }
    }
}      

