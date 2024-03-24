using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNORBIT
{
    public class IndexCalculation
    {
        public void InputData()
        {
            bool dataCorrect = false;
            float weight = 0.0f;
            float height = 0.0f;

            while (!dataCorrect)
            {
                try
                {
                    Console.WriteLine("Введите вес тела (в кг): ");
                    weight = float.Parse(Console.ReadLine());

                    Console.WriteLine("Введите свой рост (в см): ");
                    height = float.Parse(Console.ReadLine()) / 100;

                    if (weight <= 0 || height <= 0)
                    {
                        Console.WriteLine("Введены неверные данные, попробуйте ещё раз\n");
                    }
                    else
                    {
                        dataCorrect = true;
                    }
                } 
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message + "\n");
                }
            }
           

            float bodyMassIndex = (float)(weight / Math.Pow(height, 2));
            bodyMassIndex = (float)Math.Round(bodyMassIndex, 1);

            string result = "";

            if (bodyMassIndex > 0 && bodyMassIndex < 18.5f)
            {
                result = "ИМТ = " + bodyMassIndex + " - Ниже нормального";
            }
            else if (bodyMassIndex >= 18.5 && bodyMassIndex < 25)
            {
                result = "ИМТ = " + bodyMassIndex + " - Нормальный";
            }
            else if (bodyMassIndex >= 25)
            {
                result = "ИМТ = " + bodyMassIndex + " - Выше нормального";
            }
            else
            {
                result = "Ошибка в расчетах, проверьте корректность данных ";
            }
            Console.WriteLine(result);
        }
    }
}
