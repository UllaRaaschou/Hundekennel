using Domain_Hundekennel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UllasHundeKennel.Model
{
    public class DogDescription
    {
        public EnumGender Gender { get; set; }
        public EnumBreedStatus BreedStatus { get; set; }
        public string Dad { get; set; }

        public string Mom { get; set; }
        public EnumColor Color { get; set; }
        public Boolean IsAlive { get; set; }
        
        public DateTime LastUpdated { get; set; }

        public DogDescription(EnumGender gender, EnumBreedStatus breedStatus, string dad, string mom, EnumColor color, string picturePath, DateTime lastUpdated, Boolean isAlive = true) 
        {
            Gender = gender;
            BreedStatus = breedStatus;
            Dad = dad;
            Mom = mom;
            Color = color;
            LastUpdated = lastUpdated;  
            IsAlive = isAlive;
        }
    }

}
