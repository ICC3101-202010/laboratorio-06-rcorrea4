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
        

        public string NameDivision { get => nameDivision; set => nameDivision = value; }
        
        public Division(string nameDivision)
        {
            this.nameDivision = nameDivision;
        }
     
    }
}
