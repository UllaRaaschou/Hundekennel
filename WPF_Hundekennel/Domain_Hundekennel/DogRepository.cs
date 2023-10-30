using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UllasHundeKennel.Model
{
    public class DogRepository

    {
        private string connectionString = "Server=10.56.8.36;Database=DB_F23_TEAM_05;User Id=DB_F23_TEAM_05;Password=TEAMDB_DB_05";

        public Dog Dog { get; private set; }
        public DogRepository(Dog dog) 
        {
            Dog = dog;
        }

        // skal der være en metode, som opreter en hund ud fra bruger-input?
        public void AddDog(Dog dog) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string INSERTsql = "INSERT INTO Dog (Name, Pedigree, Tatoo, DOB, DateAdded, Sex, StatusOfBreed, Father, Mother, Colour, PicturePath, Updated, Dead)" +
                    "VALUES(@name, @pedigree, @tatoo, @dOB, @dateAdded, @sex, @statusOfBreed, @father, @mother, @colour, @picturePath, @updated, @dead)";
                using (SqlCommand cmd = new SqlCommand()) 
                {
                    string name = dog.Name;
                    string pedigree = dog.Pedigree;
                    string tatoo = dog.Tatoo;
                    DateTime dOB = dog.DOB;
                    DateTime dateAdded = dog.DateAdded;
                    string sex = dog.DogDescription.Sex;
                    string statusOfBreed = dog.DogDescription.StatusofBreed;
                    string father = dog.DogDescription.Father;
                    string mother = dog.DogDescription.Mother;
                    string colour = dog.DogDescription.Colour;
                    string picturePath = dog.DogDescription.PicturePath;
                    DateTime updated = dog.DogDescription.Updated;
                    Boolean dead = dog.DogDescription.Dead;

                    cmd.Parameters.AddWithValue(@name, name);
                    cmd.Parameters.AddWithValue (@pedigree, pedigree);
                    cmd.Parameters.AddWithValue(tatoo, tatoo);
                    cmd.Parameters.AddWithValue("@dOB", dOB);
                    cmd.Parameters.AddWithValue("@dateAdded", dateAdded);
                    cmd.Parameters.AddWithValue(@sex, sex);
                    cmd.Parameters.AddWithValue(@statusOfBreed, statusOfBreed);
                    cmd.Parameters.AddWithValue(@father, father);
                    cmd.Parameters.AddWithValue(@mother, mother);
                    cmd.Parameters.AddWithValue(@colour, colour);
                    cmd.Parameters.AddWithValue(@picturePath, picturePath);
                    cmd.Parameters.AddWithValue("@updated", updated);
                    cmd.Parameters.AddWithValue("@dead", dead);

                    cmd.ExecuteNonQuery();
                }
            }
            

        }
        
    }
    
}
