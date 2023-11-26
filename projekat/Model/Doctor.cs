using System;
using Model;


namespace Model
{
   public class Doctor
   {
        public uint Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Specialization Specialization { get; set; }

        public string Adress { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Doctor()
        {

        }

        public Doctor(uint id)
        {
            Id = id;
        }

        public Doctor(uint id, string name, string surname, DateTime dateOfBirth, Specialization specialization, string adress, string email, Gender gender)
        {
            Id = id;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Specialization = specialization;
            Adress = adress;
            Email = email;
            Gender = gender;
        }

        public Doctor(string name, string surname, DateTime dateOfBirth, Specialization specialization, string adress, string email, Gender gender)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Specialization = specialization;
            Adress = adress;
            Email = email;
            Gender = gender;
        }

        public Doctor(uint id, string name, string surname, DateTime dateOfBirth, Specialization specialization, string adress, string email, Gender gender, string username, string password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Specialization = specialization;
            Adress = adress;
            Email = email;
            Gender = gender;
            Username = username;
            Password = password;
        }
    }
}