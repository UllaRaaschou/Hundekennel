﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Hundekennel.ViewModel
{
    class CollectionViewModel
    {
        #region ListeAfPersoner
        public List<Dog> Dogs { get; set; } 
            = new List<Dog> 
            { 
            new Dog{ DogName = "Buster", DogGender = "Han"},
            new Dog{ DogName = "Medister", DogGender = "Han"},
            new Dog{ DogName = "Kaffe", DogGender = "Tæve"},
            };
        #endregion

        #region SelectedDog
        public Dog SelectedDog { get; set; }

        #endregion
    }
    // OBS FØLGENDE KLASSE ER EN TEST KLASSE OG IKKE ENDELIG IMPLEMENTERING
    class Dog
    {
        public string DogName { get; set; }
        public string DogGender { get; set; }

        
    }
}