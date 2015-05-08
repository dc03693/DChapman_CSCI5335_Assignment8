/*Created by:  David Chapman
 * CSCI 5335 Assignment 8:  Facade Pattern
 * 3/7/2015
 * Revisions:
 * 
 * 
 * <Summary>
 * Implementation of facade pattern design using remote car starter.
 * The StartCarFacade contains methods to control AC, stereo, windows,
 * and sun roof depending on the temperture outside.
 * <Summary>
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DChapman_CSCI5335_Assignment8
{
    class Program
    {
        //The facade class
        public class StartCarFacade
        {
            //Composed of subsystems
            public AC ac = new AC();
            public Stereo stereo = new Stereo();
            public Windows windows = new Windows();
            public SunRoof sunRoof = new SunRoof();

            public StartCarFacade()
            {
                
            }
            //Warm weather controls:
            public void StartCarSummer()
            {
                Console.WriteLine("Cranking Car...");
                ac.CoolOn();
                stereo.On();
                windows.Down();
                sunRoof.Open();
            }
            public void StopCarSummer()
            {
                Console.WriteLine("Turning Car off...");
                ac.Off();
                stereo.Off();
                windows.Crack();
                sunRoof.Close();
            }
            //Cold weather controls:
            public void StartCarWinter()
            {
                Console.WriteLine("Cranking Car...");
                ac.HeatOn();
                ac.Defrost();
                stereo.On();
            }
            public void StopCarWinter()
            {
                Console.WriteLine("Turning Car off...");
                ac.Off();
                stereo.Off();
                windows.Up();
                sunRoof.Close();
            }
        }
        //Air Conditioner class
        public class AC
        {
            public AC() { }
            public void HeatOn()
            {
                Console.WriteLine("Heat on.");
            }
            public void Defrost()
            {
                Console.WriteLine("Defroster on.");
            }
            public void CoolOn()
            {
                Console.WriteLine("Cool air on.");
            }
            public void Off()
            {
                Console.WriteLine("AC off.");
            }
        }
        //Stereo class
        public class Stereo
        {
            public Stereo() { }
            public void On()
            {
                Console.WriteLine("Stereo on.");
            }
            public void Off()
            {
                Console.WriteLine("Stereo off.");
            }
        }
        //Windows class
        public class Windows
        {
            public Windows() { }
            public void Up()
            {
                Console.WriteLine("Windows up.");
            }
            public void Down()
            {
                Console.WriteLine("Windows down.");
            }
            public void Crack()
            {
                Console.WriteLine("Windows cracked.");
            }
        }
        //Sun roof class
        public class SunRoof
        {
            public SunRoof() { }
            public void Open()
            {
                Console.WriteLine("Sunroof open.");
            }
            public void Close()
            {
                Console.WriteLine("Sunroof closed.");
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Assignment 8:  Facade Pattern";
            StartCarFacade starter = new StartCarFacade();
            //Start car in warm weather:
            Console.WriteLine("*****Warm Weather*****");
            starter.StartCarSummer();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("*****Warm Weather*****");
            starter.StopCarSummer();
            Console.WriteLine();
            Console.ReadKey();

            //Starting car in cold weather:
            Console.WriteLine("*****Cool Weather*****");
            starter.StartCarWinter();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("*****Cool Weather*****");
            starter.StopCarWinter();
            Console.ReadKey();

        }
    }
}
