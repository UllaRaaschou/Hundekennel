using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UllasHundeKennel.Model
{
    public class DogDescription
    {
        public Dog Dog { get; private set; }
        public string Sex { get; set; }
        public string StatusofBreed { get; set; }
        public string Father { get; set; }

        public string Mother { get; set; }
        public string Colour { get; set; }
        public Boolean Dead { get; set; }
        public string PicturePath { get; set; }

        public DateTime Updated { get; set; }

        public DogDescription(Dog dog, string sex, string statusOfBreed, string father, string mother, string colour, string picturePath, DateTime updated, Boolean dead = false) 
        {
            Dog = dog;
            Sex = sex;
            StatusofBreed = statusOfBreed;
            Father = father;
            Mother = mother;
            Colour = colour;
            PicturePath = picturePath;
            Updated = updated;  
            Dead = dead;
        }
    }

}
