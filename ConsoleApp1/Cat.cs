using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Cat
    {
            private string name; // fields
            private int age;
            private string furColor;
            private bool isHungry = true;

            public string Name //useful to name property methods the same as the field it relates to 
            {
                get { return this.name; }
                //this means current instance of the class/references only the current instance
                set { this.name = value; }
            }
            public Cat() // default constructor 
            {

            }
            public Cat(string name, int age, string furColor) //loaded parameter
            {
                this.name = name;
                this.age = age;
                this.furColor = furColor;
            }
            public void Eat()
            {
                if (isHungry)
                {
                isHungry = false;
                }

            Console.WriteLine("Is the cat hungry? " + isHungry);
            }

    }
}
