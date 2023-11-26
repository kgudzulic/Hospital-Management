using projekat.Model;
using System;

namespace Model
{
   public class Patient
    {
        public uint Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Adress { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }

        public string Password { get; set; }

        public string Username { get; set; }

        //public System.Collections.Generic.List<Allergen> allergen;
  
        public Patient()
        {

        }

        public Patient(uint id)
        {
            Id = id;
        }

        public Patient(uint id, string name, string surname, DateTime dateOfBirth, string adress, string email, Gender gender)
        {
            Id = id;
            Name = name;
            Surname = surname;
            this.DateOfBirth = dateOfBirth;
            Adress = adress;
            Email = email;
            Gender = gender;
        }

        public Patient(uint id, string name, string surname, DateTime dateOfBirth, string adress, string email, Gender gender, string password, string username)
        {
            Id = id;
            Name = name;
            Surname = surname;
            this.DateOfBirth = dateOfBirth;
            Adress = adress;
            Email = email;
            Gender = gender;
            Password = password;
            Username = username;
         
        }
   }
}