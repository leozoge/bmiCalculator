using System;

namespace bmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name (Digite seu nome):");
            String Name = Console.ReadLine();

            Console.WriteLine("Enter your weight (Digite seu peso):");
            String weightInString = Console.ReadLine();
            decimal weightInDecimal = Convert.ToDecimal(weightInString);

            Console.WriteLine("Enter your height (Digite sua altura):");
            String heightInString = Console.ReadLine();
            decimal heightInDecimal = Convert.ToDecimal(heightInString);

            decimal heightSquared = heightInDecimal * heightInDecimal;

            decimal bmi = weightInDecimal / heightSquared;
            Console.WriteLine("BMI (IMC): " + bmi);

            if (bmi <= 18.5m)
            {
                Console.WriteLine("Underweight (Abaixo do peso) " + Name);
            }

            if(bmi >= 18.5m && bmi <= 25)
            {
                Console.WriteLine("Normal weight (Peso normal) " + Name);
            }

            if(bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Overweight (Acima do peso) " + Name);                
            }

            if(bmi >= 30)
            {
                Console.WriteLine("Obesity (Obesidade) " + Name);
            }
            Console.ReadLine();

        //FORMULA BMI= weight/height²//
        //FÓRMULA IMC= peso/altura²//
        }
    }
}
