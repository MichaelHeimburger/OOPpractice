using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{

    class Dog
    {
        private int hairLength;
        private int height;
        private int runningSpeed;
        private int weight;

        public int HairLength //properties get/set for each they are the tools differnt from constructors and methods
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public string Name { get; set; }
        public int RunningSpeed { get { return this.runningSpeed; }  set { this.runningSpeed = value; } } //prop tab is shortcut like this

        public int Weight
        {
            get {  return this.weight; }
            set { this.weight = value; }
        }

        // ctr tab tabcut is short cut for constructor
        public Dog() //default constructor
        {

        }
        public Dog(int hairLength, int height, int weight, int runningSpeed) //input parameters constructor? loaded constructor
        { //the paramater hairlength is differnt from the field hairlength which is differnt from the property hairlength
            this.hairLength = hairLength;
            this.height = height;
            this.weight = weight;
            this.runningSpeed = runningSpeed;
        }
        public void Run() //methods
        {
            Console.Write("your dog can run{0} miles per hour", runningSpeed);
        }
        public void FavFood(string[] food)
        {

            Console.WriteLine("{0} favorite foods are: ", Name);
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }

        }
        public void Bark()
        {

        }
        public void Potty()
        {

        }
        public void Cuddle()
        {

        }
    }
}
