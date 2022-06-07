using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class Animal
    {
        public static int AnimalId;

        public int Id;

        private int NumberOfLegs;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
          
        private string _Name;
        public string Sound { get; set; } = "Roar";

        public Animal()
        {
            Id = AnimalId;
            AnimalId++;
        }

        public Animal(int numberOfLegs, string name, string sound)
        {
            NumberOfLegs = numberOfLegs;
            _Name = name;
            Sound = sound;

            Id = AnimalId;
            AnimalId++;
        }

        public void MakeSound()
        {
            Console.WriteLine(this.Sound);
        }

        public int GetNumberOfLegs()
        {
            return NumberOfLegs;
        }

        public void SetNumberOfLegs(int numberOfLegs)
        {
            if (numberOfLegs < 2)
            {
                throw new ArgumentException("Hey Animals Can't have less than 2 legs");
            }

            NumberOfLegs = numberOfLegs;
        }
    }
}
