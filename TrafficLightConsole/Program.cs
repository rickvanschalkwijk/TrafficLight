using System;

namespace TrafficLightConsole
{
    class Program
    {
        private static TrafficLight lightOne;
        private static TrafficLight lightTwo;
        private static TrafficLight lightThree;
        private static TrafficLight lightFour;

        static void Main(string[] args)
        {

            InitStates();

            while (true)
            {
                Console.WriteLine("type traffic light number:"); 
                string line = Console.ReadLine(); 

                // change to 
                switch (line)
                {
                    case "1":
                        // los trekken naar method
                        // traffic light object meegeven

                        lightOne.Request();
                        lightTwo.Reset();
                        lightThree.Reset();
                        ReportAllStates();
                        break;
                    case "2":
                        lightOne.Reset();
                        lightTwo.Request();
                        ReportAllStates();
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                }

            }
        }

        private static void ReportAllStates()
        {
            Console.WriteLine("light 1: {0}", lightOne.ReportState());
            Console.WriteLine("light 2: {0}", lightTwo.ReportState());
            Console.WriteLine("light 3: {0}", lightThree.ReportState());
            Console.WriteLine("light 4: {0}", lightFour.ReportState());
        }

        private static void InitStates()
        {
            lightOne = new TrafficLight();
            Console.WriteLine("light 1: {0}", lightOne.ReportState());

            lightTwo = new TrafficLight();
            Console.WriteLine("light 2: {0}", lightTwo.ReportState());

            lightThree = new TrafficLight();
            Console.WriteLine("light 3: {0}", lightThree.ReportState());

            lightFour = new TrafficLight();
            Console.WriteLine("light 4: {0}", lightFour.ReportState());
        }
    }
}
