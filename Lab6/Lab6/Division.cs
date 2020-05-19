using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    [Serializable]
    class Division
    {
        private string nameDivision;
        private List<Persona> personal = new List<Persona>();
        private Persona encargadoDivision;
        

        public string NameDivision { get => nameDivision; set => nameDivision = value; }
        internal List<Persona> Personal { get => personal; set => personal = value; }
        internal Persona EncargadoDivision { get => encargadoDivision; set => encargadoDivision = value; }

        public Division(string nameDivision)
        {
            this.nameDivision = nameDivision;
        }
     
    }
}
