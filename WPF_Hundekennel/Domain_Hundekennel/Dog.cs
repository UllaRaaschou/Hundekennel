using Domain_Hundekennel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UllasHundeKennel.Model
{
    public class Dog
    {
        public Dog(string lineage, string name, string identifier, DateTime dateOfBirth, DateTime dateAdded, EnumGender gender, EnumBreedStatus breedStatus, string dad, string mom, EnumColor color, string image, DateTime lastUpdated, string hipDysplacia, string elbowDysplacia, string spondylose, string heartCondition, Boolean isAlive = true)
        
        {
            
            Lineage = lineage;
            Name = name;
            Identifier = identifier;
            DateOfBirth = dateOfBirth;
            DateAdded = dateAdded;
            Image = image;
            DogDescription = new DogDescription(gender, breedStatus, dad, mom, color, image, lastUpdated);
            Health = new Health(hipDysplacia, elbowDysplacia, spondylose, heartCondition);
                       
        }

        
        public string Lineage { get; private set; }
        public string Name { get; private set; }
        public string Identifier { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public DateTime DateAdded { get; private set; }
        public string Image { get; private set; }
        public DogDescription DogDescription { get; private set; }
        public Health Health { get; private set; }
    }
}
