using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_U1_S1_G2_ES
{
    public class Persona
    {

        //Proprietà
        private string Name { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }
        
        //Costruttore
        public Persona(string name, string lastname, int age)
        {
            Name = name;
            LastName = lastname;
            Age = age;
        }


        // Metodi
        public string GetName()
        {
            return Name;
        }
        public string GetLastname()
        {
            return LastName;
        }
        public int GetAge()
        {
            return Age;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"il nome è {Name}, il cognome è {LastName} e l`età è {Age}");
        }




    }
}
