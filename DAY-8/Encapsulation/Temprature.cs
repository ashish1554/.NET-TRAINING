using System;
using System.Collections;
using System.Collections.Generic;
public class TemperatureSensor
{
    private float temp;
    private List<float> history = new List<float>();

    //public TemperatureSensor() { }
    //public TemperatureSensor(float temp)
    //{
    //    Temp = temp;
    //}
    public float Temp
    {
        get { return temp; }
        set
        {
            if (value < 0) Console.WriteLine("Temprature below absolute zero is now allowed");
            else
            {
                temp = value;
                history.Add(temp);
            }
        }
    }

    public List<float> History
    {
        get
        {
            return history;
        }
    }
    public void Display()
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("History of temprature :-");
        Console.WriteLine("-------------------------------------------------");

        foreach (var item in history)
        {
            Console.Write(item+" ");
        }

    }

    public class Program
    {

        public static void Main(string[] args)
        {
        TemperatureSensor Obj = new TemperatureSensor();

            string? userinput;
            float temp;

            do
            {
                Console.WriteLine("Enter temrature in celsius if want to exit press 0");
                userinput = Console.ReadLine();
                if (!float.TryParse(userinput, out temp))
                {
                    Console.WriteLine("Enter valid temprature");
                    return;
                }
                if (temp == 0)
                {
                    break;
                }
                Obj.Temp= temp;
            } while (true);
        

            Obj.Display();
         
        }

    }
}