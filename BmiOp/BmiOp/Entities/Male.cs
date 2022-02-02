using System;
using System.Globalization;
namespace BmiOp.Entities
{
    class Male : Bmi
    {
        public Male(string Name, int Age, double Height, double Weight) : base(Name, Age, Height, Weight)
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
            if (Result() < 20.7)
            {
                Console.Write(this.Name + ", Result: Your BMI: UnderWeight -> ");
            }
            else if (Result() < 26.4)
            {
                Console.Write(this.Name + ", Result: Your BMI: Ideal weight -> ");
            }
            else if (Result() < 27.8)
            {
                Console.Write(this.Name + ", Result: Your BMI: Slightly overweight -> ");
            }
            else if (Result() < 31.2)
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
