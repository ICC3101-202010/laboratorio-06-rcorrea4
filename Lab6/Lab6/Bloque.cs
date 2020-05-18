using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    [Serializable]
    class Bloque: Division
    {
        public Bloque(string nameDivision) : base(nameDivision)
        {
            this.NameDivision = NameDivision;
        }
    }
}
