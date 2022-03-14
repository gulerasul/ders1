using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Car:Vehicle
    {
        public string brand;
        public string model;
        public double FuelCapacity;
        public double FuelFor1km;
        public double CurrentFuel;

        public Car(int year,string brand,string model,double FuelCapacity,double FuelFor1km):base(year) 
        {
            this.brand = brand;
            this.model = model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1km = FuelFor1km;
        }
        public Car(int year, string brand, string model, double FuelCapacity, double FuelFor1km,double CurrentFuel):this(year,brand,model,FuelCapacity,FuelFor1km)
        {
            this.CurrentFuel = CurrentFuel;
        }
        public Car(int year, string brand, string model, double FuelCapacity, double FuelFor1km, double CurrentFuel,string color):this(year, brand, model, FuelCapacity, FuelFor1km,CurrentFuel )
        {
            this.color = color;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Mashinin markasi :" +brand);
            Console.WriteLine("Mashinin modeli :" + model);
            Console.WriteLine("Mashinin bezin tutumu  :" + FuelCapacity);
            Console.WriteLine("Mashinin 1km uchun yanacaq serfiyyati :" + FuelFor1km);
            Console.WriteLine("Mashinin movcud olan yanacaq :" + CurrentFuel);
            Console.WriteLine("Mashinin rengi :"+color);
        }


    }
    
}
