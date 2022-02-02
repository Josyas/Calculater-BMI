using System;
using System.Globalization;
namespace BmiOp.Entities
{
    class Female : Bmi
    {
        public Female(string Name, int Age, double Height, double Weight) : base(Name, Age, Height, Weight)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
            this.Weight = Weight;
        }

        public double Result()
        {
            return Weight / (Height * Height);
        }               
                 
        public override string ToString()
        {
            if (Result() < 19.1)
            {
                Console.Write(this.Name + ", Result: Your BMI: UnderWeight -> ");
            }
            else if (Result() < 25.8)
            {
                Console.Write(this.Name + ", Result: Your BMI: Ideal weight -> ");
            }
            else if (Result() < 27.3)
            {
                Console.Write(this.Name + ", Result: Your BMI: Slightly overweight -> ");
            }
            else if (Result() < 32.3)
            {
                Console.Write(this.Name + ", Result: Your BMI: Overweight -> ");
            }
            else
            {
                Console.WriteLine(this.Name + ", Obesity ->");
            }

            return Result().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
