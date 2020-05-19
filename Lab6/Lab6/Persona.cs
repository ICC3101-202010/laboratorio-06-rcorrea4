using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    [Serializable]
    class Persona
    {
        private string name;
        private string lastName;
        private string rut;
        private string position;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Position { get => position; set => position = value; }

        public Persona(string name,string lastName,string rut,string position)
        {
            this.name = name;
            this.lastName = lastName;
            this.rut = rut;
            this.position = position;
        }
    }
}
