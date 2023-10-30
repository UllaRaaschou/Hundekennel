using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UllasHundeKennel.Model
{
    public class Dog
    {
        public Dog(string name, string pedigree, string tatoo, DateTime dOB, DateTime dateAdded, string sex, string statusOfBreed, string father, string mother, string colour, string picturePath, DateTime updated, Boolean dead = false)
        
        {
            Name = name;
            Pedigree = pedigree;
            Tatoo = tatoo;
            DOB = dOB;
            DateAdded = dateAdded;
            DogDescription = new DogDescription(this, sex, statusOfBreed, father, mother, colour, picturePath, updated);
                       
        }

        public string Name { get; private set; }
        public string Pedigree { get; private set; }
        public string Tatoo { get; private set; }
        public DateTime DOB { get; private set; }
        public DateTime DateAdded { get; private set; }
        public DogDescription DogDescription { get; private set; }
    }
}
